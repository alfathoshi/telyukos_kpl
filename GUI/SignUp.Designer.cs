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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(759, 261);
            textBoxEmail.Margin = new Padding(6, 6, 6, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(482, 39);
            textBoxEmail.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(759, 353);
            textBoxPassword.Margin = new Padding(6, 6, 6, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(482, 39);
            textBoxPassword.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Penyewa", "Pemilik" });
            comboBoxRole.Location = new Point(757, 476);
            comboBoxRole.Margin = new Padding(6, 6, 6, 6);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(482, 40);
            comboBoxRole.TabIndex = 2;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(759, 528);
            buttonSignUp.Margin = new Padding(6, 6, 6, 6);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(139, 49);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(759, 208);
            label1.Name = "label1";
            label1.Size = new Size(71, 32);
            label1.TabIndex = 4;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(759, 315);
            label2.Name = "label2";
            label2.Size = new Size(111, 32);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(757, 438);
            label3.Name = "label3";
            label3.Size = new Size(60, 32);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // labelPasswordCheck
            // 
            labelPasswordCheck.ForeColor = Color.Red;
            labelPasswordCheck.Location = new Point(757, 398);
            labelPasswordCheck.Name = "labelPasswordCheck";
            labelPasswordCheck.Size = new Size(667, 44);
            labelPasswordCheck.TabIndex = 7;
            labelPasswordCheck.Text = "Password must include at least one number and one symbol.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(757, 120);
            label4.Name = "label4";
            label4.Size = new Size(154, 32);
            label4.TabIndex = 8;
            label4.Text = "Sign Up Now";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(68, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 574);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(757, 672);
            label5.Name = "label5";
            label5.Size = new Size(378, 32);
            label5.TabIndex = 10;
            label5.Text = "Already have an account? Sign Up";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
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
            Margin = new Padding(6, 6, 6, 6);
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
    }
}
