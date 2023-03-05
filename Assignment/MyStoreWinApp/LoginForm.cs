using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess;
using DataAccess.Repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private static frmLogin instance = null;
        public static frmLogin Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new frmLogin();
                }
                return instance;
            }
        }
        private IMemberRepository memberRepository;

        private frmLogin()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string text = File.ReadAllText("appsettings.json");
            MemberObject security = JsonSerializer.Deserialize<MemberObject>(text);
            if(txtEmail.Text.Equals(security.Email) && txtPassword.Text.Equals(security.Password))
            {
                this.Hide();
                frmMemberManagement.Instance.Show();
            }
            else
            {
                MemberObject? m = memberRepository.MemberLogin(txtEmail.Text, txtPassword.Text);
                if(m != null)
                {
                    this.Hide();
                    frmMemberDetails.Instance.InsertOrUpdate = true;
                    frmMemberDetails.Instance.memberRepository = memberRepository;
                    frmMemberDetails.Instance.Member = m;
                    frmMemberDetails.Instance.Text = "Member Details";
                    frmMemberDetails.Instance.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password!!!");
                }
            }
        }
    }
}
