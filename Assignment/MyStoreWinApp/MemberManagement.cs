using BusinessObject;
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

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        private static frmMemberManagement instance = null;
        public static frmMemberManagement Instance
        {
            get 
            {
                if(instance == null)
                {
                    instance = new frmMemberManagement();
                }
                return instance; 
            }
        }

        BindingSource source;

        private frmMemberManagement()
        {
            InitializeComponent();
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            LoadMemberList(member.GetAll());
            LoadAllCity();
            LoadAllCountry();
        }

        private IMemberRepository member = new MemberRepository();

        private void LoadMemberList(List<MemberObject> members)
        {
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtCurrentID.DataBindings.Clear();
                txtTestName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtCurrentID.DataBindings.Add("Text", source, "Id");
                txtTestName.DataBindings.Add("Text", source, "Name");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (members.Count() == 0)
                {
                    CleatText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Load Member");
            }
        }

        private void CleatText()
        {
            txtCurrentID.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtTestName.Text = string.Empty;
        }

        private MemberObject GetMember()
        {
            MemberObject m = null;
            try
            {
                m = new MemberObject
                {
                    Id = txtCurrentID.Text,
                    Name = txtTestName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Password= txtPassword.Text,
                };
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "get object");
            }
            return m;
        }

        private void LoadAllCity()
        {
            cboCity.DataSource = member.GetAllCity();
        }

        private void LoadAllCountry()
        {
            cboCountry.DataSource = member.GetAllCountry();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            dgvMemberList.CellDoubleClick+= dgvMemberList_CellDoubleClick;
        }


        private void frmMemberManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.Instance.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails.Instance.InsertOrUpdate = false;
            frmMemberDetails.Instance.memberRepository = member;
            frmMemberDetails.Instance.Text = "Add New Member Form";
            if (frmMemberDetails.Instance.ShowDialog() == DialogResult.OK)
            {
                LoadAllCity();
                LoadAllCountry();
                LoadMemberList(member.GetAll());
                source.Position = source.Count- 1;
            }
            
        }

        private void cboCity_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedIndex <= 0)
            {
                LoadMemberList(member.GetAll());
            }
            else
            {
                cboCountry.SelectedIndex = -1;
                LoadMemberList(member.GetMemberByCity(cb.Text));
            }
        }

        private void cboCountry_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex <= 0)
            {
                LoadMemberList(member.GetAll());
            }
            else
            {
                cboCity.SelectedIndex = -1;
                LoadMemberList(member.GetMemberByCountry(cb.Text));
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboCity.SelectedIndex = -1;
            cboCountry.SelectedIndex = -1;
            LoadMemberList(member.GetMemberByIdAndName(txtId.Text, txtName.Text));
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            member.SortMemberListByName();
            LoadMemberList(member.GetAll());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var m = GetMember();
                member.DeleteMember(m);
                LoadMemberList(member.GetAll());
                LoadAllCity();
                LoadAllCountry();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + "Del");
            }
        }

        private void dgvMemberList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMemberDetails.Instance.InsertOrUpdate = true;
            frmMemberDetails.Instance.memberRepository = member;
            frmMemberDetails.Instance.Member = GetMember();
            frmMemberDetails.Instance.Text = "Update Form";
            if(frmMemberDetails.Instance.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList(member.GetAll());
                LoadAllCity();
                LoadAllCountry();
            }
            //frmMemberDetails.Instance.Close();
        }

        private void txtTestName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
