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
            btnAdminScreenAddUser.Location = new Point(281, 93);
            btnAdminScreenAddUser.Name = "btnAdminScreenAddUser";
            btnAdminScreenAddUser.Size = new Size(115, 23);
            btnAdminScreenAddUser.TabIndex = 0;
            btnAdminScreenAddUser.Text = "Dodavanje novog korinsika";
            btnAdminScreenAddUser.UseVisualStyleBackColor = true;
            btnAdminScreenAddUser.Click += btnAdminScreenAddUser_Click;
            // 
            // btnAdminScreenRemoveUser
            // 
            btnAdminScreenRemoveUser.Location = new Point(279, 146);
            btnAdminScreenRemoveUser.Name = "btnAdminScreenRemoveUser";
            btnAdminScreenRemoveUser.Size = new Size(117, 23);
            btnAdminScreenRemoveUser.TabIndex = 1;
            btnAdminScreenRemoveUser.Text = "Brisanje korisnika";
            btnAdminScreenRemoveUser.UseVisualStyleBackColor = true;
            btnAdminScreenRemoveUser.Click += button2_Click;
            // 
            // btnAdminScreenUserOverview
            // 
            btnAdminScreenUserOverview.Location = new Point(281, 201);
            btnAdminScreenUserOverview.Name = "btnAdminScreenUserOverview";
            btnAdminScreenUserOverview.Size = new Size(115, 23);
            btnAdminScreenUserOverview.TabIndex = 2;
            btnAdminScreenUserOverview.Text = "Pregled korisnika";
            btnAdminScreenUserOverview.UseVisualStyleBackColor = true;
            btnAdminScreenUserOverview.Click += btnAdminScreenUserOverview_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdminScreenUserOverview);
            Controls.Add(btnAdminScreenRemoveUser);
            Controls.Add(btnAdminScreenAddUser);
            Name = "AdminScreen";
            Text = "AdminScreen";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdminScreenAddUser;
        private Button btnAdminScreenRemoveUser;
        private Button btnAdminScreenUserOverview;
    }
}