namespace PetStore_PhamNgocHieu
{
    partial class frmPetManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnUpdate = new Button();
            btnSearch = new Button();
            cbSearh = new ComboBox();
            txtSearchValue = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            cbGroupName = new ComboBox();
            txtDescription = new TextBox();
            label10 = new Label();
            btnDelete = new Button();
            btnClose = new Button();
            dgvPet = new DataGridView();
            dtpImportDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPet).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(30, 183);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(392, 183);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(715, 123);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearh
            // 
            cbSearh.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSearh.FormattingEnabled = true;
            cbSearh.Items.AddRange(new object[] { "Quantity", "Price" });
            cbSearh.Location = new Point(669, 53);
            cbSearh.Name = "cbSearh";
            cbSearh.Size = new Size(121, 23);
            cbSearh.TabIndex = 3;
            // 
            // txtSearchValue
            // 
            txtSearchValue.Location = new Point(669, 85);
            txtSearchValue.Name = "txtSearchValue";
            txtSearchValue.Size = new Size(121, 23);
            txtSearchValue.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 27);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 7;
            label3.Text = "Pet ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 56);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Pet name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 88);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 9;
            label5.Text = "Import date";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(333, 27);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 10;
            label6.Text = "Quantity";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(353, 56);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 11;
            label7.Text = "Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 88);
            label8.Name = "label8";
            label8.Size = new Size(73, 15);
            label8.TabIndex = 12;
            label8.Text = "Group name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 114);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 13;
            label9.Text = "Description";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(95, 53);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(195, 23);
            txtPetName.TabIndex = 14;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(95, 24);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(195, 23);
            txtPetId.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(392, 24);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(167, 23);
            txtQuantity.TabIndex = 17;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(392, 53);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(167, 23);
            txtPrice.TabIndex = 18;
            // 
            // cbGroupName
            // 
            cbGroupName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGroupName.FormattingEnabled = true;
            cbGroupName.Location = new Point(392, 85);
            cbGroupName.Name = "cbGroupName";
            cbGroupName.Size = new Size(167, 23);
            cbGroupName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(95, 111);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(195, 23);
            txtDescription.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(642, 24);
            label10.Name = "label10";
            label10.Size = new Size(148, 15);
            label10.TabIndex = 19;
            label10.Text = "Search by quantity or price";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(715, 183);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(392, 445);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dgvPet
            // 
            dgvPet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPet.Location = new Point(30, 221);
            dgvPet.Name = "dgvPet";
            dgvPet.RowTemplate.Height = 25;
            dgvPet.Size = new Size(760, 206);
            dgvPet.TabIndex = 21;
            dgvPet.CellClick += dgvPet_Click;
            // 
            // dtpImportDate
            // 
            dtpImportDate.Format = DateTimePickerFormat.Short;
            dtpImportDate.Location = new Point(95, 82);
            dtpImportDate.Name = "dtpImportDate";
            dtpImportDate.Size = new Size(195, 23);
            dtpImportDate.TabIndex = 22;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(579, 56);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 10;
            label1.Text = "Quantity/price";
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Location = new Point(590, 88);
            label2.Name = "label2";
            label2.Size = new Size(73, 15);
            label2.TabIndex = 11;
            label2.Text = "Search value";
            // 
            // frmPetManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 479);
            Controls.Add(dtpImportDate);
            Controls.Add(dgvPet);
            Controls.Add(btnClose);
            Controls.Add(label10);
            Controls.Add(txtDescription);
            Controls.Add(txtPrice);
            Controls.Add(txtQuantity);
            Controls.Add(txtPetId);
            Controls.Add(txtPetName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSearchValue);
            Controls.Add(cbGroupName);
            Controls.Add(cbSearh);
            Controls.Add(btnDelete);
            Controls.Add(btnSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Name = "frmPetManagement";
            Text = "Pet Management";
            Load += frmPetManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnUpdate;
        private Button btnSearch;
        private ComboBox cbSearh;
        private TextBox txtSearchValue;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtPetName;
        private TextBox txtPetId;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private ComboBox cbGroupName;
        private TextBox txtDescription;
        private Label label10;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dgvPet;
        private DateTimePicker dtpImportDate;
        private Label label1;
        private Label label2;
    }
}