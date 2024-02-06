namespace AplikacijaZavrsni2
{
    partial class UpisNovogVozila
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
            btnAddCar = new Button();
            txtIDVehicle = new TextBox();
            txtBrand = new TextBox();
            txtNumberOfWheels = new TextBox();
            txtYear = new TextBox();
            txtNumberOfDoors = new TextBox();
            txtEngineType = new TextBox();
            txtDriveType = new TextBox();
            txtBodyStyle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // btnAddCar
            // 
            btnAddCar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddCar.Location = new Point(369, 424);
            btnAddCar.Margin = new Padding(3, 4, 3, 4);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(173, 66);
            btnAddCar.TabIndex = 0;
            btnAddCar.Text = "Dodaj auto";
            btnAddCar.UseVisualStyleBackColor = true;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // txtIDVehicle
            // 
            txtIDVehicle.Location = new Point(218, 106);
            txtIDVehicle.Margin = new Padding(3, 4, 3, 4);
            txtIDVehicle.Name = "txtIDVehicle";
            txtIDVehicle.PlaceholderText = "778944787";
            txtIDVehicle.Size = new Size(146, 27);
            txtIDVehicle.TabIndex = 1;
            txtIDVehicle.TextChanged += txtIDVehicle_TextChanged;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(218, 174);
            txtBrand.Margin = new Padding(3, 4, 3, 4);
            txtBrand.Name = "txtBrand";
            txtBrand.PlaceholderText = "BMW";
            txtBrand.Size = new Size(146, 27);
            txtBrand.TabIndex = 2;
            txtBrand.TextChanged += txtBrand_TextChanged;
            // 
            // txtNumberOfWheels
            // 
            txtNumberOfWheels.Location = new Point(218, 310);
            txtNumberOfWheels.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfWheels.Name = "txtNumberOfWheels";
            txtNumberOfWheels.PlaceholderText = "4";
            txtNumberOfWheels.Size = new Size(146, 27);
            txtNumberOfWheels.TabIndex = 4;
            txtNumberOfWheels.TextChanged += txtNumberOfWheels_TextChanged;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(218, 241);
            txtYear.Margin = new Padding(3, 4, 3, 4);
            txtYear.Name = "txtYear";
            txtYear.PlaceholderText = "2009";
            txtYear.Size = new Size(146, 27);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += txtYear_TextChanged;
            // 
            // txtNumberOfDoors
            // 
            txtNumberOfDoors.Location = new Point(596, 174);
            txtNumberOfDoors.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfDoors.Name = "txtNumberOfDoors";
            txtNumberOfDoors.PlaceholderText = "5";
            txtNumberOfDoors.Size = new Size(146, 27);
            txtNumberOfDoors.TabIndex = 6;
            txtNumberOfDoors.TextChanged += txtNumberOfDoors_TextChanged;
            // 
            // txtEngineType
            // 
            txtEngineType.Location = new Point(596, 106);
            txtEngineType.Margin = new Padding(3, 4, 3, 4);
            txtEngineType.Name = "txtEngineType";
            txtEngineType.PlaceholderText = "Dizel motor";
            txtEngineType.Size = new Size(146, 27);
            txtEngineType.TabIndex = 5;
            txtEngineType.TextChanged += txtEngineType_TextChanged;
            // 
            // txtDriveType
            // 
            txtDriveType.Location = new Point(596, 310);
            txtDriveType.Margin = new Padding(3, 4, 3, 4);
            txtDriveType.Name = "txtDriveType";
            txtDriveType.PlaceholderText = "4x4 pogon";
            txtDriveType.Size = new Size(146, 27);
            txtDriveType.TabIndex = 8;
            txtDriveType.TextChanged += txtDriveType_TextChanged;
            // 
            // txtBodyStyle
            // 
            txtBodyStyle.Location = new Point(596, 241);
            txtBodyStyle.Margin = new Padding(3, 4, 3, 4);
            txtBodyStyle.Name = "txtBodyStyle";
            txtBodyStyle.PlaceholderText = "Karavan";
            txtBodyStyle.Size = new Size(146, 27);
            txtBodyStyle.TabIndex = 7;
            txtBodyStyle.TextChanged += txtBodyStyle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(125, 109);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 9;
            label1.Text = "Broj šasije:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 177);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "Marka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(125, 244);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 11;
            label3.Text = "Godina:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(125, 313);
            label4.Name = "label4";
            label4.Size = new Size(92, 20);
            label4.TabIndex = 12;
            label4.Text = "Broj kotaca:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(488, 109);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 13;
            label5.Text = "Tip motora:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(488, 244);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 14;
            label6.Text = "Tip karoserije:";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(488, 177);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 15;
            label7.Text = "Broj vrata:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(488, 313);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 16;
            label8.Text = "Vrsta pogona";
            // 
            // UpisNovogVozila
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 600);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDriveType);
            Controls.Add(txtBodyStyle);
            Controls.Add(txtNumberOfDoors);
            Controls.Add(txtEngineType);
            Controls.Add(txtNumberOfWheels);
            Controls.Add(txtYear);
            Controls.Add(txtBrand);
            Controls.Add(txtIDVehicle);
            Controls.Add(btnAddCar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UpisNovogVozila";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Upis Novog Automobila";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddCar;
        private TextBox txtIDVehicle;
        private TextBox txtBrand;
        private TextBox txtNumberOfWheels;
        private TextBox txtYear;
        private TextBox txtNumberOfDoors;
        private TextBox txtEngineType;
        private TextBox txtDriveType;
        private TextBox txtBodyStyle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}