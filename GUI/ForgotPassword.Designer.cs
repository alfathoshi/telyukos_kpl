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
            label1 = new Label();
            textBoxVerificationCode = new TextBox();
            textBoxEmail = new TextBox();
            label2 = new Label();
            textBoxNewPassword = new TextBox();
            label3 = new Label();
            buttonSubmit = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 378);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(399, 30);
            label1.TabIndex = 0;
            label1.Text = "Check your email for the verification code";
            label1.Click += label1_Click;
            // 
            // textBoxVerificationCode
            // 
            textBoxVerificationCode.Location = new Point(76, 414);
            textBoxVerificationCode.Margin = new Padding(5, 6, 5, 6);
            textBoxVerificationCode.Name = "textBoxVerificationCode";
            textBoxVerificationCode.Size = new Size(168, 35);
            textBoxVerificationCode.TabIndex = 1;
            textBoxVerificationCode.TextChanged += textBox1_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(76, 252);
            textBoxEmail.Margin = new Padding(5, 6, 5, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(168, 35);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 216);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(584, 30);
            label2.TabIndex = 2;
            label2.Text = "Put your email of the account you want to reset the password";
            label2.Click += label2_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(76, 572);
            textBoxNewPassword.Margin = new Padding(5, 6, 5, 6);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(168, 35);
            textBoxNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 536);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(226, 30);
            label3.TabIndex = 4;
            label3.Text = "Set new password here";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(76, 702);
            buttonSubmit.Margin = new Padding(5, 6, 5, 6);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(128, 46);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(76, 114);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(394, 62);
            label4.TabIndex = 7;
            label4.Text = "Change Password";
            label4.Click += label4_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1372, 900);
            Controls.Add(label4);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxNewPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxVerificationCode);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "ForgotPassword";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxVerificationCode;
        private TextBox textBoxEmail;
        private Label label2;
        private TextBox textBoxNewPassword;
        private Label label3;
        private Button buttonSubmit;
        private Label label4;
    }
}