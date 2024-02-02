namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMember = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtID = new TextBox();
            txtCountry = new TextBox();
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtCity = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnLogOut = new Button();
            cbCountryOrCity = new ComboBox();
            cbCityCountryName = new ComboBox();
            txtSearch = new TextBox();
            cbSearch = new ComboBox();
            btnSort = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(42, 402);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 29;
            dgvMember.Size = new Size(892, 231);
            dgvMember.TabIndex = 0;
            dgvMember.CellClick += dgvMember_CellClick;
            dgvMember.CellDoubleClick += dgvMember_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 39);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 112);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 2;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 176);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 39);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 4;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(494, 112);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 5;
            label5.Text = "Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 341);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 7;
            label7.Text = "Filter";
            // 
            // txtID
            // 
            txtID.Location = new Point(213, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(226, 27);
            txtID.TabIndex = 8;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(651, 105);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(226, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtName
            // 
            txtName.Location = new Point(651, 36);
            txtName.Name = "txtName";
            txtName.Size = new Size(226, 27);
            txtName.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(213, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(226, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(213, 105);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(226, 27);
            txtCity.TabIndex = 13;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(178, 241);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(373, 241);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(745, 241);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 17;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnClose_Click;
            // 
            // cbCountryOrCity
            // 
            cbCountryOrCity.FormattingEnabled = true;
            cbCountryOrCity.Items.AddRange(new object[] { "Country", "City" });
            cbCountryOrCity.Location = new Point(101, 338);
            cbCountryOrCity.Name = "cbCountryOrCity";
            cbCountryOrCity.Size = new Size(138, 28);
            cbCountryOrCity.TabIndex = 18;
            // 
            // cbCityCountryName
            // 
            cbCityCountryName.FormattingEnabled = true;
            cbCityCountryName.Location = new Point(245, 338);
            cbCityCountryName.Name = "cbCityCountryName";
            cbCityCountryName.Size = new Size(138, 28);
            cbCityCountryName.TabIndex = 19;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(563, 333);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(238, 27);
            txtSearch.TabIndex = 20;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Name", "ID" });
            cbSearch.Location = new Point(828, 333);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(106, 28);
            cbSearch.TabIndex = 21;
            // 
            // btnSort
            // 
            btnSort.Location = new Point(574, 241);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(94, 29);
            btnSort.TabIndex = 22;
            btnSort.Text = "DESC\r\nASC\r\n";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 645);
            Controls.Add(btnSort);
            Controls.Add(cbSearch);
            Controls.Add(txtSearch);
            Controls.Add(cbCityCountryName);
            Controls.Add(cbCountryOrCity);
            Controls.Add(btnLogOut);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtCity);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(txtCountry);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvMember);
            Name = "frmMemberManagement";
            Text = "frmMemberManagement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtID;
        private TextBox txtCountry;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtCity;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnLogOut;
        private ComboBox cbCountryOrCity;
        private ComboBox cbCityCountryName;
        private TextBox txtSearch;
        private ComboBox cbSearch;
        private Button btnSort;
    }
}