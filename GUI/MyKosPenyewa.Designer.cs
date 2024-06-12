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
            label1.Location = new Point(14, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 57);
            label1.TabIndex = 0;
            label1.Text = "My Kos";
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1138, 838);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(160, 58);
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
            panel1.Location = new Point(26, 86);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1048, 810);
            panel1.TabIndex = 3;
            // 
            // KapasitasLabel
            // 
            KapasitasLabel.AutoSize = true;
            KapasitasLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            KapasitasLabel.Location = new Point(184, 530);
            KapasitasLabel.Margin = new Padding(4, 0, 4, 0);
            KapasitasLabel.Name = "KapasitasLabel";
            KapasitasLabel.Size = new Size(131, 38);
            KapasitasLabel.TabIndex = 7;
            KapasitasLabel.Text = "Kapasitas";
            KapasitasLabel.Click += KapasitasLabel_Click;
            // 
            // AlamatLabel
            // 
            AlamatLabel.AutoSize = true;
            AlamatLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AlamatLabel.Location = new Point(184, 363);
            AlamatLabel.Margin = new Padding(4, 0, 4, 0);
            AlamatLabel.Name = "AlamatLabel";
            AlamatLabel.Size = new Size(103, 38);
            AlamatLabel.TabIndex = 6;
            AlamatLabel.Text = "Alamat";
            // 
            // HargaLabel
            // 
            HargaLabel.AutoSize = true;
            HargaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HargaLabel.Location = new Point(184, 208);
            HargaLabel.Margin = new Padding(4, 0, 4, 0);
            HargaLabel.Name = "HargaLabel";
            HargaLabel.Size = new Size(91, 38);
            HargaLabel.TabIndex = 5;
            HargaLabel.Text = "Harga";
            // 
            // NamaLabel
            // 
            NamaLabel.AutoSize = true;
            NamaLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NamaLabel.Location = new Point(184, 55);
            NamaLabel.Margin = new Padding(4, 0, 4, 0);
            NamaLabel.Name = "NamaLabel";
            NamaLabel.Size = new Size(90, 38);
            NamaLabel.TabIndex = 4;
            NamaLabel.Text = "Nama";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(25, 530);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(137, 38);
            label5.TabIndex = 3;
            label5.Text = "Kapasitas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(25, 363);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(109, 38);
            label4.TabIndex = 2;
            label4.Text = "Alamat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(25, 208);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(97, 38);
            label3.TabIndex = 1;
            label3.Text = "Harga:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(25, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 38);
            label2.TabIndex = 0;
            label2.Text = "Nama Kos:";
            // 
            // BatalSewaButton
            // 
            BatalSewaButton.BackColor = Color.Firebrick;
            BatalSewaButton.ForeColor = Color.White;
            BatalSewaButton.Location = new Point(1138, 769);
            BatalSewaButton.Margin = new Padding(4);
            BatalSewaButton.Name = "BatalSewaButton";
            BatalSewaButton.Size = new Size(160, 58);
            BatalSewaButton.TabIndex = 4;
            BatalSewaButton.Text = "Batal Sewa";
            BatalSewaButton.UseVisualStyleBackColor = false;
            BatalSewaButton.Click += BatalSewaButton_Click;
            // 
            // MyKosPenyewa
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1395, 964);
            Controls.Add(BatalSewaButton);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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