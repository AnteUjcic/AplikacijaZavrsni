namespace AplikacijaZavrsni2
{
    partial class BrisanjeVozila
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
            txtBrisanjeVozilaBrisi = new TextBox();
            btnDeleteCar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtBrisanjeVozilaBrisi
            // 
            txtBrisanjeVozilaBrisi.Location = new Point(259, 311);
            txtBrisanjeVozilaBrisi.Margin = new Padding(3, 4, 3, 4);
            txtBrisanjeVozilaBrisi.Name = "txtBrisanjeVozilaBrisi";
            txtBrisanjeVozilaBrisi.PlaceholderText = "546907709";
            txtBrisanjeVozilaBrisi.Size = new Size(173, 27);
            txtBrisanjeVozilaBrisi.TabIndex = 0;
            txtBrisanjeVozilaBrisi.TextChanged += txtBrisanjeVozilaBrisi_TextChanged;
            // 
            // btnDeleteCar
            // 
            btnDeleteCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteCar.Location = new Point(460, 287);
            btnDeleteCar.Margin = new Padding(3, 4, 3, 4);
            btnDeleteCar.Name = "btnDeleteCar";
            btnDeleteCar.Size = new Size(193, 75);
            btnDeleteCar.TabIndex = 1;
            btnDeleteCar.Text = "Brisi auto";
            btnDeleteCar.UseVisualStyleBackColor = true;
            btnDeleteCar.Click += btnDeleteCar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 287);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 2;
            label1.Text = "Broj šasije:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_mali;
            pictureBox1.Location = new Point(358, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // BrisanjeVozila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(btnDeleteCar);
            Controls.Add(txtBrisanjeVozilaBrisi);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BrisanjeVozila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Brisanje Vozila";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBrisanjeVozilaBrisi;
        private Button btnDeleteCar;
        private Label label1;
        private PictureBox pictureBox1;
    }
}