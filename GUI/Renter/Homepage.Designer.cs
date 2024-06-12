namespace GUI.Renter
{
    partial class Homepage
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            selectedKosDetailsLabel = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(49, 141);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(940, 402);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 44);
            label1.Name = "label1";
            label1.Size = new Size(211, 65);
            label1.TabIndex = 4;
            label1.Text = "List Kos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(1036, 141);
            label2.Name = "label2";
            label2.Size = new Size(142, 45);
            label2.TabIndex = 4;
            label2.Text = "Cari Kos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(1036, 408);
            label3.Name = "label3";
            label3.Size = new Size(167, 45);
            label3.TabIndex = 4;
            label3.Text = "Sortir Kos";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(1217, 272);
            button1.Name = "button1";
            button1.Size = new Size(131, 49);
            button1.TabIndex = 5;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "< 5,000,000", "5,000,000 - 10,000,000", "> 10,000,000" });
            comboBox1.Location = new Point(1036, 506);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 38);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1036, 201);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 61);
            textBox1.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.142858F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1036, 453);
            label4.Name = "label4";
            label4.Size = new Size(89, 28);
            label4.TabIndex = 4;
            label4.Text = "by harga";
            label4.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 567);
            label5.Name = "label5";
            label5.Size = new Size(286, 45);
            label5.TabIndex = 4;
            label5.Text = "Kos yang dipilih : ";
            // 
            // selectedKosDetailsLabel
            // 
            selectedKosDetailsLabel.AutoSize = true;
            selectedKosDetailsLabel.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedKosDetailsLabel.Location = new Point(341, 567);
            selectedKosDetailsLabel.Name = "selectedKosDetailsLabel";
            selectedKosDetailsLabel.Size = new Size(0, 45);
            selectedKosDetailsLabel.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(49, 635);
            button2.Name = "button2";
            button2.Size = new Size(131, 62);
            button2.TabIndex = 8;
            button2.Text = "Sewa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectedKosDetailsLabel);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Homepage";
            Size = new Size(1396, 765);
            Load += Homepage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label selectedKosDetailsLabel;
        private Button button2;
    }
}
