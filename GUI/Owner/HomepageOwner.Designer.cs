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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            selectedKosDetailsLabel = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1036, 213);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 61);
            textBox1.TabIndex = 18;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "< 5,000,000", "5,000,000 - 10,000,000", "> 10,000,000" });
            comboBox1.Location = new Point(1036, 518);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(312, 38);
            comboBox1.TabIndex = 17;
            // 
            // button1
            // 
            button1.Location = new Point(1217, 284);
            button1.Name = "button1";
            button1.Size = new Size(131, 49);
            button1.TabIndex = 16;
            button1.Text = "Cari";
            button1.UseVisualStyleBackColor = true;
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
            // selectedKosDetailsLabel
            // 
            selectedKosDetailsLabel.AutoSize = true;
            selectedKosDetailsLabel.Font = new Font("Segoe UI Semibold", 14.1428576F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectedKosDetailsLabel.Location = new Point(341, 579);
            selectedKosDetailsLabel.Name = "selectedKosDetailsLabel";
            selectedKosDetailsLabel.Size = new Size(0, 45);
            selectedKosDetailsLabel.TabIndex = 13;
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
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(selectedKosDetailsLabel);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "HomepageOwner";
            Size = new Size(1396, 765);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label selectedKosDetailsLabel;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
