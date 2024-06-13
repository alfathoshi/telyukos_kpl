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
            SuspendLayout();
            // 
            // LabelCheckOTP
            // 
            LabelCheckOTP.AutoSize = true;
            LabelCheckOTP.Location = new Point(44, 189);
            LabelCheckOTP.Name = "LabelCheckOTP";
            LabelCheckOTP.Size = new Size(228, 15);
            LabelCheckOTP.TabIndex = 0;
            LabelCheckOTP.Text = "Check your email for the verification code";
            
            // 
            // TextBoxVerificationCode
            // 
            TextBoxVerificationCode.Location = new Point(44, 207);
            TextBoxVerificationCode.Name = "TextBoxVerificationCode";
            TextBoxVerificationCode.Size = new Size(100, 23);
            TextBoxVerificationCode.TabIndex = 1;

            // 
            // TextBoxEmail
            // 
            TextBoxEmail.Location = new Point(44, 126);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(100, 23);
            TextBoxEmail.TabIndex = 3;
            
            // 
            // LabelEmail
            // 
            LabelEmail.AutoSize = true;
            LabelEmail.Location = new Point(44, 108);
            LabelEmail.Name = "LabelEmail";
            LabelEmail.Size = new Size(331, 15);
            LabelEmail.TabIndex = 2;
            LabelEmail.Text = "Put your email of the account you want to reset the password";
            
            // 
            // TextBoxNewPassword
            // 
            TextBoxNewPassword.Location = new Point(44, 286);
            TextBoxNewPassword.Name = "TextBoxNewPassword";
            TextBoxNewPassword.Size = new Size(100, 23);
            TextBoxNewPassword.TabIndex = 5;
            // 
            // LabelNewPassword
            // 
            LabelNewPassword.AutoSize = true;
            LabelNewPassword.Location = new Point(44, 268);
            LabelNewPassword.Name = "LabelNewPassword";
            LabelNewPassword.Size = new Size(127, 15);
            LabelNewPassword.TabIndex = 4;
            LabelNewPassword.Text = "Set new password here";
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.Location = new Point(44, 351);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.Size = new Size(75, 23);
            ButtonSubmit.TabIndex = 6;
            ButtonSubmit.Text = "Submit";
            ButtonSubmit.UseVisualStyleBackColor = true;
            ButtonSubmit.Click += buttonSubmit_Click;
            // 
            // ChangePasswordTitle
            // 
            ChangePasswordTitle.AutoSize = true;
            ChangePasswordTitle.Font = new Font("Segoe UI", 20F);
            ChangePasswordTitle.Location = new Point(44, 57);
            ChangePasswordTitle.Name = "ChangePasswordTitle";
            ChangePasswordTitle.Size = new Size(226, 37);
            ChangePasswordTitle.TabIndex = 7;
            ChangePasswordTitle.Text = "Change Password";
            
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChangePasswordTitle);
            Controls.Add(ButtonSubmit);
            Controls.Add(TextBoxNewPassword);
            Controls.Add(LabelNewPassword);
            Controls.Add(TextBoxEmail);
            Controls.Add(LabelEmail);
            Controls.Add(TextBoxVerificationCode);
            Controls.Add(LabelCheckOTP);
            Name = "ForgotPassword";
            Text = "Form1";
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
    }
}