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
    public partial class frmMemberDetails : Form
    {

        private static frmMemberDetails instance =null;
        public static frmMemberDetails Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new frmMemberDetails();
                }
                return instance;
            }
        }

        public IMemberRepository memberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public MemberObject Member { get; set; }
        private frmMemberDetails()
        {
            InitializeComponent();
        }


        private void MemberDetails_Load(object sender, EventArgs e)
        {
            txtId.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate)
            {
                txtCity.Text = Member.City.ToString();
                txtId.Text = Member.Id.ToString(); 
                txtName.Text = Member.Name.ToString();
                txtCountry.Text = Member.Country.ToString();
                txtPassword.Text = Member.Password.ToString(); 
                txtEmail.Text = Member.Email.ToString();
            }
            else
            {
                txtCity.Text = string.Empty;
                txtId.Text = string.Empty;
                txtName.Text = string.Empty;
                txtCountry.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MemberObject newMember = new MemberObject
                {
                    Id = txtId.Text,
                    Name = txtName.Text,
                    Country = txtCountry.Text,
                    City = txtCity.Text,
                    Email= txtEmail.Text,
                    Password = txtPassword.Text
                };
                string mess;
                if (InsertOrUpdate)
                {
                    memberRepository.UpdateMember(newMember);
                    mess = "Update success!!!";
                }
                else
                {
                    memberRepository.AddNewMember(newMember);
                    mess = "Add success!!!";
                }
                MessageBox.Show(mess);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void frmMemberDetails_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Text == "Member Details")
            {
                frmLogin.Instance.Close();
            }
        }
    }
}
