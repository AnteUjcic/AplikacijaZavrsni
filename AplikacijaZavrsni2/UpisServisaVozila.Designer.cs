namespace AplikacijaZavrsni2
{
    partial class UpisServisaVozila
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
            txtUpisServisaServiceType = new TextBox();
            txtUpisServisaKMService = new TextBox();
            txtUpisServisaNextKMService = new TextBox();
            btnUpisServisa = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUpisServisaVozilaUpisServisa = new TextBox();
            txtUpisServisaVozilaVINvozila = new TextBox();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker1 = new DateTimePicker();
            SuspendLayout();
            // 
            // txtUpisServisaServiceType
            // 
            txtUpisServisaServiceType.Location = new Point(279, 126);
            txtUpisServisaServiceType.Margin = new Padding(3, 4, 3, 4);
            txtUpisServisaServiceType.Name = "txtUpisServisaServiceType";
            txtUpisServisaServiceType.PlaceholderText = "Mali servis, veliki servis";
            txtUpisServisaServiceType.Size = new Size(242, 27);
            txtUpisServisaServiceType.TabIndex = 0;
            txtUpisServisaServiceType.TextChanged += textBox1_TextChanged;
            // 
            // txtUpisServisaKMService
            // 
            txtUpisServisaKMService.Location = new Point(279, 268);
            txtUpisServisaKMService.Margin = new Padding(3, 4, 3, 4);
            txtUpisServisaKMService.Name = "txtUpisServisaKMService";
            txtUpisServisaKMService.PlaceholderText = "223098";
            txtUpisServisaKMService.Size = new Size(242, 27);
            txtUpisServisaKMService.TabIndex = 2;
            txtUpisServisaKMService.TextChanged += textBox3_TextChanged;
            // 
            // txtUpisServisaNextKMService
            // 
            txtUpisServisaNextKMService.Location = new Point(279, 340);
            txtUpisServisaNextKMService.Margin = new Padding(3, 4, 3, 4);
            txtUpisServisaNextKMService.Name = "txtUpisServisaNextKMService";
            txtUpisServisaNextKMService.PlaceholderText = "238098";
            txtUpisServisaNextKMService.Size = new Size(242, 27);
            txtUpisServisaNextKMService.TabIndex = 3;
            txtUpisServisaNextKMService.TextChanged += textBox4_TextChanged;
            // 
            // btnUpisServisa
            // 
            btnUpisServisa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpisServisa.Location = new Point(633, 442);
            btnUpisServisa.Margin = new Padding(3, 4, 3, 4);
            btnUpisServisa.Name = "btnUpisServisa";
            btnUpisServisa.Size = new Size(173, 62);
            btnUpisServisa.TabIndex = 4;
            btnUpisServisa.Text = "Upis servisa";
            btnUpisServisa.UseVisualStyleBackColor = true;
            btnUpisServisa.Click += btnUpisServisa_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(123, 129);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 5;
            label1.Text = "Tip servisa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(123, 196);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 6;
            label2.Text = "Datum servisa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(123, 271);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 7;
            label3.Text = "Trenutni broj Km:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(123, 343);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 8;
            label4.Text = "Sljedeci servis (Km):";
            // 
            // txtUpisServisaVozilaUpisServisa
            // 
            txtUpisServisaVozilaUpisServisa.Location = new Point(279, 410);
            txtUpisServisaVozilaUpisServisa.Margin = new Padding(3, 4, 3, 4);
            txtUpisServisaVozilaUpisServisa.Name = "txtUpisServisaVozilaUpisServisa";
            txtUpisServisaVozilaUpisServisa.PlaceholderText = "OIB servisera";
            txtUpisServisaVozilaUpisServisa.Size = new Size(242, 27);
            txtUpisServisaVozilaUpisServisa.TabIndex = 9;
            txtUpisServisaVozilaUpisServisa.TextChanged += txtUpisServisaVozilaUpisServisa_TextChanged;
            // 
            // txtUpisServisaVozilaVINvozila
            // 
            txtUpisServisaVozilaVINvozila.Location = new Point(279, 477);
            txtUpisServisaVozilaVINvozila.Margin = new Padding(3, 4, 3, 4);
            txtUpisServisaVozilaVINvozila.Name = "txtUpisServisaVozilaVINvozila";
            txtUpisServisaVozilaVINvozila.PlaceholderText = "876590653";
            txtUpisServisaVozilaVINvozila.Size = new Size(242, 27);
            txtUpisServisaVozilaVINvozila.TabIndex = 10;
            txtUpisServisaVozilaVINvozila.TextChanged += txtUpisServisaVozilaVINvozila_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(123, 413);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 11;
            label5.Text = "Upis servisera:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(123, 480);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 12;
            label6.Text = "Broj šasije:";
            label6.Click += label6_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(279, 191);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // UpisServisaVozila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 600);
            Controls.Add(dateTimePicker1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtUpisServisaVozilaVINvozila);
            Controls.Add(txtUpisServisaVozilaUpisServisa);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnUpisServisa);
            Controls.Add(txtUpisServisaNextKMService);
            Controls.Add(txtUpisServisaKMService);
            Controls.Add(txtUpisServisaServiceType);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpisServisaVozila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upis Servisa Vozila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUpisServisaServiceType;
        private TextBox txtUpisServisaKMService;
        private TextBox txtUpisServisaNextKMService;
        private Button btnUpisServisa;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUpisServisaVozilaUpisServisa;
        private TextBox txtUpisServisaVozilaVINvozila;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
    }
}