namespace AplikacijaZavrsni2
{
    partial class LoginForm
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
            btnLoginLogin = new Button();
            txtLoginUsername = new TextBox();
            txtLoginPassword = new TextBox();
            SuspendLayout();
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Location = new Point(619, 326);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(75, 23);
            btnLoginLogin.TabIndex = 0;
            btnLoginLogin.Text = "button1";
            btnLoginLogin.UseVisualStyleBackColor = true;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(594, 159);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(100, 23);
            txtLoginUsername.TabIndex = 1;
            txtLoginUsername.TextChanged += txtLoginUsername_TextChanged;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(594, 224);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.Size = new Size(100, 23);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.TextChanged += txtLoginPassword_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Controls.Add(btnLoginLogin);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginLogin;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
    }
}