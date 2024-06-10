namespace GUI
{
    partial class HomePageOwner
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
            components = new System.ComponentModel.Container();
            listBoxKos = new ListBox();
            listBoxDetail = new ListBox();
            SearchBox = new TextBox();
            FilterBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox1 = new PictureBox();
            TambahKosButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxKos
            // 
            listBoxKos.FormattingEnabled = true;
            listBoxKos.Location = new Point(34, 306);
            listBoxKos.Name = "listBoxKos";
            listBoxKos.Size = new Size(366, 284);
            listBoxKos.TabIndex = 1;
            listBoxKos.SelectedIndexChanged += listBoxKos_SelectedIndexChanged;
            // 
            // listBoxDetail
            // 
            listBoxDetail.FormattingEnabled = true;
            listBoxDetail.Location = new Point(591, 306);
            listBoxDetail.Name = "listBoxDetail";
            listBoxDetail.Size = new Size(372, 284);
            listBoxDetail.TabIndex = 2;
            listBoxDetail.SelectedIndexChanged += listBoxDetail_SelectedIndexChanged;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(374, 144);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(246, 27);
            SearchBox.TabIndex = 3;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // FilterBox
            // 
            FilterBox.FormattingEnabled = true;
            FilterBox.Items.AddRange(new object[] { "Harga Tertinggi", "Harga Terendah" });
            FilterBox.Location = new Point(374, 193);
            FilterBox.Name = "FilterBox";
            FilterBox.Size = new Size(246, 28);
            FilterBox.TabIndex = 4;
            FilterBox.SelectedIndexChanged += FilterBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(282, 153);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 5;
            label2.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(282, 201);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 5;
            label3.Text = "Filter kos:";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_Telyu_Kos_Merah;
            pictureBox1.Location = new Point(417, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 79);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // TambahKosButton
            // 
            TambahKosButton.Location = new Point(428, 416);
            TambahKosButton.Name = "TambahKosButton";
            TambahKosButton.Size = new Size(131, 36);
            TambahKosButton.TabIndex = 8;
            TambahKosButton.Text = "Tambah Kos";
            TambahKosButton.UseVisualStyleBackColor = true;
            TambahKosButton.Click += TambahKosButton_Click;
            // 
            // HomePageOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 660);
            Controls.Add(TambahKosButton);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(FilterBox);
            Controls.Add(SearchBox);
            Controls.Add(listBoxDetail);
            Controls.Add(listBoxKos);
            Name = "HomePageOwner";
            Text = "HomePageOwner";
            Load += HomePageOwner_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBoxKos;
        private ListBox listBoxDetail;
        private TextBox SearchBox;
        private ComboBox FilterBox;
        private Label label2;
        private Label label3;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox1;
        private Button TambahKosButton;
    }
}