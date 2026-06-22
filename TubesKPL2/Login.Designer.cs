namespace TubesKPL2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblTitle = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnBRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(18, 64);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email   :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(180, 61);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(136, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(149, 20);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "REGISTER GOODBITE";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(18, 109);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 20);
            lblPassword.TabIndex = 8;
            lblPassword.Text = "Password   :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(180, 106);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 7;
            // 
            // btnBRegister
            // 
            btnBRegister.Location = new Point(18, 212);
            btnBRegister.Name = "btnBRegister";
            btnBRegister.Size = new Size(153, 33);
            btnBRegister.TabIndex = 12;
            btnBRegister.Text = "Kembali Ke Register";
            btnBRegister.UseVisualStyleBackColor = true;
            btnBRegister.Click += btnBack_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(18, 162);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(85, 33);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 276);
            Controls.Add(btnBRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblTitle);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblTitle;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnBRegister;
        private Button btnLogin;
    }
}
