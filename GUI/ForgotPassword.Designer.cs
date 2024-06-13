namespace GUI
{
    partial class ForgotPassword
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
            LabelCheckOTP = new Label();
            TextBoxVerificationCode = new TextBox();
            TextBoxEmail = new TextBox();
            LabelEmail = new Label();
            TextBoxNewPassword = new TextBox();
            LabelNewPassword = new Label();
            ButtonSubmit = new Button();
            ChangePasswordTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            GambarLogo = new PictureBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)GambarLogo).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LabelCheckOTP
            // 
            LabelCheckOTP.AutoSize = true;
            LabelCheckOTP.Location = new Point(589, 400);
            LabelCheckOTP.Margin = new Padding(5, 0, 5, 0);
            LabelCheckOTP.Name = "LabelCheckOTP";
            LabelCheckOTP.Size = new Size(399, 30);
            LabelCheckOTP.TabIndex = 0;
            LabelCheckOTP.Text = "Check your email for the verification code";
            // 
            // TextBoxVerificationCode
            // 
            TextBoxVerificationCode.Location = new Point(589, 436);
            TextBoxVerificationCode.Margin = new Padding(5, 6, 5, 6);
            TextBoxVerificationCode.Name = "TextBoxVerificationCode";
            TextBoxVerificationCode.Size = new Size(169, 35);
            TextBoxVerificationCode.TabIndex = 1;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(589, 274);
            TextBoxEmail.Margin = new Padding(5, 6, 5, 6);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(169, 35);
            TextBoxEmail.TabIndex = 3;
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(589, 238);
            LabelEmail.Margin = new Padding(5, 0, 5, 0);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(584, 30);
            LabelEmail.TabIndex = 2;
            LabelEmail.Text = "Put your email of the account you want to reset the password";
            // 
            // TextBoxNewPassword
            // 
            TextBoxNewPassword.Location = new Point(589, 594);
            TextBoxNewPassword.Margin = new Padding(5, 6, 5, 6);
            TextBoxNewPassword.Name = "TextBoxNewPassword";
            TextBoxNewPassword.Size = new Size(169, 35);
            TextBoxNewPassword.TabIndex = 5;
            // 
            // LabelNewPassword
            // 
            LabelNewPassword.AutoSize = true;
            LabelNewPassword.Location = new Point(589, 558);
            LabelNewPassword.Margin = new Padding(5, 0, 5, 0);
            LabelNewPassword.Name = "LabelNewPassword";
            LabelNewPassword.Size = new Size(226, 30);
            LabelNewPassword.TabIndex = 4;
            LabelNewPassword.Text = "Set new password here";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(589, 724);
            ButtonSubmit.Margin = new Padding(5, 6, 5, 6);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(129, 46);
            ButtonSubmit.TabIndex = 6;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += buttonSubmit_Click;
            // 
            // ChangePasswordTitle
            // 
            ChangePasswordTitle.AutoSize = true;
            ChangePasswordTitle.Font = new Font("Segoe UI", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangePasswordTitle.Location = new Point(589, 136);
            ChangePasswordTitle.Margin = new Padding(5, 0, 5, 0);
            ChangePasswordTitle.Name = "ChangePasswordTitle";
            ChangePasswordTitle.Size = new Size(423, 65);
            ChangePasswordTitle.TabIndex = 7;
            ChangePasswordTitle.Text = "Change Password";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkRed;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GambarLogo
            // 
            GambarLogo.Dock = DockStyle.Fill;
            GambarLogo.Image = Properties.Resources.tk;
            GambarLogo.Location = new Point(3, 4);
            GambarLogo.Margin = new Padding(3, 4, 3, 4);
            GambarLogo.Name = "GambarLogo";
            GambarLogo.Size = new Size(194, 956);
            GambarLogo.SizeMode = PictureBoxSizeMode.CenterImage;
            GambarLogo.TabIndex = 0;
            GambarLogo.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.DarkRed;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(437, 900);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.tk;
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(431, 892);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(ChangePasswordTitle);
            Controls.Add(ButtonSubmit);
            Controls.Add(TextBoxNewPassword);
            Controls.Add(LabelNewPassword);
            Controls.Add(TextBoxEmail);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxVerificationCode);
            Controls.Add(LabelCheckOTP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 6, 5, 6);
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot Pass";
            ((System.ComponentModel.ISupportInitialize)GambarLogo).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabelCheckOTP;
        private TextBox TextBoxVerificationCode;
        private TextBox TextBoxEmail;
        private Label LabelEmail;
        private TextBox TextBoxNewPassword;
        private Label LabelNewPassword;
        private Button ButtonSubmit;
        private Label ChangePasswordTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox GambarLogo;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox1;
    }
}