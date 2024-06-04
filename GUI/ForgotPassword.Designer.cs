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
            label1.Location = new Point(44, 189);
            label1.Name = "label1";
            label1.Size = new Size(228, 15);
            label1.TabIndex = 0;
            label1.Text = "Check your email for the verification code";
            label1.Click += label1_Click;
            // 
            // textBoxVerificationCode
            // 
            textBoxVerificationCode.Location = new Point(44, 207);
            textBoxVerificationCode.Name = "textBoxVerificationCode";
            textBoxVerificationCode.Size = new Size(100, 23);
            textBoxVerificationCode.TabIndex = 1;
            textBoxVerificationCode.TextChanged += textBox1_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(44, 126);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(100, 23);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 108);
            label2.Name = "label2";
            label2.Size = new Size(331, 15);
            label2.TabIndex = 2;
            label2.Text = "Put your email of the account you want to reset the password";
            label2.Click += label2_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(44, 286);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(100, 23);
            textBoxNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 268);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 4;
            label3.Text = "Set new password here";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(44, 351);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(75, 23);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += this.buttonSubmit_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(44, 57);
            label4.Name = "label4";
            label4.Size = new Size(214, 37);
            label4.TabIndex = 7;
            label4.Text = "Forgot Password";
            label4.Click += label4_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxNewPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxVerificationCode);
            Controls.Add(label1);
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