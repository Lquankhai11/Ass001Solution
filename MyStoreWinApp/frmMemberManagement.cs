using BusinessObject;
using DataAccess;
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
        public IMemberRepository MemberRepository { get; set; }
        public MemberObject CurrentMember { get; set; }
        //Tạo data source
        BindingSource source;

        public frmMemberManagement()
        {
            InitializeComponent();
            MemberRepository = new MemberRepository();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            List<MemberObject> memberList = MemberRepository.GetListAllMember();
            try
            {
                source = new BindingSource();
                source.DataSource = memberList;

                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                //Load city và country vào combobox
                cbFilterCity.DataSource = MemberRepository.GetCities();
                cbFilterCountry.DataSource = MemberRepository.GetCountries();
                //Set mặc định cho cbFilterCity và cbFilterCountry
                cbFilterCountry.SelectedIndex = -1;
                cbFilterCity.SelectedIndex = -1;

                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
                if (memberList.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List");
            }
        }
        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtMemberName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            cbSortID.SelectedIndex = -1;
            cbSortName.SelectedIndex = -1;
            cbTypeSearch.SelectedIndex = -1;
            loadData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {
                frmMemberDetail newMemberForm = new frmMemberDetail();

                if (newMemberForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy thông tin thành viên mới từ form
                    MemberObject newMember = newMemberForm.NewMember;
                    MemberRepository.InsertMember(newMember);
                    loadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int memberId = int.Parse(txtMemberID.Text);
                string memberName = txtMemberName.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                string city = txtCity.Text;
                string country = txtCountry.Text;
                MemberObject updatedMember = new MemberObject(memberId, memberName, email, password, city, country);

                frmMemberDetail updateForm = new frmMemberDetail();
                updateForm.IsUpdating = true;
                // Truyền thông tin thành viên cần cập nhật vào form detail
                updateForm.UpdatedMember = updatedMember;
                // Cập nhật dữ liệu trên form detail
                updateForm.UpdateFormData(updatedMember);
                updateForm.ShowDialog();
                // Làm mới dữ liệu và các TextBox
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchType = cbTypeSearch.SelectedItem.ToString();
                string searchText = txtSearch.Text;
                List<MemberObject> searchResult = new List<MemberObject>();

                switch (searchType)
                {
                    case "ID":
                        int memberId;
                        if (int.TryParse(searchText, out memberId))
                        {
                            searchResult = MemberRepository.SearchMemberByID(memberId);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a number to search by ID.");
                            return;
                        }
                        break;
                    case "Email":
                        searchResult = MemberRepository.SearchMemberByEmail(searchText);
                        break;
                    case "Name":
                        searchResult = MemberRepository.SearchMemberByName(searchText);
                        break;
                    case "City":
                        searchResult = MemberRepository.SearchMemberByCity(searchText);
                        break;
                    case "Country":
                        searchResult = MemberRepository.SearchMemberByCountry(searchText);
                        break;

                    default:
                        MessageBox.Show("Not found.");
                        return;
                }

                // Hiển thị kết quả tìm kiếm
                source.DataSource = searchResult;
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbFilterCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterCountry.SelectedIndex != -1)
            {
                string selectedCountry = cbFilterCountry.SelectedItem.ToString();
                List<MemberObject> filteredMembers = new List<MemberObject>();
                filteredMembers = MemberRepository.FilterByCountry(selectedCountry);
                UpdateCityComboBox(selectedCountry);
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
            else
            {
                // Trường hợp không chọn gì ở combobox Country
                cbFilterCity.DataSource = null;
            }
        }

        private void UpdateCityComboBox(string selectedCountry)
        {
            List<string> cities = MemberRepository.GetCitiesByCountry(selectedCountry);
            cbFilterCity.DataSource = cities;
        }

        private void cbFilterCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterCity.SelectedIndex != -1)
            {
                string selectedCity = cbFilterCity.SelectedItem.ToString();
                List<MemberObject> filteredMembers = new List<MemberObject>();
                filteredMembers = MemberRepository.FilterByCity(selectedCity);
                dgvMemberList.DataSource = null;
                dgvMemberList.DataSource = source;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có thành viên nào được chọn không
                if (dgvMemberList.CurrentRow != null)
                {
                    int memberId = Convert.ToInt32(dgvMemberList.CurrentRow.Cells["MemberID"].Value);
                    MemberRepository.DeleteMember(memberId);
                    MessageBox.Show("Member deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Làm mới dữ liệu 
                    loadData();
                }
                else
                {
                    MessageBox.Show("Please select a member to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSortID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedSortID = cbSortID.SelectedItem.ToString();
                switch (selectedSortID)
                {
                    case "ASC":
                        MemberRepository.SortMembersAscendingID();
                        break;
                    case "DESC":
                        MemberRepository.SortMembersDescendingID();
                        break;
                    default:
                        MessageBox.Show("Invalid sort option selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                // Load lại sau khi sort
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSortName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedSortName = cbSortName.SelectedItem.ToString();
                switch (selectedSortName)
                {
                    case "ASC":
                        MemberRepository.SortMembersAscendingName();
                        break;
                    case "DESC":
                        MemberRepository.SortMembersDescendingName();
                        break;
                    default:
                        MessageBox.Show("Invalid sort option selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
                // Load lại sau khi sort
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
