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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPasswordCheck = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            labelEmailCheck = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(409, 122);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 23);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(409, 193);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(261, 23);
            textBoxPassword.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Penyewa", "Pemilik" });
            comboBoxRole.Location = new Point(408, 264);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(261, 23);
            comboBoxRole.TabIndex = 2;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(409, 289);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(75, 23);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(409, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 4;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 176);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(408, 246);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // labelPasswordCheck
            // 
            labelPasswordCheck.ForeColor = Color.Red;
            labelPasswordCheck.Location = new Point(408, 219);
            labelPasswordCheck.Margin = new Padding(2, 0, 2, 0);
            labelPasswordCheck.Name = "labelPasswordCheck";
            labelPasswordCheck.Size = new Size(359, 21);
            labelPasswordCheck.TabIndex = 7;
            labelPasswordCheck.Text = "Password must include at least one number and one symbol.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(408, 42);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(207, 45);
            label4.TabIndex = 8;
            label4.Text = "Sign Up Now";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 61);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 269);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 343);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(178, 15);
            label5.TabIndex = 10;
            label5.Text = "Already have an account? Log In\r\n";
            label5.Click += label5_Click;
            // 
            // labelEmailCheck
            // 
            labelEmailCheck.ForeColor = Color.Red;
            labelEmailCheck.Location = new Point(408, 148);
            labelEmailCheck.Margin = new Padding(2, 0, 2, 0);
            labelEmailCheck.Name = "labelEmailCheck";
            labelEmailCheck.Size = new Size(359, 21);
            labelEmailCheck.TabIndex = 11;
            labelEmailCheck.Text = "Email harus menggunakan domain";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEmailCheck);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(labelPasswordCheck);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSignUp);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            Name = "SignUp";
            Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonSignUp;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label labelPasswordCheck;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Label labelEmailCheck;
    }
}
