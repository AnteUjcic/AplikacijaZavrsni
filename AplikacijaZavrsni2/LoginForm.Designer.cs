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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLoginLogin
            // 
            btnLoginLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginLogin.Location = new Point(619, 322);
            btnLoginLogin.Name = "btnLoginLogin";
            btnLoginLogin.Size = new Size(75, 23);
            btnLoginLogin.TabIndex = 0;
            btnLoginLogin.Text = "Prijava";
            btnLoginLogin.UseVisualStyleBackColor = true;
            btnLoginLogin.Click += btnLoginLogin_Click;
            // 
            // txtLoginUsername
            // 
            txtLoginUsername.Location = new Point(535, 159);
            txtLoginUsername.Name = "txtLoginUsername";
            txtLoginUsername.Size = new Size(171, 23);
            txtLoginUsername.TabIndex = 1;
            txtLoginUsername.TextChanged += txtLoginUsername_TextChanged;
            // 
            // txtLoginPassword
            // 
            txtLoginPassword.Location = new Point(535, 244);
            txtLoginPassword.Name = "txtLoginPassword";
            txtLoginPassword.PasswordChar = '*';
            txtLoginPassword.Size = new Size(171, 23);
            txtLoginPassword.TabIndex = 2;
            txtLoginPassword.TextChanged += txtLoginPassword_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_servis2;
            pictureBox1.Location = new Point(29, 33);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(535, 137);
            label1.Name = "label1";
            label1.Size = new Size(112, 19);
            label1.TabIndex = 4;
            label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(535, 222);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 5;
            label2.Text = "Lozinka:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(txtLoginPassword);
            Controls.Add(txtLoginUsername);
            Controls.Add(btnLoginLogin);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servisi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoginLogin;
        private TextBox txtLoginUsername;
        private TextBox txtLoginPassword;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
    }
}