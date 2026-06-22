namespace TubesKPL2
{
    partial class Register
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
            label1 = new Label();
            txtUsername = new TextBox();
            lblUser = new Label();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtConfirmPassword = new TextBox();
            btnRegister = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(131, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "REGISTER GOODBITE";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(174, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(12, 73);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(90, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Username   :";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 122);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(61, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email   :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(174, 122);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 27);
            txtEmail.TabIndex = 3;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(12, 172);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 20);
            lblPassword.TabIndex = 6;
            lblPassword.Text = "Password   :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(174, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 5;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(12, 225);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(142, 20);
            lblConfirmPassword.TabIndex = 8;
            lblConfirmPassword.Text = "Confirm Password   :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(174, 222);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(216, 27);
            txtConfirmPassword.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(12, 287);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(85, 33);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 337);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(142, 33);
            btnBack.TabIndex = 10;
            btnBack.Text = "Kembali Ke Login";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 391);
            Controls.Add(btnBack);
            Controls.Add(btnRegister);
            Controls.Add(lblConfirmPassword);
            Controls.Add(txtConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Controls.Add(lblUser);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private Label lblUser;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmPassword;
        private TextBox txtConfirmPassword;
        private Button btnRegister;
        private Button btnBack;
    }
}