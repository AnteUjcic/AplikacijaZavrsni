namespace AplikacijaZavrsni2
{
    partial class PocetnaForma
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
            btnPocetnaFormaUpisNovogVozila = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnPocetnaFormaPregledServisa = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnPocetnaFormaUpisNovogVozila
            // 
            btnPocetnaFormaUpisNovogVozila.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPocetnaFormaUpisNovogVozila.Location = new Point(150, 281);
            btnPocetnaFormaUpisNovogVozila.Margin = new Padding(3, 4, 3, 4);
            btnPocetnaFormaUpisNovogVozila.Name = "btnPocetnaFormaUpisNovogVozila";
            btnPocetnaFormaUpisNovogVozila.Size = new Size(187, 31);
            btnPocetnaFormaUpisNovogVozila.TabIndex = 0;
            btnPocetnaFormaUpisNovogVozila.Text = "Upis novog vozila";
            btnPocetnaFormaUpisNovogVozila.UseVisualStyleBackColor = true;
            btnPocetnaFormaUpisNovogVozila.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(150, 337);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(187, 31);
            button2.TabIndex = 1;
            button2.Text = "Brisanje vozila";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(150, 397);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(187, 31);
            button3.TabIndex = 2;
            button3.Text = "Upis servisa vozila";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(150, 453);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(187, 31);
            button4.TabIndex = 3;
            button4.Text = "Pregled vozila";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btnPocetnaFormaPregledServisa
            // 
            btnPocetnaFormaPregledServisa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPocetnaFormaPregledServisa.Location = new Point(150, 512);
            btnPocetnaFormaPregledServisa.Margin = new Padding(3, 4, 3, 4);
            btnPocetnaFormaPregledServisa.Name = "btnPocetnaFormaPregledServisa";
            btnPocetnaFormaPregledServisa.Size = new Size(187, 31);
            btnPocetnaFormaPregledServisa.TabIndex = 4;
            btnPocetnaFormaPregledServisa.Text = "Pregled servisa";
            btnPocetnaFormaPregledServisa.UseVisualStyleBackColor = true;
            btnPocetnaFormaPregledServisa.Click += btnPocetnaFormaPregledServisa_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_mali;
            pictureBox1.Location = new Point(134, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 190);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // PocetnaForma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(485, 600);
            Controls.Add(pictureBox1);
            Controls.Add(btnPocetnaFormaPregledServisa);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnPocetnaFormaUpisNovogVozila);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PocetnaForma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servisi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPocetnaFormaUpisNovogVozila;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnPocetnaFormaPregledServisa;
        private PictureBox pictureBox1;
    }
}