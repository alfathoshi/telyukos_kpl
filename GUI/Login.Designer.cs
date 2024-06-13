
namespace GUI
{
    partial class Login
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            TextBoxEmail = new TextBox();
            TextBoxPassword = new TextBox();
            SignUpButton = new Button();
            LogInTitle = new Label();
            LabelEmail = new Label();
            LabelPassword = new Label();
            SwitchForgotPasswordPage = new Label();
            SwitchSignUpPage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            GambarLogo = new PictureBox();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GambarLogo).BeginInit();
            SuspendLayout();
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(386, 190);
            TextBoxEmail.Margin = new Padding(2, 3, 2, 3);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(297, 23);
            TextBoxEmail.TabIndex = 0;
            TextBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // TextBoxPassword
            // 
            TextBoxPassword.Location = new Point(386, 238);
            TextBoxPassword.Margin = new Padding(2, 3, 2, 3);
            TextBoxPassword.Name = "TextBoxPassword";
            TextBoxPassword.Size = new Size(307, 23);
            TextBoxPassword.TabIndex = 1;
            TextBoxPassword.TextChanged += textBoxPassword_TextChanged;
            // 
            // SignUpButton
            // 
            SignUpButton.Location = new Point(386, 282);
            SignUpButton.Margin = new Padding(2, 3, 2, 3);
            SignUpButton.Name = "SignUpButton";
            SignUpButton.Size = new Size(75, 23);
            SignUpButton.TabIndex = 2;
            SignUpButton.Text = "Log In";
            SignUpButton.UseVisualStyleBackColor = true;
            SignUpButton.Click += signUpButton_Click;
            // 
            // LogInTitle
            // 
            LogInTitle.AutoSize = true;
            LogInTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogInTitle.Location = new Point(386, 104);
            LogInTitle.Margin = new Padding(2, 0, 2, 0);
            LogInTitle.Name = "LogInTitle";
            LogInTitle.Size = new Size(184, 45);
            LogInTitle.TabIndex = 3;
            LogInTitle.Text = "Log In Now";
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(386, 166);
            LabelEmail.Margin = new Padding(2, 0, 2, 0);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(36, 15);
            LabelEmail.TabIndex = 6;
            LabelEmail.Text = "Email";
            // 
            // LabelPassword
            // 
            LabelPassword.AutoSize = true;
            LabelPassword.Location = new Point(386, 220);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(57, 15);
            LabelPassword.TabIndex = 7;
            LabelPassword.Text = "Password";
            // 
            // SwitchForgotPasswordPage
            // 
            SwitchForgotPasswordPage.AutoSize = true;
            SwitchForgotPasswordPage.Location = new Point(465, 286);
            SwitchForgotPasswordPage.Margin = new Padding(2, 0, 2, 0);
            SwitchForgotPasswordPage.Name = "SwitchForgotPasswordPage";
            SwitchForgotPasswordPage.Size = new Size(95, 15);
            SwitchForgotPasswordPage.TabIndex = 8;
            SwitchForgotPasswordPage.Text = "Forgot Password";
            SwitchForgotPasswordPage.Click += switchForgotPasswordPage_Click;
            // 
            // SwitchSignUpPage
            // 
            SwitchSignUpPage.AutoSize = true;
            SwitchSignUpPage.Location = new Point(386, 330);
            SwitchSignUpPage.Margin = new Padding(2, 0, 2, 0);
            SwitchSignUpPage.Name = "SwitchSignUpPage";
            SwitchSignUpPage.Size = new Size(197, 15);
            SwitchSignUpPage.TabIndex = 9;
            SwitchSignUpPage.Text = "Don't have an account yet? Sign Up.";
            SwitchSignUpPage.Click += switchSignUpPage_Click;
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
            tableLayoutPanel1.TabIndex = 10;
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
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges3;
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
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button5.Size = new Size(71, 44);
            guna2Button5.TabIndex = 11;
            guna2Button5.Text = "X";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 482);
            Controls.Add(guna2Button5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SwitchSignUpPage);
            Controls.Add(SwitchForgotPasswordPage);
            Controls.Add(LabelPassword);
            Controls.Add(LabelEmail);
            Controls.Add(LogInTitle);
            Controls.Add(SignUpButton);
            Controls.Add(TextBoxPassword);
            Controls.Add(TextBoxEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 3, 2, 3);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GambarLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxEmail;
        private TextBox TextBoxPassword;
        private Button SignUpButton;
        private Label LogInTitle;
        private Label LabelEmail;
        private Label LabelPassword;
        private Label SwitchForgotPasswordPage;
        private Label SwitchSignUpPage;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox GambarLogo;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}
