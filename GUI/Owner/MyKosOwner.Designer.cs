namespace GUI.Owner
{
    partial class MyKosOwner
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            HapusButton = new Button();
            EditButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            KapasitasText = new TextBox();
            AlamatText = new TextBox();
            HargaText = new TextBox();
            NamaText = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 42);
            label1.Name = "label1";
            label1.Size = new Size(211, 65);
            label1.TabIndex = 17;
            label1.Text = "List Kos";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(58, 139);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(847, 559);
            dataGridView1.TabIndex = 16;
            // 
            // HapusButton
            // 
            HapusButton.BackColor = Color.Firebrick;
            HapusButton.ForeColor = Color.White;
            HapusButton.Location = new Point(1139, 507);
            HapusButton.Margin = new Padding(4);
            HapusButton.Name = "HapusButton";
            HapusButton.Size = new Size(163, 54);
            HapusButton.TabIndex = 28;
            HapusButton.Text = "Delete";
            HapusButton.UseVisualStyleBackColor = false;
            // 
            // EditButton
            // 
            EditButton.BackColor = Color.Firebrick;
            EditButton.ForeColor = Color.White;
            EditButton.Location = new Point(958, 507);
            EditButton.Margin = new Padding(4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(174, 54);
            EditButton.TabIndex = 27;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(958, 139);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(172, 45);
            label6.TabIndex = 26;
            label6.Text = "Detail Kos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(958, 429);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 30);
            label5.TabIndex = 25;
            label5.Text = "Kapasitas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(958, 355);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 24;
            label4.Text = "Alamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(958, 284);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 23;
            label3.Text = "Harga";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(958, 217);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 30);
            label2.TabIndex = 22;
            label2.Text = "Nama";
            // 
            // KapasitasText
            // 
            KapasitasText.Location = new Point(1070, 426);
            KapasitasText.Margin = new Padding(4);
            KapasitasText.Name = "KapasitasText";
            KapasitasText.Size = new Size(232, 35);
            KapasitasText.TabIndex = 21;
            // 
            // AlamatText
            // 
            AlamatText.Location = new Point(1070, 351);
            AlamatText.Margin = new Padding(4);
            AlamatText.Name = "AlamatText";
            AlamatText.Size = new Size(232, 35);
            AlamatText.TabIndex = 20;
            // 
            // HargaText
            // 
            HargaText.Location = new Point(1070, 281);
            HargaText.Margin = new Padding(4);
            HargaText.Name = "HargaText";
            HargaText.Size = new Size(232, 35);
            HargaText.TabIndex = 19;
            // 
            // NamaText
            // 
            NamaText.Location = new Point(1070, 213);
            NamaText.Margin = new Padding(4);
            NamaText.Name = "NamaText";
            NamaText.Size = new Size(232, 35);
            NamaText.TabIndex = 18;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1001, 600);
            button1.Name = "button1";
            button1.Size = new Size(165, 54);
            button1.TabIndex = 29;
            button1.Text = "Tambah Kos";
            button1.UseVisualStyleBackColor = false;
            // 
            // MyKosOwner
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
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
            Name = "MyKosOwner";
            Size = new Size(1396, 765);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button HapusButton;
        private Button EditButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox KapasitasText;
        private TextBox AlamatText;
        private TextBox HargaText;
        private TextBox NamaText;
        private Button button1;
    }
}
