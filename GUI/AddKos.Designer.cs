namespace GUI
{
    partial class AddKos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NamaKosBox = new TextBox();
            HargaBox = new TextBox();
            AlamatBox = new TextBox();
            KapasitasBox = new TextBox();
            TambahButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(462, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 51);
            label1.TabIndex = 0;
            label1.Text = "Tambah Kos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 236);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(112, 30);
            label2.TabIndex = 1;
            label2.Text = "Nama Kos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 342);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 30);
            label3.TabIndex = 2;
            label3.Text = "Harga:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 440);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(84, 30);
            label4.TabIndex = 3;
            label4.Text = "Alamat:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(188, 538);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 30);
            label5.TabIndex = 4;
            label5.Text = "Kapasitas:";
            // 
            // NamaKosBox
            // 
            NamaKosBox.Location = new Point(416, 225);
            NamaKosBox.Margin = new Padding(4, 4, 4, 4);
            NamaKosBox.Name = "NamaKosBox";
            NamaKosBox.Size = new Size(394, 35);
            NamaKosBox.TabIndex = 5;
            NamaKosBox.TextChanged += NamaKosBox_TextChanged;
            // 
            // HargaBox
            // 
            HargaBox.Location = new Point(416, 332);
            HargaBox.Margin = new Padding(4, 4, 4, 4);
            HargaBox.Name = "HargaBox";
            HargaBox.Size = new Size(394, 35);
            HargaBox.TabIndex = 6;
            HargaBox.TextChanged += HargaBox_TextChanged;
            // 
            // AlamatBox
            // 
            AlamatBox.Location = new Point(416, 429);
            AlamatBox.Margin = new Padding(4, 4, 4, 4);
            AlamatBox.Name = "AlamatBox";
            AlamatBox.Size = new Size(394, 35);
            AlamatBox.TabIndex = 7;
            AlamatBox.TextChanged += AlamatBox_TextChanged;
            // 
            // KapasitasBox
            // 
            KapasitasBox.Location = new Point(416, 528);
            KapasitasBox.Margin = new Padding(4, 4, 4, 4);
            KapasitasBox.Name = "KapasitasBox";
            KapasitasBox.Size = new Size(394, 35);
            KapasitasBox.TabIndex = 8;
            KapasitasBox.TextChanged += KapasitasBox_TextChanged;
            // 
            // TambahButton
            // 
            TambahButton.Location = new Point(504, 618);
            TambahButton.Margin = new Padding(4, 4, 4, 4);
            TambahButton.Name = "TambahButton";
            TambahButton.Size = new Size(196, 44);
            TambahButton.TabIndex = 9;
            TambahButton.Text = "Tambah Kos";
            TambahButton.UseVisualStyleBackColor = true;
            TambahButton.Click += TambahButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 18);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 142);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // AddKos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 802);
            Controls.Add(pictureBox1);
            Controls.Add(TambahButton);
            Controls.Add(KapasitasBox);
            Controls.Add(AlamatBox);
            Controls.Add(HargaBox);
            Controls.Add(NamaKosBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AddKos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddKos";
            Load += AddKos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NamaKosBox;
        private TextBox HargaBox;
        private TextBox AlamatBox;
        private TextBox KapasitasBox;
        private Button TambahButton;
        private PictureBox pictureBox1;
    }
}