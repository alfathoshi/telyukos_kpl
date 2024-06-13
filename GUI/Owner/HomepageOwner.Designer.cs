namespace GUI.Owner
{
    partial class HomepageOwner
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            namaKos = new TextBox();
            rangeHarga = new ComboBox();
            cariButton = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // namaKos
            // 
            namaKos.Location = new Point(1036, 213);
            namaKos.Multiline = true;
            namaKos.Name = "namaKos";
            namaKos.Size = new Size(312, 61);
            namaKos.TabIndex = 18;
            // 
            // rangeHarga
            // 
            rangeHarga.FormattingEnabled = true;
            rangeHarga.Items.AddRange(new object[] { "All", "< 5,000,000", "5,000,000 - 10,000,000", "> 10,000,000" });
            rangeHarga.Location = new Point(1036, 518);
            rangeHarga.Name = "rangeHarga";
            rangeHarga.Size = new Size(312, 38);
            rangeHarga.TabIndex = 17;
            // 
            // cariButton
            // 
            cariButton.Location = new Point(1217, 284);
            cariButton.Name = "cariButton";
            cariButton.Size = new Size(131, 49);
            cariButton.TabIndex = 16;
            cariButton.Text = "Cari";
            cariButton.UseVisualStyleBackColor = true;
            cariButton.Click += cariButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1036, 465);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 10;
            label4.Text = "by harga";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1036, 420);
            label3.Name = "label3";
            label3.Size = new Size(167, 45);
            label3.TabIndex = 11;
            label3.Text = "Sortir Kos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1036, 153);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 12;
            label2.Text = "Cari Kos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 56);
            label1.Name = "label1";
            label1.Size = new Size(211, 65);
            label1.TabIndex = 15;
            label1.Text = "List Kos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 153);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(940, 402);
            dataGridView1.TabIndex = 9;
            // 
            // HomepageOwner
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(namaKos);
            Controls.Add(rangeHarga);
            Controls.Add(cariButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "HomepageOwner";
            Size = new Size(1396, 765);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox namaKos;
        private ComboBox rangeHarga;
        private Button cariButton;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
