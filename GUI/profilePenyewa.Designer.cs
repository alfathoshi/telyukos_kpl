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
            EditButtonPenyewa = new Button();
            MyKosPenyewaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)Properties.Resources.ResourceManager.GetObject("download (1) (1).jpg");
            pictureBox1.Location = new Point(160, 102);
            pictureBox1.Margin = new Padding(4, 4, 4, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(434, 458);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(242, 239, 234);
            panel2.Controls.Add(UsernameLabelPasien);
            panel2.Location = new Point(160, 568);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 97);
            panel2.TabIndex = 4;
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
            panel1.Location = new Point(635, 115);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(442, 458);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
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
            EditPassword.Margin = new Padding(4, 4, 4, 4);
            EditPassword.Multiline = true;
            EditPassword.Name = "EditPassword";
            EditPassword.Size = new Size(387, 54);
            EditPassword.TabIndex = 2;
            EditPassword.TextChanged += PasswordText_TextChanged;
            // 
            // EditEmail
            // 
            EditEmail.Location = new Point(22, 140);
            EditEmail.Margin = new Padding(4, 4, 4, 4);
            EditEmail.Multiline = true;
            EditEmail.Name = "EditEmail";
            EditEmail.Size = new Size(387, 54);
            EditEmail.TabIndex = 1;
            EditEmail.TextChanged += EmailText_TextChanged;
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
            // EditButtonPenyewa
            // 
            EditButtonPenyewa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButtonPenyewa.BackColor = Color.Firebrick;
            EditButtonPenyewa.ForeColor = Color.White;
            EditButtonPenyewa.Location = new Point(721, 590);
            EditButtonPenyewa.Margin = new Padding(4, 4, 4, 4);
            EditButtonPenyewa.Name = "EditButtonPenyewa";
            EditButtonPenyewa.Size = new Size(264, 74);
            EditButtonPenyewa.TabIndex = 8;
            EditButtonPenyewa.Text = "Edit";
            EditButtonPenyewa.UseVisualStyleBackColor = false;
            EditButtonPenyewa.Click += EditButtonPasien_Click;
            // 
            // MyKosPenyewaButton
            // 
            MyKosPenyewaButton.Location = new Point(40, 41);
            MyKosPenyewaButton.Margin = new Padding(4, 4, 4, 4);
            MyKosPenyewaButton.Name = "MyKosPenyewaButton";
            MyKosPenyewaButton.Size = new Size(86, 90);
            MyKosPenyewaButton.TabIndex = 9;
            MyKosPenyewaButton.Text = "Back";
            MyKosPenyewaButton.UseVisualStyleBackColor = true;
            MyKosPenyewaButton.Click += MyKosPenyewaButton_Click;
            // 
            // profilePenyewa
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1104, 701);
            Controls.Add(MyKosPenyewaButton);
            Controls.Add(EditButtonPenyewa);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
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
        private Button EditButtonPenyewa;
        private Label RoleLabel;
        private Button MyKosPenyewaButton;
    }
}