namespace GUI
{
    partial class profilePemilik
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
            panel2 = new Panel();
            UsernameLabel = new Label();
            panel1 = new Panel();
            Role = new Label();
            PasswordText = new TextBox();
            EmailText = new TextBox();
            RoleLabel = new Label();
            PasswordLabel = new Label();
            EmailLabel = new Label();
            label3 = new Label();
            EditButton = new Button();
            pictureBox1 = new PictureBox();
            MyKosPemilikButton = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(242, 239, 234);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(UsernameLabel);
            panel2.Location = new Point(124, 453);
            panel2.Name = "panel2";
            panel2.Size = new Size(362, 81);
            panel2.TabIndex = 3;
            panel2.Paint += panel1_Paint;
            // 
            // UsernameLabel
            // 
            UsernameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            UsernameLabel.AutoSize = true;
            UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UsernameLabel.Location = new Point(126, 21);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(128, 32);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username";
            UsernameLabel.Click += UsernameLabel_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Firebrick;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(Role);
            panel1.Controls.Add(PasswordText);
            panel1.Controls.Add(EmailText);
            panel1.Controls.Add(RoleLabel);
            panel1.Controls.Add(PasswordLabel);
            panel1.Controls.Add(EmailLabel);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(528, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 382);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint_1;
            // 
            // Role
            // 
            Role.AutoSize = true;
            Role.Location = new Point(18, 308);
            Role.Name = "Role";
            Role.Size = new Size(0, 25);
            Role.TabIndex = 12;
            Role.Click += label1_Click_3;
            // 
            // PasswordText
            // 
            PasswordText.Location = new Point(18, 200);
            PasswordText.Multiline = true;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(323, 46);
            PasswordText.TabIndex = 11;
            PasswordText.TextChanged += PasswordText_TextChanged;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(18, 114);
            EmailText.Multiline = true;
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(323, 46);
            EmailText.TabIndex = 10;
            EmailText.TextChanged += EmailText_TextChanged;
            // 
            // RoleLabel
            // 
            RoleLabel.AutoSize = true;
            RoleLabel.ForeColor = SystemColors.ButtonHighlight;
            RoleLabel.Location = new Point(18, 269);
            RoleLabel.Name = "RoleLabel";
            RoleLabel.Size = new Size(46, 25);
            RoleLabel.TabIndex = 9;
            RoleLabel.Text = "Role";
            RoleLabel.Click += RoleLabel_Click;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = SystemColors.ButtonHighlight;
            PasswordLabel.Location = new Point(18, 172);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(87, 25);
            PasswordLabel.TabIndex = 8;
            PasswordLabel.Text = "Password";
            PasswordLabel.Click += PasswordLabel_Click;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.ForeColor = SystemColors.ButtonHighlight;
            EmailLabel.Location = new Point(18, 86);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(54, 25);
            EmailLabel.TabIndex = 7;
            EmailLabel.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(18, 28);
            label3.Name = "label3";
            label3.Size = new Size(141, 48);
            label3.TabIndex = 6;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            EditButton.BackColor = Color.Firebrick;
            EditButton.ForeColor = SystemColors.ButtonHighlight;
            EditButton.Location = new Point(602, 510);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(220, 62);
            EditButton.TabIndex = 7;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 253, 239);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = Properties.Resources.download__2___1_;
            pictureBox1.Location = new Point(124, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(362, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MyKosPemilikButton
            // 
            MyKosPemilikButton.Location = new Point(23, 24);
            MyKosPemilikButton.Name = "MyKosPemilikButton";
            MyKosPemilikButton.Size = new Size(72, 75);
            MyKosPemilikButton.TabIndex = 8;
            MyKosPemilikButton.Text = "Back";
            MyKosPemilikButton.UseVisualStyleBackColor = true;
            MyKosPemilikButton.Click += MyKosPemilikButton_Click;
            // 
            // profilePemilik
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(920, 584);
            Controls.Add(MyKosPemilikButton);
            Controls.Add(pictureBox1);
            Controls.Add(EditButton);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "profilePemilik";
            Text = "profilePemilik";
            Load += profilePemilik_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Panel panel1;
        private Button EditButton;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label3;
        private Label PasswordLabel;
        private Label EmailLabel;
        private Label RoleLabel;
        internal Label UsernameLabel;
        internal TextBox PasswordText;
        internal TextBox EmailText;
        private Label Role;
        private Button MyKosPemilikButton;
    }
}