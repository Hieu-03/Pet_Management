using PetStore_Repository_PhamNgocHieu.Models;
using PetStore_Repository_PhamNgocHieu.Repository;
using System.Data;
using System.Diagnostics;

namespace PetStore_PhamNgocHieu
{
    public partial class frmPetManagement : Form
    {
        BindingSource source;
        private IPetRepository _petRepository;
        public frmPetManagement()
        {
            _petRepository = new PetRepository();
            InitializeComponent();
        }

        private void ClearText()
        {
            txtPetId.Text = string.Empty;
            txtPetName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            dtpImportDate.Text = string.Empty;
            cbGroupName.Text = string.Empty;
        }

        private void loadGroupNames()
        {
            var groups = _petRepository.GetGroups();
            foreach (var group in groups)
            {
                cbGroupName.Items.Add(group.PetGroupName);
            }
        }

        private void LoadPetsList(IEnumerable<Pet> petsList)
        {
            try
            {
                var list = petsList.Select(p => new
                {
                    PetId = p.PetId,
                    PetName = p.PetName,
                    PetDescription = p.PetDescription,
                    PetPrice = p.PetPrice,
                    Quantity = p.Quantity,
                    ImportDate = p.ImportDate,
                    PetGroupName = p.PetGroup.PetGroupName
                });

                source = new BindingSource();
                source.DataSource = list;

                ClearText();
                dgvPet.DataSource = null;
                dgvPet.DataSource = source;

                if (petsList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load pets list");
            }
        }


        private void frmPetManagement_Load(object sender, EventArgs e)
        {
            try
            {
                loadGroupNames();
                var petsList = _petRepository.GetAllPets();
                LoadPetsList(petsList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load pets list");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchValue.Text == "")
                {
                    MessageBox.Show("Please enter search value.", "Search pets");
                }
                else if (cbSearh.Text == "")
                {
                    MessageBox.Show("Please select search type.", "Search pets");
                }
                else if (cbSearh.Text == "Quantity")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtSearchValue.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.", "Search pets");
                        txtSearchValue.Text = txtSearchValue.Text.Remove(txtSearchValue.Text.Length - 1);
                    }
                    else
                    {
                        var pets = _petRepository.SearchPetsByQuantity(txtSearchValue.Text).ToList();
                        LoadPetsList(pets);
                    }
                }
                else
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(txtSearchValue.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter only numbers.", "Search pets");
                        txtSearchValue.Text = txtSearchValue.Text.Remove(txtSearchValue.Text.Length - 1);
                    }
                    else
                    {
                        var pets = _petRepository.SearchPetsByPrice(txtSearchValue.Text).ToList();
                        LoadPetsList(pets);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load pets list");
            }
        }

        private bool checkInput()
        {
            if (txtPetId.Text == "" || txtPetName.Text == "" || txtDescription.Text == "" || dtpImportDate.Text == "" ||
                    txtQuantity.Text == "" || txtPrice.Text == "" || cbGroupName.Text == "")
            {
                MessageBox.Show("All fields are required.", "Add pet");
                return false;
            }
            else
            {
                if (Double.Parse(txtPrice.Text) < 0 || Int32.Parse(txtQuantity.Text) < 0)
                {
                    MessageBox.Show("Value for PetPrice and Quantity is greater than or equal to 0.", "Add pet");
                    return false;
                }
                else
                {
                    if (txtPetName.Text.Length < 5 || txtPetName.Text.Length > 20 || !char.IsUpper(txtPetName.Text.ToCharArray()[0]) || !System.Text.RegularExpressions.Regex.IsMatch(txtPetName.Text, "^[a-zA-Z0-9 ]+$"))
                    {
                        Debug.WriteLine(txtPetName.Text.Length < 5 || txtPetName.Text.Length > 20);
                        Debug.WriteLine(!char.IsUpper(txtPetName.Text.ToCharArray()[0]));
                        Debug.WriteLine(!System.Text.RegularExpressions.Regex.IsMatch(txtPetName.Text, "^[a-zA-Z0-9 ]+$"));
                        Debug.WriteLine("");
                        MessageBox.Show("PetName is invalid.", "Add pets");
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {

                    int petId = Int32.Parse(txtPetId.Text);
                    string petName = txtPetName.Text;
                    string petDescription = txtDescription.Text;
                    DateTime importDate = DateTime.Parse(dtpImportDate.Text);
                    int quantity = Int32.Parse(txtQuantity.Text);
                    double petPrice = Double.Parse(txtPrice.Text);
                    string groupName = cbGroupName.Text;

                    Pet pet = _petRepository.GetPetById(petId);
                    if (pet != null)
                    {
                        MessageBox.Show("Pet already exists", "Add pet");
                    }
                    else
                    {
                        PetGroup group = _petRepository.GetGroups().Where(g => g.PetGroupName == groupName).FirstOrDefault();
                        Pet newPet = new Pet
                        {
                            PetId = petId,
                            PetName = petName,
                            PetDescription = petDescription,
                            ImportDate = importDate,
                            PetPrice = petPrice,
                            Quantity = quantity,
                            PetGroupId = group.PetGroupId,
                            PetGroup = group,
                        };
                        _petRepository.AddPet(newPet);
                        MessageBox.Show("New pet added!", "Add pet");
                        var pets = _petRepository.SearchPetsByPrice(txtSearchValue.Text);
                        LoadPetsList(pets);
                        source.Position = source.Count - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add pet");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInput())
                {
                    int petId = Int32.Parse(txtPetId.Text);
                    Pet pet = _petRepository.GetPetById(petId);
                    if (pet == null)
                    {
                        MessageBox.Show("Cannot find pet", "Update pet");
                    }
                    else
                    {
                        string petName = txtPetName.Text;
                        string petDescription = txtDescription.Text;
                        DateTime importDate = DateTime.Parse(dtpImportDate.Text);
                        int quantity = Int32.Parse(txtQuantity.Text);
                        double petPrice = Double.Parse(txtPrice.Text);
                        string groupName = cbGroupName.Text;
                        PetGroup group = _petRepository.GetGroups().Where(g => g.PetGroupName == groupName).FirstOrDefault();
                        pet.PetName = petName;
                        pet.PetDescription = petDescription;
                        pet.ImportDate = importDate;
                        pet.PetPrice = petPrice;
                        pet.Quantity = quantity;
                        pet.PetGroupId = group.PetGroupId;
                        _petRepository.UpdatePet(pet);
                        var pets = _petRepository.GetAllPets();
                        LoadPetsList(pets);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update pet");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int petId = Int32.Parse(txtPetId.Text);
                Pet p = _petRepository.GetPetById(petId);
                if (p != null)
                {
                    var confirm = MessageBox.Show("Do you want to delete this pet", "Delete confirm", MessageBoxButtons.OKCancel);
                    if (confirm == DialogResult.OK)
                    {
                        _petRepository.DeletePet(petId);
                        var pets = _petRepository.GetAllPets();
                        LoadPetsList(pets);
                    }

                }
                else
                {
                    MessageBox.Show("The pet does not exist", "Delete pet");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete pet");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void dgvPet_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                txtPetId.Text = dgvPet.Rows[e.RowIndex].Cells["PetId"].Value.ToString();
                txtPetName.Text = dgvPet.Rows[e.RowIndex].Cells["PetName"].Value.ToString();
                txtDescription.Text = dgvPet.Rows[e.RowIndex].Cells["PetDescription"].Value.ToString();
                txtPrice.Text = dgvPet.Rows[e.RowIndex].Cells["PetPrice"].Value.ToString();
                txtQuantity.Text = dgvPet.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
                dtpImportDate.Text = dgvPet.Rows[e.RowIndex].Cells["ImportDate"].Value.ToString();
                cbGroupName.Text = dgvPet.Rows[e.RowIndex].Cells["PetGroupName"].Value.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
