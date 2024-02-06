namespace AplikacijaZavrsni2
{
    partial class PregledServisa
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
            dataGridView1 = new DataGridView();
            btnPregledServisaPregled = new Button();
            txtPregledServisaUpisVIN = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 85);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1057, 499);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnPregledServisaPregled
            // 
            btnPregledServisaPregled.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPregledServisaPregled.Location = new Point(1089, 85);
            btnPregledServisaPregled.Margin = new Padding(3, 4, 3, 4);
            btnPregledServisaPregled.Name = "btnPregledServisaPregled";
            btnPregledServisaPregled.Size = new Size(99, 52);
            btnPregledServisaPregled.TabIndex = 1;
            btnPregledServisaPregled.Text = "Pregled";
            btnPregledServisaPregled.UseVisualStyleBackColor = true;
            btnPregledServisaPregled.Click += btnPregledServisaPregled_Click;
            // 
            // txtPregledServisaUpisVIN
            // 
            txtPregledServisaUpisVIN.Location = new Point(119, 47);
            txtPregledServisaUpisVIN.Margin = new Padding(3, 4, 3, 4);
            txtPregledServisaUpisVIN.Name = "txtPregledServisaUpisVIN";
            txtPregledServisaUpisVIN.PlaceholderText = "254698762";
            txtPregledServisaUpisVIN.Size = new Size(182, 27);
            txtPregledServisaUpisVIN.TabIndex = 2;
            txtPregledServisaUpisVIN.TextChanged += txtPregledServisaUpisVIN_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(818, 51);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 50);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "Broj šasije:";
            // 
            // PregledServisa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(1200, 600);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPregledServisaUpisVIN);
            Controls.Add(btnPregledServisaPregled);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PregledServisa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled Servisa";
            Load += PregledServisa_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnPregledServisaPregled;
        private TextBox txtPregledServisaUpisVIN;
        private Label label1;
        private Label label2;
    }
}