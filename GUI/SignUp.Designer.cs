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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBoxEmail = new TextBox();
            textBoxPassword = new TextBox();
            comboBoxRole = new ComboBox();
            buttonSignUp = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelPasswordCheck = new Label();
            label4 = new Label();
            label5 = new Label();
            labelEmailCheck = new Label();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(597, 294);
            textBoxEmail.Margin = new Padding(4, 6, 4, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(445, 35);
            textBoxEmail.TabIndex = 0;
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(597, 436);
            textBoxPassword.Margin = new Padding(4, 6, 4, 6);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(445, 35);
            textBoxPassword.TabIndex = 1;
            // 
            // comboBoxRole
            // 
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Penyewa", "Pemilik" });
            comboBoxRole.Location = new Point(596, 578);
            comboBoxRole.Margin = new Padding(4, 6, 4, 6);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(445, 38);
            comboBoxRole.TabIndex = 2;
            comboBoxRole.SelectedIndexChanged += comboBoxRole_SelectedIndexChanged;
            // 
            // buttonSignUp
            // 
            buttonSignUp.Location = new Point(597, 628);
            buttonSignUp.Margin = new Padding(4, 6, 4, 6);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(129, 46);
            buttonSignUp.TabIndex = 3;
            buttonSignUp.Text = "Sign Up";
            buttonSignUp.UseVisualStyleBackColor = true;
            buttonSignUp.Click += buttonSignUp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(597, 246);
            label1.Name = "label1";
            label1.Size = new Size(63, 30);
            label1.TabIndex = 4;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(597, 402);
            label2.Name = "label2";
            label2.Size = new Size(99, 30);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(596, 542);
            label3.Name = "label3";
            label3.Size = new Size(53, 30);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // labelPasswordCheck
            // 
            labelPasswordCheck.ForeColor = Color.Red;
            labelPasswordCheck.Location = new Point(596, 488);
            labelPasswordCheck.Name = "labelPasswordCheck";
            labelPasswordCheck.Size = new Size(615, 42);
            labelPasswordCheck.TabIndex = 7;
            labelPasswordCheck.Text = "Password must include at least one number and one symbol.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F);
            label4.Location = new Point(596, 134);
            label4.Name = "label4";
            label4.Size = new Size(357, 74);
            label4.TabIndex = 8;
            label4.Text = "Sign Up Now";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(596, 736);
            label5.Name = "label5";
            label5.Size = new Size(315, 30);
            label5.TabIndex = 10;
            label5.Text = "Already have an account? Log In\r\n";
            label5.Click += label5_Click;
            // 
            // labelEmailCheck
            // 
            labelEmailCheck.ForeColor = Color.Red;
            labelEmailCheck.Location = new Point(596, 346);
            labelEmailCheck.Name = "labelEmailCheck";
            labelEmailCheck.Size = new Size(615, 42);
            labelEmailCheck.TabIndex = 11;
            labelEmailCheck.Text = "Email harus menggunakan domain";
            // 
            // guna2Button5
            // 
            guna2Button5.CustomizableEdges = customizableEdges1;
            guna2Button5.DisabledState.BorderColor = Color.DarkGray;
            guna2Button5.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button5.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button5.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button5.FillColor = Color.DarkRed;
            guna2Button5.Font = new Font("Segoe UI Black", 20.1428585F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2Button5.ForeColor = Color.White;
            guna2Button5.HoverState.FillColor = Color.DarkRed;
            guna2Button5.Location = new Point(1275, 0);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button5.Size = new Size(121, 87);
            guna2Button5.TabIndex = 13;
            guna2Button5.Text = "X";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.DarkRed;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(438, 964);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.tk;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(432, 958);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 964);
            Controls.Add(guna2Button5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(labelEmailCheck);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(labelPasswordCheck);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonSignUp);
            Controls.Add(comboBoxRole);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign Up";
            tableLayoutPanel1.ResumeLayout(false);
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
        private Label label5;
        private Label labelEmailCheck;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}
