namespace GUI.Renter
{
    partial class Profile
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
            PasswordLabelPasien = new Label();
            EditPassword = new TextBox();
            EditEmail = new TextBox();
            EmailLabelPasien = new Label();
            panel2 = new Panel();
            UsernameLabelPasien = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EditButtonPenyewa
            // 
            EditButtonPenyewa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButtonPenyewa.BackColor = Color.Firebrick;
            EditButtonPenyewa.ForeColor = Color.White;
            EditButtonPenyewa.Location = new Point(801, 589);
            EditButtonPenyewa.Margin = new Padding(4);
            EditButtonPenyewa.Name = "EditButtonPenyewa";
            EditButtonPenyewa.Size = new Size(264, 74);
            EditButtonPenyewa.TabIndex = 12;
            EditButtonPenyewa.Text = "Edit";
            EditButtonPenyewa.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(715, 114);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 458);
            panel1.TabIndex = 11;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.ForeColor = Color.White;
            RoleLabel.Location = new Point(22, 353);
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
            RoleLabelPasien.Location = new Point(22, 310);
            RoleLabelPasien.Margin = new Padding(4, 0, 4, 0);
            RoleLabelPasien.Name = "RoleLabelPasien";
            RoleLabelPasien.Size = new Size(53, 30);
            RoleLabelPasien.TabIndex = 5;
            RoleLabelPasien.Text = "Role";
            // 
            // PasswordLabelPasien
            // 
            PasswordLabelPasien.AutoSize = true;
            PasswordLabelPasien.ForeColor = Color.White;
            PasswordLabelPasien.Location = new Point(22, 206);
            PasswordLabelPasien.Margin = new Padding(4, 0, 4, 0);
            PasswordLabelPasien.Name = "PasswordLabelPasien";
            PasswordLabelPasien.Size = new Size(99, 30);
            PasswordLabelPasien.TabIndex = 4;
            PasswordLabelPasien.Text = "Password";
            // 
            // EditPassword
            // 
            EditPassword.Location = new Point(22, 240);
            EditPassword.Margin = new Padding(4);
            EditPassword.Multiline = true;
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(387, 54);
            EditPassword.TabIndex = 2;
            // 
            // EditEmail
            // 
            EditEmail.Location = new Point(22, 140);
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
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(242, 239, 234);
            panel2.Controls.Add(UsernameLabelPasien);
            panel2.Location = new Point(240, 567);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 97);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // UsernameLabelPasien
            // 
            UsernameLabelPasien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabelPasien.AutoSize = true;
            UsernameLabelPasien.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabelPasien.Location = new Point(150, 25);
            UsernameLabelPasien.Margin = new Padding(4, 0, 4, 0);
            UsernameLabelPasien.Name = "UsernameLabelPasien";
            UsernameLabelPasien.Size = new Size(148, 38);
            UsernameLabelPasien.TabIndex = 2;
            UsernameLabelPasien.Text = "Username";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.download__1___1_;
            pictureBox1.Location = new Point(240, 101);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(EditButtonPenyewa);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Profile";
            Size = new Size(1396, 765);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button EditButtonPenyewa;
        private Panel panel1;
        private Label RoleLabel;
        private Label label3;
        private Label RoleLabelPasien;
        private Label PasswordLabelPasien;
        private TextBox EditPassword;
        private TextBox EditEmail;
        private Label EmailLabelPasien;
        private Panel panel2;
        private Label UsernameLabelPasien;
        private PictureBox pictureBox1;
    }
}
