namespace GUI
{
    partial class MyKosPemilik
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
            namaColum = new DataGridViewTextBoxColumn();
            hargaColum = new DataGridViewTextBoxColumn();
            alamatColum = new DataGridViewTextBoxColumn();
            kapasitasColum = new DataGridViewTextBoxColumn();
            label1 = new Label();
            NamaText = new TextBox();
            HargaText = new TextBox();
            AlamatText = new TextBox();
            KapasitasText = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            EditButton = new Button();
            HapusButton = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(242, 239, 234);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { namaColum, hargaColum, alamatColum, kapasitasColum });
            dataGridView1.Location = new Point(20, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(666, 433);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // namaColum
            // 
            namaColum.HeaderText = "Nama";
            namaColum.MinimumWidth = 8;
            namaColum.Name = "namaColum";
            namaColum.Width = 150;
            // 
            // hargaColum
            // 
            hargaColum.HeaderText = "Harga";
            hargaColum.MinimumWidth = 8;
            hargaColum.Name = "hargaColum";
            hargaColum.Width = 150;
            // 
            // alamatColum
            // 
            alamatColum.HeaderText = "Alamat";
            alamatColum.MinimumWidth = 8;
            alamatColum.Name = "alamatColum";
            alamatColum.Width = 150;
            // 
            // kapasitasColum
            // 
            kapasitasColum.HeaderText = "Kapasitas";
            kapasitasColum.MinimumWidth = 8;
            kapasitasColum.Name = "kapasitasColum";
            kapasitasColum.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 48);
            label1.TabIndex = 1;
            label1.Text = "My Kos";
            // 
            // NamaText
            // 
            NamaText.Location = new Point(823, 162);
            NamaText.Name = "NamaText";
            NamaText.Size = new Size(194, 31);
            NamaText.TabIndex = 2;
            // 
            // HargaText
            // 
            HargaText.Location = new Point(823, 218);
            HargaText.Name = "HargaText";
            HargaText.Size = new Size(194, 31);
            HargaText.TabIndex = 3;
            // 
            // AlamatText
            // 
            AlamatText.Location = new Point(823, 277);
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(194, 31);
            AlamatText.TabIndex = 4;
            // 
            // KapasitasText
            // 
            KapasitasText.Location = new Point(823, 339);
            KapasitasText.Name = "KapasitasText";
            KapasitasText.Size = new Size(194, 31);
            KapasitasText.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(730, 165);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 6;
            label2.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(730, 221);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 7;
            label3.Text = "Harga";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(730, 280);
            label4.Name = "label4";
            label4.Size = new Size(68, 25);
            label4.TabIndex = 8;
            label4.Text = "Alamat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(730, 342);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 9;
            label5.Text = "Kapasitas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(730, 104);
            label6.Name = "label6";
            label6.Size = new Size(145, 38);
            label6.TabIndex = 10;
            label6.Text = "Detail Kos";
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Firebrick;
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(730, 376);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(145, 45);
            EditButton.TabIndex = 11;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += editButton_Click;
            // 
            // HapusButton
            // 
            HapusButton.BackColor = Color.Firebrick;
            HapusButton.ForeColor = Color.White;
            HapusButton.Location = new Point(881, 376);
            HapusButton.Name = "HapusButton";
            HapusButton.Size = new Size(136, 45);
            HapusButton.TabIndex = 12;
            HapusButton.Text = "Delete";
            HapusButton.UseVisualStyleBackColor = false;
            HapusButton.Click += hapusButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Firebrick;
            button3.ForeColor = Color.White;
            button3.Location = new Point(808, 427);
            button3.Name = "button3";
            button3.Size = new Size(138, 44);
            button3.TabIndex = 13;
            button3.Text = "Home";
            button3.UseVisualStyleBackColor = false;
            // 
            // MyKosPemilik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1051, 542);
            Controls.Add(button3);
            Controls.Add(HapusButton);
            Controls.Add(EditButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(KapasitasText);
            Controls.Add(AlamatText);
            Controls.Add(HargaText);
            Controls.Add(NamaText);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "MyKosPemilik";
            Text = "Form1";
            Load += MyKosPemilik_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox NamaText;
        private TextBox HargaText;
        private TextBox AlamatText;
        private TextBox KapasitasText;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button EditButton;
        private Button HapusButton;
        private Button button3;
        private DataGridViewTextBoxColumn namaColum;
        private DataGridViewTextBoxColumn hargaColum;
        private DataGridViewTextBoxColumn alamatColum;
        private DataGridViewTextBoxColumn kapasitasColum;
    }
}