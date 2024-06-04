namespace GUI
{
    partial class RenterHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenterHome));
            dataGridView1 = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            homepage = new Panel();
            button1 = new Button();
            reservasi = new Panel();
            button2 = new Button();
            mykos = new Panel();
            button3 = new Button();
            profile = new Panel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            homepage.SuspendLayout();
            reservasi.SuspendLayout();
            mykos.SuspendLayout();
            profile.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 232);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 72;
            dataGridView1.Size = new Size(940, 646);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.BackColor = Color.WhiteSmoke;
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(homepage);
            flowLayoutPanel1.Controls.Add(reservasi);
            flowLayoutPanel1.Controls.Add(mykos);
            flowLayoutPanel1.Controls.Add(profile);
            flowLayoutPanel1.ForeColor = SystemColors.ButtonHighlight;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0, 100, 0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 30, 10, 10);
            flowLayoutPanel1.Size = new Size(273, 900);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(4);
            pictureBox1.Size = new Size(245, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // homepage
            // 
            homepage.Controls.Add(button1);
            homepage.Location = new Point(13, 154);
            homepage.Name = "homepage";
            homepage.Size = new Size(245, 82);
            homepage.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.System;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 100, 3, 3);
            button1.Name = "button1";
            button1.Size = new Size(245, 82);
            button1.TabIndex = 0;
            button1.Text = "HOMEPAGE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // reservasi
            // 
            reservasi.Controls.Add(button2);
            reservasi.Location = new Point(13, 242);
            reservasi.Name = "reservasi";
            reservasi.Size = new Size(245, 82);
            reservasi.TabIndex = 1;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.System;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 100, 3, 3);
            button2.Name = "button2";
            button2.Size = new Size(245, 82);
            button2.TabIndex = 0;
            button2.Text = "RESERVASI";
            button2.UseVisualStyleBackColor = true;
            // 
            // mykos
            // 
            mykos.Controls.Add(button3);
            mykos.Location = new Point(13, 330);
            mykos.Name = "mykos";
            mykos.Size = new Size(245, 82);
            mykos.TabIndex = 1;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(3, 100, 3, 3);
            button3.Name = "button3";
            button3.Size = new Size(245, 82);
            button3.TabIndex = 0;
            button3.Text = "MY KOS";
            button3.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            profile.Controls.Add(button4);
            profile.Location = new Point(13, 418);
            profile.Name = "profile";
            profile.Size = new Size(245, 82);
            profile.TabIndex = 1;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.Location = new Point(0, 0);
            button4.Margin = new Padding(3, 100, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(245, 82);
            button4.TabIndex = 0;
            button4.Text = "PROFILE";
            button4.UseVisualStyleBackColor = true;
            // 
            // RenterHome
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(dataGridView1);
            IsMdiContainer = true;
            Name = "RenterHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RenterHome";
            Load += RenterHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            homepage.ResumeLayout(false);
            reservasi.ResumeLayout(false);
            mykos.ResumeLayout(false);
            profile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Panel homepage;
        private Panel reservasi;
        private Button button2;
        private Panel profile;
        private Button button3;
        private Panel panel4;
        private Button button4;
        private PictureBox pictureBox1;
        private Panel mykos;
    }
}