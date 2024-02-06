namespace AplikacijaZavrsni2.Data
{
    partial class AddUser
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
            txtAddUserName = new TextBox();
            txtAddUserSurename = new TextBox();
            txtAddUserOIB = new TextBox();
            txtAddUserUsername = new TextBox();
            txtAddUserPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnAddUserAddUser = new Button();
            SuspendLayout();
            // 
            // txtAddUserName
            // 
            txtAddUserName.Location = new Point(188, 90);
            txtAddUserName.Name = "txtAddUserName";
            txtAddUserName.Size = new Size(123, 23);
            txtAddUserName.TabIndex = 0;
            txtAddUserName.TextChanged += txtAddUserName_TextChanged;
            // 
            // txtAddUserSurename
            // 
            txtAddUserSurename.Location = new Point(186, 168);
            txtAddUserSurename.Name = "txtAddUserSurename";
            txtAddUserSurename.Size = new Size(123, 23);
            txtAddUserSurename.TabIndex = 1;
            txtAddUserSurename.TextChanged += txtAddUserSurename_TextChanged;
            // 
            // txtAddUserOIB
            // 
            txtAddUserOIB.Location = new Point(186, 241);
            txtAddUserOIB.Name = "txtAddUserOIB";
            txtAddUserOIB.Size = new Size(123, 23);
            txtAddUserOIB.TabIndex = 2;
            txtAddUserOIB.TextChanged += txtAddUserOIB_TextChanged;
            // 
            // txtAddUserUsername
            // 
            txtAddUserUsername.Location = new Point(480, 90);
            txtAddUserUsername.Name = "txtAddUserUsername";
            txtAddUserUsername.Size = new Size(123, 23);
            txtAddUserUsername.TabIndex = 3;
            txtAddUserUsername.TextChanged += txtAddUserUsername_TextChanged;
            // 
            // txtAddUserPassword
            // 
            txtAddUserPassword.Location = new Point(480, 169);
            txtAddUserPassword.Name = "txtAddUserPassword";
            txtAddUserPassword.Size = new Size(123, 23);
            txtAddUserPassword.TabIndex = 4;
            txtAddUserPassword.TextChanged += txtAddUserPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(373, 92);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 5;
            label1.Text = "Korisnicko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(428, 171);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 6;
            label2.Text = "Sifra:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(139, 92);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 7;
            label3.Text = "Ime:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(121, 170);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 8;
            label4.Text = "Prezime:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(139, 243);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 9;
            label5.Text = "OIB:";
            // 
            // btnAddUserAddUser
            // 
            btnAddUserAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddUserAddUser.Location = new Point(480, 232);
            btnAddUserAddUser.Name = "btnAddUserAddUser";
            btnAddUserAddUser.Size = new Size(122, 38);
            btnAddUserAddUser.TabIndex = 10;
            btnAddUserAddUser.Text = "Dodaj";
            btnAddUserAddUser.UseVisualStyleBackColor = true;
            btnAddUserAddUser.Click += btnAddUserAddUser_Click;
            // 
            // AddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddUserAddUser);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtAddUserPassword);
            Controls.Add(txtAddUserUsername);
            Controls.Add(txtAddUserOIB);
            Controls.Add(txtAddUserSurename);
            Controls.Add(txtAddUserName);
            Name = "AddUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodavanje korisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAddUserName;
        private TextBox txtAddUserSurename;
        private TextBox txtAddUserOIB;
        private TextBox txtAddUserUsername;
        private TextBox txtAddUserPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnAddUserAddUser;
    }
}