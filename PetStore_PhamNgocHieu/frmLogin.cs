using Microsoft.Extensions.Configuration;
using PetStore_Repository_PhamNgocHieu.Models;
using PetStore_Repository_PhamNgocHieu.Repository;
using System.Diagnostics;
using System.Net.Mail;

namespace PetStore_PhamNgocHieu
{
    public partial class frmLogin : Form
    {
        IPetShopMemberRepository _memberRepository;
        public frmLogin()
        {
            _memberRepository = new PetShopMemberRepository();
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                MessageBox.Show("Please enter email.");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password.");
            }
            else
            {

                var user = _memberRepository.GetMembers()
                .FirstOrDefault(m => m.EmailAddress == txtEmail.Text && m.MemberPassword == txtPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Email or password is incorrect.");
                }
                else
                {
                    if (user.MemberRole != 2)
                    {
                        MessageBox.Show("You have no permission to access this function!");
                    }
                    else
                    {
                        frmPetManagement petForm = new frmPetManagement();
                        this.Hide();
                        petForm.Show();
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();
    }
}