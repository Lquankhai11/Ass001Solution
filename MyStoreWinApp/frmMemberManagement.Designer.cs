namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            lbCity = new Label();
            lbCountry = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            lbMemberID = new Label();
            lbMemberName = new Label();
            txtCountry = new TextBox();
            txtEmail = new TextBox();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            cbTypeSearch = new ComboBox();
            txtSearch = new TextBox();
            cbSortName = new ComboBox();
            cbSortID = new ComboBox();
            lbEmail = new Label();
            label7 = new Label();
            label8 = new Label();
            dgvMemberList = new DataGridView();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnNew = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnClose = new Button();
            cbFilterCity = new ComboBox();
            cbFilterCountry = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).BeginInit();
            SuspendLayout();
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(432, 87);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(37, 20);
            lbCity.TabIndex = 0;
            lbCity.Text = "City:";
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(406, 128);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(63, 20);
            lbCountry.TabIndex = 0;
            lbCountry.Text = "Country:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 179);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 0;
            label3.Text = "Search:";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(480, 84);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(248, 27);
            txtCity.TabIndex = 5;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(32, 51);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(87, 20);
            lbMemberID.TabIndex = 0;
            lbMemberID.Text = "Member ID:";
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(10, 84);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(112, 20);
            lbMemberName.TabIndex = 0;
            lbMemberName.Text = "Member Name:";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(480, 128);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(248, 27);
            txtCountry.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(125, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(266, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(125, 44);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(266, 27);
            txtMemberID.TabIndex = 1;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(125, 81);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(266, 27);
            txtMemberName.TabIndex = 2;
            // 
            // cbTypeSearch
            // 
            cbTypeSearch.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTypeSearch.FormattingEnabled = true;
            cbTypeSearch.Items.AddRange(new object[] { "ID", "Name", "Email", "City", "Country" });
            cbTypeSearch.Location = new Point(125, 170);
            cbTypeSearch.Name = "cbTypeSearch";
            cbTypeSearch.Size = new Size(73, 28);
            cbTypeSearch.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(224, 171);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(213, 27);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cbSortName
            // 
            cbSortName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSortName.FormattingEnabled = true;
            cbSortName.Items.AddRange(new object[] { "ASC", "DESC" });
            cbSortName.Location = new Point(849, 166);
            cbSortName.Name = "cbSortName";
            cbSortName.Size = new Size(151, 28);
            cbSortName.TabIndex = 10;
            cbSortName.SelectedIndexChanged += cbSortName_SelectedIndexChanged;
            // 
            // cbSortID
            // 
            cbSortID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSortID.FormattingEnabled = true;
            cbSortID.Items.AddRange(new object[] { "ASC", "DESC" });
            cbSortID.Location = new Point(539, 171);
            cbSortID.Name = "cbSortID";
            cbSortID.Size = new Size(151, 28);
            cbSortID.TabIndex = 9;
            cbSortID.SelectedIndexChanged += cbSortID_SelectedIndexChanged;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(49, 131);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(455, 174);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 0;
            label7.Text = "Sort by ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(740, 174);
            label8.Name = "label8";
            label8.Size = new Size(103, 20);
            label8.TabIndex = 0;
            label8.Text = "Sort by Name:";
            // 
            // dgvMemberList
            // 
            dgvMemberList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMemberList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMemberList.Location = new Point(2, 275);
            dgvMemberList.Name = "dgvMemberList";
            dgvMemberList.RowHeadersWidth = 51;
            dgvMemberList.RowTemplate.Height = 29;
            dgvMemberList.Size = new Size(1020, 333);
            dgvMemberList.TabIndex = 4;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(255, 227);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(470, 227);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(688, 227);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(49, 227);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 8;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(396, 51);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(480, 48);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(248, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(888, 227);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // cbFilterCity
            // 
            cbFilterCity.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Location = new Point(849, 107);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new Size(151, 28);
            cbFilterCity.TabIndex = 13;
            cbFilterCity.SelectedIndexChanged += cbFilterCity_SelectedIndexChanged;
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Location = new Point(849, 56);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new Size(151, 28);
            cbFilterCountry.TabIndex = 14;
            cbFilterCountry.SelectedIndexChanged += cbFilterCountry_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(769, 110);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Filter City:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(743, 59);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 0;
            label2.Text = "Filter Country:";
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1024, 610);
            Controls.Add(cbFilterCountry);
            Controls.Add(cbFilterCity);
            Controls.Add(btnClose);
            Controls.Add(btnNew);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dgvMemberList);
            Controls.Add(cbSortID);
            Controls.Add(cbSortName);
            Controls.Add(cbTypeSearch);
            Controls.Add(txtSearch);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtCountry);
            Controls.Add(txtMemberID);
            Controls.Add(txtPassword);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(lbMemberName);
            Controls.Add(lbEmail);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(lbCountry);
            Controls.Add(lbPassword);
            Controls.Add(lbMemberID);
            Controls.Add(label1);
            Controls.Add(lbCity);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMemberList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCity;
        private Label lbCountry;
        private Label label3;
        private TextBox txtCity;
        private Label lbMemberID;
        private Label lbMemberName;
        private TextBox txtCountry;
        private TextBox txtEmail;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private ComboBox cbTypeSearch;
        private TextBox txtSearch;
        private ComboBox cbSortName;
        private ComboBox cbSortID;
        private Label lbEmail;
        private Label label7;
        private Label label8;
        private DataGridView dgvMemberList;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnNew;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnClose;
        private ComboBox cbFilterCity;
        private ComboBox cbFilterCountry;
        private Label label1;
        private Label label2;
    }
}