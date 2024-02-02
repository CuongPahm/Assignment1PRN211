using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;


        private void btnInsert_Click(object sender, EventArgs e)
        {
            frmMemberDetail detail = new frmMemberDetail
            {
                Text = "Add member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            this.Hide();
            detail.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlr = MessageBox.Show("Do you want to delete ?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if ( dlr == DialogResult.Yes)
                {
                    var member = GetMemberObject();
                    memberRepository.DeleteMember(member);
                    List<MemberObject> list = memberRepository.GetAllMembers().ToList();
                    dgvMember.DataSource = list;
                    txtID.Clear();
                    txtCity.Clear();
                    txtName.Clear();
                    txtCity.Clear();
                    txtCountry.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Delete canceled.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            List<MemberObject> list = memberRepository.GetAllMembers().ToList();
            dgvMember.DataSource = list;
        }

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetail detail = new frmMemberDetail
            {
                Text = "Update member",
                InsertOrUpdate = true,
                MemberRepository = memberRepository
            };
            if (detail.ShowDialog() == DialogResult.OK)
            {
                source.Position = source.Count - 1;
            }
            this.Hide();
            detail.Show();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            txtID.Text = dgvMember.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            txtName.Text = dgvMember.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
            txtEmail.Text = dgvMember.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
            txtCity.Text = dgvMember.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
            txtCountry.Text = dgvMember.Rows[e.RowIndex].Cells[5].FormattedValue.ToString();
        }

        private MemberObject GetMemberObject()
        {
            MemberObject member = null;
            try
            {
                member = new MemberObject
                {
                    MemberID = int.Parse(txtID.Text),
                    MemberName = txtName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return member;
        }
    }
}
