namespace AplikacijaZavrsni2.Data
{
    partial class AdminScreen
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
            btnAdminScreenAddUser = new Button();
            btnAdminScreenRemoveUser = new Button();
            btnAdminScreenUserOverview = new Button();
            SuspendLayout();
            // 
            // btnAdminScreenAddUser
            // 
            btnAdminScreenAddUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminScreenAddUser.Location = new Point(205, 93);
            btnAdminScreenAddUser.Margin = new Padding(3, 4, 3, 4);
            btnAdminScreenAddUser.Name = "btnAdminScreenAddUser";
            btnAdminScreenAddUser.Size = new Size(159, 80);
            btnAdminScreenAddUser.TabIndex = 0;
            btnAdminScreenAddUser.Text = "Dodavanje korinsika";
            btnAdminScreenAddUser.UseVisualStyleBackColor = true;
            btnAdminScreenAddUser.Click += btnAdminScreenAddUser_Click;
            // 
            // btnAdminScreenRemoveUser
            // 
            btnAdminScreenRemoveUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminScreenRemoveUser.Location = new Point(205, 263);
            btnAdminScreenRemoveUser.Margin = new Padding(3, 4, 3, 4);
            btnAdminScreenRemoveUser.Name = "btnAdminScreenRemoveUser";
            btnAdminScreenRemoveUser.Size = new Size(159, 80);
            btnAdminScreenRemoveUser.TabIndex = 1;
            btnAdminScreenRemoveUser.Text = "Brisanje korisnika";
            btnAdminScreenRemoveUser.UseVisualStyleBackColor = true;
            btnAdminScreenRemoveUser.Click += button2_Click;
            // 
            // btnAdminScreenUserOverview
            // 
            btnAdminScreenUserOverview.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdminScreenUserOverview.Location = new Point(205, 432);
            btnAdminScreenUserOverview.Margin = new Padding(3, 4, 3, 4);
            btnAdminScreenUserOverview.Name = "btnAdminScreenUserOverview";
            btnAdminScreenUserOverview.Size = new Size(159, 80);
            btnAdminScreenUserOverview.TabIndex = 2;
            btnAdminScreenUserOverview.Text = "Pregled korisnika";
            btnAdminScreenUserOverview.UseVisualStyleBackColor = true;
            btnAdminScreenUserOverview.Click += btnAdminScreenUserOverview_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(554, 600);
            Controls.Add(btnAdminScreenUserOverview);
            Controls.Add(btnAdminScreenRemoveUser);
            Controls.Add(btnAdminScreenAddUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdminScreenAddUser;
        private Button btnAdminScreenRemoveUser;
        private Button btnAdminScreenUserOverview;
    }
}