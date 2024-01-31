namespace MyStoreWinApp
{
    partial class frmLogin
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
            lbEmail = new Label();
            txtEmail = new TextBox();
            btnLogin = new Button();
            lbPassword = new Label();
            txtPassword = new TextBox();
            btnClose = new Button();
            btnView = new Button();
            SuspendLayout();
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(121, 57);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(49, 20);
            lbEmail.TabIndex = 0;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(188, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Please enter your email here.";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(97, 175);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(130, 39);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(97, 102);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(73, 20);
            lbPassword.TabIndex = 0;
            lbPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(188, 104);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Please enter your password here.";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(311, 175);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 39);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnView
            // 
            btnView.Location = new Point(441, 104);
            btnView.Name = "btnView";
            btnView.Size = new Size(50, 29);
            btnView.TabIndex = 5;
            btnView.Text = "View";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 290);
            Controls.Add(btnView);
            Controls.Add(btnClose);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbPassword);
            Controls.Add(lbEmail);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEmail;
        private TextBox txtEmail;
        private Button btnLogin;
        private Label lbPassword;
        private TextBox txtPassword;
        private Button btnClose;
        private Button btnView;
    }
}