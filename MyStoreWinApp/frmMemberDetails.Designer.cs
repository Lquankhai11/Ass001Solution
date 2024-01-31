namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            btnSave = new Button();
            btnCancel = new Button();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCity = new TextBox();
            txtCountry = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 262);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(346, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(153, 26);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(287, 27);
            txtMemberID.TabIndex = 1;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(153, 59);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(287, 27);
            txtMemberName.TabIndex = 2;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(153, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(153, 136);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 27);
            txtPassword.TabIndex = 4;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(153, 169);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(287, 27);
            txtCity.TabIndex = 5;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(153, 202);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(287, 27);
            txtCountry.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 33);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 2;
            label1.Text = "MemberID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 66);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 2;
            label2.Text = "Member Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 106);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 2;
            label3.Text = "Email: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 143);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 2;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 176);
            label5.Name = "label5";
            label5.Size = new Size(37, 20);
            label5.TabIndex = 2;
            label5.Text = "City:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 209);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 2;
            label6.Text = "Coutry:";
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 324);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtCountry);
            Controls.Add(txtCity);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Name = "frmMemberDetail";
            Text = "frmMemberDetails";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCity;
        private TextBox txtCountry;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}