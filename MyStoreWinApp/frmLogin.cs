using DataAccess.Repository;
using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DataAccess;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        private string email;
        private string password;
        private bool isPasswordVisible = false;
        public frmLogin(string email, string password)
        {
            this.email = email;
            this.password = password;
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e) { Close(); }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (email == txtEmail.Text && password == txtPassword.Text)
            {
                MessageBox.Show("Login Successfull.");
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                this.Hide();
                frmMemberManagement.ShowDialog();
                this.Show();
            }
            else
            {
                // Normal user login, view and update their information
                string inputEmail = txtEmail.Text;
                string inputPassword = txtPassword.Text;
                MemberObject member = MemberDAO.Instance.GetMemberByEmailAndPassword(inputEmail, inputPassword);
                if (member != null)
                {
                    MessageBox.Show("User Login Successfull.");
                    frmMemberDetail frmMemberDetail = new frmMemberDetail();
                    frmMemberDetail.UpdateFormData(member);
                    frmMemberDetail.IsUpdating = true;
                    this.Hide();
                    frmMemberDetail.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Wrong email or password", "Error Mess", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = email;
            txtPassword.Text = password;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
        }
    }
    
}
