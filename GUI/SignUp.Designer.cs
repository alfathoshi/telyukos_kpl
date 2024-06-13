namespace GUI
{
    partial class SignUp
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TextBoxEmail = new TextBox();
            TextBoxPassword = new TextBox();
            ComboBoxRole = new ComboBox();
            buttonSignUp = new Button();
            LabelEmail = new Label();
            LabelPassword = new Label();
            LabelRole = new Label();
            LabelPasswordCheck = new Label();
            SignUpTitle = new Label();
            SwitchLoginPage = new Label();
            LabelEmailCheck = new Label();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            GambarLogo = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GambarLogo).BeginInit();
            SuspendLayout();
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(348, 147);
            TextBoxEmail.Margin = new Padding(2, 3, 2, 3);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(261, 23);
            TextBoxEmail.TabIndex = 0;
            TextBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(348, 218);
            TextBoxPassword.Margin = new Padding(2, 3, 2, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(261, 23);
            TextBoxPassword.TabIndex = 1;
            // 
            // ComboBoxRole
            // 
            ComboBoxRole.FormattingEnabled = true;
            ComboBoxRole.Items.AddRange(new object[] { "Penyewa", "Pemilik" });
            ComboBoxRole.Location = new Point(348, 289);
            ComboBoxRole.Margin = new Padding(2, 3, 2, 3);
            ComboBoxRole.Name = "ComboBoxRole";
            ComboBoxRole.Size = new Size(261, 23);
            ComboBoxRole.TabIndex = 2;
            ComboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(348, 314);
            buttonSignUp.Margin = new Padding(2, 3, 2, 3);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(75, 23);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(348, 123);
            LabelEmail.Margin = new Padding(2, 0, 2, 0);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 4;
            LabelEmail.Text = "Email";

            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(348, 201);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 5;
            LabelPassword.Text = "Password";
            // 
            // LabelRole
            // 
            LabelRole.AutoSize = true;
            LabelRole.Location = new Point(348, 271);
            LabelRole.Margin = new Padding(2, 0, 2, 0);
            LabelRole.Name = "LabelRole";
            LabelRole.Size = new Size(30, 15);
            LabelRole.TabIndex = 6;
            LabelRole.Text = "Role";
            // 
            // LabelPasswordCheck
            // 
            LabelPasswordCheck.ForeColor = Color.Red;
            LabelPasswordCheck.Location = new Point(348, 244);
            LabelPasswordCheck.Margin = new Padding(2, 0, 2, 0);
            LabelPasswordCheck.Name = "LabelPasswordCheck";
            LabelPasswordCheck.Size = new Size(359, 21);
            LabelPasswordCheck.TabIndex = 7;
            LabelPasswordCheck.Text = "Password must include at least one number and one symbol.";
            // 
            // SignUpTitle
            // 
            SignUpTitle.AutoSize = true;
            SignUpTitle.Font = new Font("Segoe UI", 24F);
            SignUpTitle.Location = new Point(348, 67);
            SignUpTitle.Margin = new Padding(2, 0, 2, 0);
            SignUpTitle.Name = "SignUpTitle";
            SignUpTitle.Size = new Size(207, 45);
            SignUpTitle.TabIndex = 8;
            SignUpTitle.Text = "Sign Up Now";
            // 
            // SwitchLoginPage
            // 
            SwitchLoginPage.AutoSize = true;
            SwitchLoginPage.Location = new Point(348, 368);
            SwitchLoginPage.Margin = new Padding(2, 0, 2, 0);
            SwitchLoginPage.Name = "SwitchLoginPage";
            SwitchLoginPage.Size = new Size(178, 15);
            SwitchLoginPage.TabIndex = 10;
            SwitchLoginPage.Text = "Already have an account? Log In\r\n";
            SwitchLoginPage.Click += SwitchLoginPage_Click;
            // 
            // LabelEmailCheck
            // 
            LabelEmailCheck.ForeColor = Color.Red;
            LabelEmailCheck.Location = new Point(348, 173);
            LabelEmailCheck.Margin = new Padding(2, 0, 2, 0);
            LabelEmailCheck.Name = "LabelEmailCheck";
            LabelEmailCheck.Size = new Size(359, 21);
            LabelEmailCheck.TabIndex = 11;
            LabelEmailCheck.Text = "Email harus menggunakan domain";
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges5;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.DarkRed;
            guna2Button5.Font = new Font("Segoe UI Black", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.HoverState.FillColor = Color.DarkRed;
            guna2Button5.Location = new Point(744, 0);
            guna2Button5.Margin = new Padding(2, 2, 2, 2);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button5.Size = new Size(71, 44);
            guna2Button5.TabIndex = 13;
            guna2Button5.Text = "X";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkRed;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(GambarLogo, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2, 2, 2, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(255, 482);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // GambarLogo
            // 
            GambarLogo.Dock = DockStyle.Fill;
            GambarLogo.Image = Properties.Resources.tk;
            GambarLogo.Location = new Point(2, 2);
            GambarLogo.Margin = new Padding(2, 2, 2, 2);
            GambarLogo.Name = "GambarLogo";
            GambarLogo.Size = new Size(251, 478);
            GambarLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            GambarLogo.TabIndex = 0;
            GambarLogo.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 482);
            Controls.Add(guna2Button5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(LabelEmailCheck);
            Controls.Add(SwitchLoginPage);
            Controls.Add(SignUpTitle);
            Controls.Add(LabelPasswordCheck);
            Controls.Add(LabelRole);
            Controls.Add(LabelPassword);
            Controls.Add(LabelEmail);
            Controls.Add(buttonSignUp);
            Controls.Add(ComboBoxRole);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            Load += SignUp_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GambarLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.ComboBox ComboBoxRole;
        private System.Windows.Forms.Button buttonSignUp;
        private Label LabelEmail;
        private Label LabelPassword;
        private Label LabelRole;
        private Label LabelPasswordCheck;
        private Label SignUpTitle;
        private Label SwitchLoginPage;
        private Label LabelEmailCheck;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox GambarLogo;
    }
}
