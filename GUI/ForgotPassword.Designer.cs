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
            label1.Location = new Point(63, 315);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(340, 25);
            label1.TabIndex = 0;
            label1.Text = "Check your email for the verification code";
            label1.Click += label1_Click;
            // 
            // textBoxVerificationCode
            // 
            textBoxVerificationCode.Location = new Point(63, 345);
            textBoxVerificationCode.Margin = new Padding(4, 5, 4, 5);
            textBoxVerificationCode.Name = "textBoxVerificationCode";
            textBoxVerificationCode.Size = new Size(141, 31);
            textBoxVerificationCode.TabIndex = 1;
            textBoxVerificationCode.TextChanged += textBox1_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(63, 210);
            textBoxEmail.Margin = new Padding(4, 5, 4, 5);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(141, 31);
            textBoxEmail.TabIndex = 3;
            textBoxEmail.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 180);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(500, 25);
            label2.TabIndex = 2;
            label2.Text = "Put your email of the account you want to reset the password";
            label2.Click += label2_Click;
            // 
            // textBoxNewPassword
            // 
            textBoxNewPassword.Location = new Point(63, 477);
            textBoxNewPassword.Margin = new Padding(4, 5, 4, 5);
            textBoxNewPassword.Name = "textBoxNewPassword";
            textBoxNewPassword.Size = new Size(141, 31);
            textBoxNewPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(63, 447);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(195, 25);
            label3.TabIndex = 4;
            label3.Text = "Set new password here";
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(63, 585);
            buttonSubmit.Margin = new Padding(4, 5, 4, 5);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(107, 38);
            buttonSubmit.TabIndex = 6;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
<<<<<<< HEAD
            buttonSubmit.Click += buttonSubmit_Click;
=======
            buttonSubmit.Click += this.buttonSubmit_Click;
>>>>>>> c9ed1c5039c4759c14e44a8469eaf81c333ea97a
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(63, 95);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(317, 54);
            label4.TabIndex = 7;
            label4.Text = "Forgot Password";
            label4.Click += label4_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(label4);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxNewPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(textBoxVerificationCode);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
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