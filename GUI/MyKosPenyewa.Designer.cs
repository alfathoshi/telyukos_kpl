namespace GUI
{
    partial class MyKosPenyewa
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
            label1 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 48);
            label1.TabIndex = 0;
            label1.Text = "My Kos";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = Color.White;
            button1.Location = new Point(632, 349);
            button1.Name = "button1";
            button1.Size = new Size(133, 48);
            button1.TabIndex = 2;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(242, 239, 234);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 325);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(21, 46);
            label2.Name = "label2";
            label2.Size = new Size(126, 32);
            label2.TabIndex = 0;
            label2.Text = "Nama Kos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 109);
            label3.Name = "label3";
            label3.Size = new Size(82, 32);
            label3.TabIndex = 1;
            label3.Text = "Harga:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 173);
            label4.Name = "label4";
            label4.Size = new Size(93, 32);
            label4.TabIndex = 2;
            label4.Text = "Alamat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 236);
            label5.Name = "label5";
            label5.Size = new Size(117, 32);
            label5.TabIndex = 3;
            label5.Text = "Kapasitas:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(153, 46);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 4;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(153, 109);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 5;
            label7.Text = "label7";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(153, 173);
            label8.Name = "label8";
            label8.Size = new Size(78, 32);
            label8.TabIndex = 6;
            label8.Text = "label8";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(153, 236);
            label9.Name = "label9";
            label9.Size = new Size(78, 32);
            label9.TabIndex = 7;
            label9.Text = "label9";
            // 
            // MyKosPenyewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MyKosPenyewa";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label9;
        private Label label8;
        private Label label7;
    }
}