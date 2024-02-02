using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        public IMemberRepository MemberRepository { get; set; }
        public MemberObject MemberInfo { get; set; }
        public bool InsertOrUpdate { get; set; } //fasle:insert , true: update

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text

                };
                if (InsertOrUpdate == false)
                {
                    MemberRepository.AddMember(member);
                    frmMemberManagement manage = new frmMemberManagement();
                    this.Hide();
                    manage.Show();
                }
                else
                {
                    MemberRepository.UpdateMember(member);
                    frmMemberManagement manage = new frmMemberManagement();
                    this.Hide();
                    manage.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new car" : "Update car");
            }
        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            if(InsertOrUpdate == true)
            {
                LoadMember();
            }
        }

        private void LoadMember()
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMemberManagement manage = new frmMemberManagement();
            manage.Show();
        }
    }
}
