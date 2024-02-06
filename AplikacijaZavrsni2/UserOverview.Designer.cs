namespace AplikacijaZavrsni2.Data
{
    partial class UserOverview
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
            btnUserOverviewShow = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(185, 154);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(430, 289);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnUserOverviewShow
            // 
            btnUserOverviewShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUserOverviewShow.Location = new Point(674, 154);
            btnUserOverviewShow.Margin = new Padding(3, 4, 3, 4);
            btnUserOverviewShow.Name = "btnUserOverviewShow";
            btnUserOverviewShow.Size = new Size(117, 61);
            btnUserOverviewShow.TabIndex = 1;
            btnUserOverviewShow.Text = "Prikaz";
            btnUserOverviewShow.UseVisualStyleBackColor = true;
            btnUserOverviewShow.Click += btnUserOverviewShow_Click;
            // 
            // UserOverview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Maroon;
            ClientSize = new Size(914, 600);
            Controls.Add(btnUserOverviewShow);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserOverview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pregled Korisnika";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUserOverviewShow;
    }
}