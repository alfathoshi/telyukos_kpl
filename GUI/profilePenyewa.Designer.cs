namespace GUI
{
    partial class profilePenyewa
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
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            UsernameLabelPasien = new Label();
            panel1 = new Panel();
            RoleLabel = new Label();
            label3 = new Label();
            RoleLabelPasien = new Label();
            PasswordLabelPasien = new Label();
            EditPassword = new TextBox();
            EditEmail = new TextBox();
            EmailLabelPasien = new Label();
            EditButtonPasien = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__1___1_;
            pictureBox1.Location = new Point(58, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(242, 239, 234);
            panel2.Controls.Add(UsernameLabelPasien);
            panel2.Location = new Point(58, 415);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 81);
            panel2.TabIndex = 4;
            // 
            // UsernameLabelPasien
            // 
            UsernameLabelPasien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabelPasien.AutoSize = true;
            UsernameLabelPasien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabelPasien.Location = new Point(125, 21);
            UsernameLabelPasien.Name = "UsernameLabelPasien";
            UsernameLabelPasien.Size = new Size(128, 32);
            UsernameLabelPasien.TabIndex = 2;
            UsernameLabelPasien.Text = "Username";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(RoleLabel);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(RoleLabelPasien);
            panel1.Controls.Add(PasswordLabelPasien);
            panel1.Controls.Add(EditPassword);
            panel1.Controls.Add(EditEmail);
            panel1.Controls.Add(EmailLabelPasien);
            panel1.Location = new Point(472, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 382);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.ForeColor = Color.White;
            RoleLabel.Location = new Point(18, 294);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(59, 25);
            RoleLabel.TabIndex = 7;
            RoleLabel.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(18, 28);
            label3.Name = "label3";
            label3.Size = new Size(141, 48);
            label3.TabIndex = 6;
            label3.Text = "Profile";
            // 
            // RoleLabelPasien
            // 
            RoleLabelPasien.AutoSize = true;
            RoleLabelPasien.ForeColor = Color.White;
            RoleLabelPasien.Location = new Point(18, 258);
            RoleLabelPasien.Name = "RoleLabelPasien";
            RoleLabelPasien.Size = new Size(46, 25);
            RoleLabelPasien.TabIndex = 5;
            RoleLabelPasien.Text = "Role";
            // 
            // PasswordLabelPasien
            // 
            PasswordLabelPasien.AutoSize = true;
            PasswordLabelPasien.ForeColor = Color.White;
            PasswordLabelPasien.Location = new Point(18, 172);
            PasswordLabelPasien.Name = "PasswordLabelPasien";
            PasswordLabelPasien.Size = new Size(87, 25);
            PasswordLabelPasien.TabIndex = 4;
            PasswordLabelPasien.Text = "Password";
            // 
            // EditPassword
            // 
            EditPassword.Location = new Point(18, 200);
            EditPassword.Multiline = true;
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(323, 46);
            EditPassword.TabIndex = 2;
            EditPassword.TextChanged += PasswordText_TextChanged;
            // 
            // EditEmail
            // 
            EditEmail.Location = new Point(18, 117);
            EditEmail.Multiline = true;
            EditEmail.Name = "EditEmail";
            EditEmail.Size = new Size(323, 46);
            EditEmail.TabIndex = 1;
            EditEmail.TextChanged += EmailText_TextChanged;
            // 
            // EmailLabelPasien
            // 
            EmailLabelPasien.AutoSize = true;
            EmailLabelPasien.ForeColor = Color.White;
            EmailLabelPasien.Location = new Point(18, 89);
            EmailLabelPasien.Name = "EmailLabelPasien";
            EmailLabelPasien.Size = new Size(54, 25);
            EmailLabelPasien.TabIndex = 0;
            EmailLabelPasien.Text = "Email";
            // 
            // EditButtonPasien
            // 
            EditButtonPasien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButtonPasien.BackColor = Color.Firebrick;
            EditButtonPasien.ForeColor = Color.White;
            EditButtonPasien.Location = new Point(544, 423);
            EditButtonPasien.Name = "EditButtonPasien";
            EditButtonPasien.Size = new Size(220, 62);
            EditButtonPasien.TabIndex = 8;
            EditButtonPasien.Text = "Edit";
            EditButtonPasien.UseVisualStyleBackColor = false;
            EditButtonPasien.Click += EditButtonPasien_Click;
            // 
            // profilePenyewa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(920, 584);
            Controls.Add(EditButtonPasien);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "profilePenyewa";
            Text = "profilePenyewa";
            Load += profilePenyewa_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel2;
        private Label UsernameLabelPasien;
        private Panel panel1;
        private Label label3;
        private Label RoleLabelPasien;
        private Label PasswordLabelPasien;
        private ComboBox comboBox1;
        private TextBox EditPassword;
        private TextBox EditEmail;
        private Label EmailLabelPasien;
        private Button EditButtonPasien;
        private Label RoleLabel;
    }
}