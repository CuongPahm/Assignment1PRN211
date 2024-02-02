namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtID = new TextBox();
            txtCity = new TextBox();
            txtEmail = new TextBox();
            txtName = new TextBox();
            txtCountry = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 105);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 178);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 253);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 105);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 3;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 178);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 253);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // txtID
            // 
            txtID.Location = new Point(151, 105);
            txtID.Name = "txtID";
            txtID.Size = new Size(229, 27);
            txtID.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(151, 175);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(229, 27);
            txtCity.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 250);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(229, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(524, 105);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(524, 175);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(229, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(524, 250);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(229, 27);
            txtPassword.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(200, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(458, 339);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 450);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            Controls.Add(txtCity);
            Controls.Add(txtID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetail";
            Text = "frmMemberDetail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtID;
        private TextBox txtCity;
        private TextBox txtEmail;
        private TextBox txtName;
        private TextBox txtCountry;
        private TextBox txtPassword;
        private Button btnSave;
        private Button btnClose;
    }
}