using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string email;
        string password;
        IMemberRepository memberRepository = new MemberRepository();
        private void btnLogIn_Click_1(object sender, EventArgs e)
        {

            if (txtEmail.Text.Trim().Equals("admin@fstore.com") && txtPassword.Text.Trim().Equals("admin@@"))
            {
                this.Hide();
                frmMemberManagement manage = new frmMemberManagement();
                manage.Show();
            }
            else if ((memberRepository.CheckLogin(txtEmail.Text.ToString(), txtEmail.Text.ToString()) != null))
            {
                this.Hide();
                this.email = ""; this.password = "";
                this.email = txtPassword.Text.ToString();
                this.password = txtPassword.Text.ToString();
                frmMemberDetail detail = new frmMemberDetail();
                detail.Show();
            }
            else
            {
                MessageBox.Show("Login failed!!", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
