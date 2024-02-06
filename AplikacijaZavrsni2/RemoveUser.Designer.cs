namespace AplikacijaZavrsni2.Data
{
    partial class RemoveUser
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
            button1 = new Button();
            txtBrisanjeKorisnikaDelete = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(562, 252);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(161, 51);
            button1.TabIndex = 0;
            button1.Text = "Obrisi korisnika";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtBrisanjeKorisnikaDelete
            // 
            txtBrisanjeKorisnikaDelete.Location = new Point(373, 264);
            txtBrisanjeKorisnikaDelete.Margin = new Padding(3, 4, 3, 4);
            txtBrisanjeKorisnikaDelete.Name = "txtBrisanjeKorisnikaDelete";
            txtBrisanjeKorisnikaDelete.Size = new Size(148, 27);
            txtBrisanjeKorisnikaDelete.TabIndex = 1;
            txtBrisanjeKorisnikaDelete.TextChanged += txtBrisanjeKorisnikaDelete_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(292, 267);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 2;
            label1.Text = "OIB:";
            // 
            // RemoveUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(txtBrisanjeKorisnikaDelete);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RemoveUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brisanje Korisnika";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtBrisanjeKorisnikaDelete;
        private Label label1;
    }
}