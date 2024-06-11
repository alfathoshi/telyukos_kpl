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
            KapasitasLabel = new Label();
            AlamatLabel = new Label();
            HargaLabel = new Label();
            NamaLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            BatalSewaButton = new Button();
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
            panel1.Controls.Add(KapasitasLabel);
            panel1.Controls.Add(AlamatLabel);
            panel1.Controls.Add(HargaLabel);
            panel1.Controls.Add(NamaLabel);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(569, 325);
            panel1.TabIndex = 3;
            // 
            // KapasitasLabel
            // 
            KapasitasLabel.AutoSize = true;
            KapasitasLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KapasitasLabel.Location = new Point(153, 236);
            KapasitasLabel.Name = "KapasitasLabel";
            KapasitasLabel.Size = new Size(112, 32);
            KapasitasLabel.TabIndex = 7;
            KapasitasLabel.Text = "Kapasitas";
            // 
            // AlamatLabel
            // 
            AlamatLabel.AutoSize = true;
            AlamatLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlamatLabel.Location = new Point(153, 173);
            AlamatLabel.Name = "AlamatLabel";
            AlamatLabel.Size = new Size(88, 32);
            AlamatLabel.TabIndex = 6;
            AlamatLabel.Text = "Alamat";
            // 
            // HargaLabel
            // 
            HargaLabel.AutoSize = true;
            HargaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaLabel.Location = new Point(153, 109);
            HargaLabel.Name = "HargaLabel";
            HargaLabel.Size = new Size(77, 32);
            HargaLabel.TabIndex = 5;
            HargaLabel.Text = "Harga";
            // 
            // NamaLabel
            // 
            NamaLabel.AutoSize = true;
            NamaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaLabel.Location = new Point(153, 46);
            NamaLabel.Name = "NamaLabel";
            NamaLabel.Size = new Size(77, 32);
            NamaLabel.TabIndex = 4;
            NamaLabel.Text = "Nama";
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
            // BatalSewaButton
            // 
            BatalSewaButton.BackColor = Color.Firebrick;
            BatalSewaButton.ForeColor = Color.White;
            BatalSewaButton.Location = new Point(632, 292);
            BatalSewaButton.Name = "BatalSewaButton";
            BatalSewaButton.Size = new Size(133, 48);
            BatalSewaButton.TabIndex = 4;
            BatalSewaButton.Text = "Batal Sewa";
            BatalSewaButton.UseVisualStyleBackColor = false;
            BatalSewaButton.Click += BatalSewaButton_Click;
            // 
            // MyKosPenyewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(BatalSewaButton);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "MyKosPenyewa";
            Text = "Form1";
            Load += MyKosPenyewa_Load;
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
        private Label NamaLabel;
        private Label KapasitasLabel;
        private Label AlamatLabel;
        private Label HargaLabel;
        private Button BatalSewaButton;
    }
}