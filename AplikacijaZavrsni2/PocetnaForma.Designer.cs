﻿namespace AplikacijaZavrsni2
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(85, 88);
            button1.Name = "button1";
            button1.Size = new Size(118, 23);
            button1.TabIndex = 0;
            button1.Text = "Upis novog vozila";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(85, 142);
            button2.Name = "button2";
            button2.Size = new Size(118, 23);
            button2.TabIndex = 1;
            button2.Text = "Brisanje vozila";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(85, 206);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 2;
            button3.Text = "Upis servisa vozila";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(85, 256);
            button4.Name = "button4";
            button4.Size = new Size(118, 23);
            button4.TabIndex = 3;
            button4.Text = "Pregled vozila";
            button4.UseVisualStyleBackColor = true;
            // 
            // PocetnaForma
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "PocetnaForma";
            Text = "PocetnaForma";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}