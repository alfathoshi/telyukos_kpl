namespace GUI.Owner
{
    partial class ProfileOwner
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
            EditButtonPenyewa = new Button();
            panel1 = new Panel();
            RoleLabel = new Label();
            label3 = new Label();
            RoleLabelPasien = new Label();
            EditEmail = new TextBox();
            EmailLabelPasien = new Label();
            changePass = new Button();
            pictureBox1 = new PictureBox();
            UsernameLabelPasien = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // EditButtonPenyewa
            // 
            EditButtonPenyewa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButtonPenyewa.BackColor = Color.Firebrick;
            EditButtonPenyewa.ForeColor = Color.White;
            EditButtonPenyewa.Location = new Point(715, 560);
            EditButtonPenyewa.Margin = new Padding(4);
            EditButtonPenyewa.Name = "EditButtonPenyewa";
            EditButtonPenyewa.Size = new Size(213, 97);
            EditButtonPenyewa.TabIndex = 16;
            EditButtonPenyewa.Text = "Update\r\nEmail\r\n";
            EditButtonPenyewa.UseVisualStyleBackColor = false;
            EditButtonPenyewa.Click += EditButtonPenyewa_Click_1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(RoleLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RoleLabelPasien);
            panel1.Controls.Add(EditEmail);
            panel1.Controls.Add(EmailLabelPasien);
            panel1.Location = new Point(715, 107);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 445);
            panel1.TabIndex = 15;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.ForeColor = Color.White;
            RoleLabel.Location = new Point(22, 296);
            RoleLabel.Margin = new Padding(4, 0, 4, 0);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(53, 30);
            RoleLabel.TabIndex = 7;
            RoleLabel.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(22, 34);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(166, 57);
            label3.TabIndex = 6;
            label3.Text = "Profile";
            // 
            // RoleLabelPasien
            // 
            RoleLabelPasien.AutoSize = true;
            RoleLabelPasien.ForeColor = Color.White;
            RoleLabelPasien.Location = new Point(22, 243);
            RoleLabelPasien.Margin = new Padding(4, 0, 4, 0);
            RoleLabelPasien.Name = "RoleLabelPasien";
            RoleLabelPasien.Size = new Size(53, 30);
            RoleLabelPasien.TabIndex = 5;
            RoleLabelPasien.Text = "Role";
            // 
            // EditEmail
            // 
            EditEmail.Location = new Point(22, 162);
            EditEmail.Margin = new Padding(4);
            EditEmail.Multiline = true;
            EditEmail.Name = "EditEmail";
            EditEmail.Size = new Size(387, 54);
            EditEmail.TabIndex = 1;
            // 
            // EmailLabelPasien
            // 
            EmailLabelPasien.AutoSize = true;
            EmailLabelPasien.ForeColor = Color.White;
            EmailLabelPasien.Location = new Point(22, 107);
            EmailLabelPasien.Margin = new Padding(4, 0, 4, 0);
            EmailLabelPasien.Name = "EmailLabelPasien";
            EmailLabelPasien.Size = new Size(63, 30);
            EmailLabelPasien.TabIndex = 0;
            EmailLabelPasien.Text = "Email";
            // 
            // changePass
            // 
            changePass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            changePass.BackColor = Color.Firebrick;
            changePass.ForeColor = Color.White;
            changePass.Location = new Point(936, 560);
            changePass.Margin = new Padding(4);
            changePass.Name = "changePass";
            changePass.Size = new Size(221, 97);
            changePass.TabIndex = 17;
            changePass.Text = "Change \r\nPassword";
            changePass.UseVisualStyleBackColor = false;
            changePass.Click += changePass_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profile;
            pictureBox1.Location = new Point(240, 107);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // UsernameLabelPasien
            // 
            UsernameLabelPasien.AutoSize = true;
            UsernameLabelPasien.BorderStyle = BorderStyle.FixedSingle;
            UsernameLabelPasien.Dock = DockStyle.Fill;
            UsernameLabelPasien.FlatStyle = FlatStyle.Flat;
            UsernameLabelPasien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabelPasien.Location = new Point(0, 0);
            UsernameLabelPasien.Margin = new Padding(0);
            UsernameLabelPasien.Name = "UsernameLabelPasien";
            UsernameLabelPasien.Size = new Size(434, 97);
            UsernameLabelPasien.TabIndex = 1;
            UsernameLabelPasien.Text = "Username";
            UsernameLabelPasien.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(242, 239, 234);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(UsernameLabelPasien, 0, 0);
            tableLayoutPanel1.Location = new Point(240, 560);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(434, 97);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // ProfileOwner
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditButtonPenyewa);
            Controls.Add(panel1);
            Controls.Add(changePass);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "ProfileOwner";
            Size = new Size(1396, 765);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button EditButtonPenyewa;
        private Panel panel1;
        private Label RoleLabel;
        private Label label3;
        private Label RoleLabelPasien;
        private TextBox EditEmail;
        private Label EmailLabelPasien;
        private Button changePass;
        private PictureBox pictureBox1;
        private Label UsernameLabelPasien;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
