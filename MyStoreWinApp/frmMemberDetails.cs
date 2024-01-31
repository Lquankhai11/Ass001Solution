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
using BusinessObject;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataAccess.Repository;
using DataAccess;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public bool IsUpdating { get; set; }

        public MemberObject NewMember { get; private set; }
        public MemberObject UpdatedMember { get; set; }
        public frmMemberDetail()
        {
            InitializeComponent();
            IsUpdating = false;
        }

        public void UpdateFormData(MemberObject updatedMember)
        {
            // Cập nhật các control trên form với thông tin của thành viên
            txtMemberID.Text = updatedMember.MemberID.ToString();
            txtMemberName.Text = updatedMember.MemberName;
            txtEmail.Text = updatedMember.Email;
            txtPassword.Text = updatedMember.Password;
            txtCity.Text = updatedMember.City;
            txtCountry.Text = updatedMember.Country;
            txtMemberID.ReadOnly = IsUpdating;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUpdating == false)
                {
                    // Lấy thông tin từ TextBox và tạo thành viên mới
                    int memberId = int.Parse(txtMemberID.Text); // Chuyển đổi từ chuỗi sang int
                    string memberName = txtMemberName.Text;
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;
                    string city = txtCity.Text;
                    string country = txtCountry.Text;
                    // Kiểm tra xem MemberID đã tồn tại hay chưa
                    if (MemberDAO.Instance.GetMemberByID(memberId) != null)
                    {
                        MessageBox.Show("Member ID already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    // Tạo đối tượng MemberObject
                    NewMember = new MemberObject(memberId, memberName, email, password, city, country);
                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    int memberId = int.Parse(txtMemberID.Text);
                    string memberName = txtMemberName.Text;
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;
                    string city = txtCity.Text;
                    string country = txtCountry.Text;
                    UpdatedMember = new MemberObject(memberId, memberName, email, password, city, country);
                    MemberDAO.Instance.UpdateMember(UpdatedMember);
                    MessageBox.Show("Member updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
