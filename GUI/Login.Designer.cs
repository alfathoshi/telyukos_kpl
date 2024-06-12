
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(661, 381);
            textBox1.Margin = new Padding(4, 6, 4, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(506, 35);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(661, 477);
            textBox2.Margin = new Padding(4, 6, 4, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(523, 35);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged_1;
            // 
            // button1
            // 
            button1.Location = new Point(661, 563);
            button1.Margin = new Padding(4, 6, 4, 6);
            button1.Name = "button1";
            button1.Size = new Size(129, 46);
            button1.TabIndex = 2;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(661, 207);
            label1.Name = "label1";
            label1.Size = new Size(316, 74);
            label1.TabIndex = 3;
            label1.Text = "Log In Now";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(661, 331);
            label2.Name = "label2";
            label2.Size = new Size(63, 30);
            label2.TabIndex = 6;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(661, 441);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(798, 571);
            label4.Name = "label4";
            label4.Size = new Size(165, 30);
            label4.TabIndex = 8;
            label4.Text = "Forgot Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(661, 661);
            label5.Name = "label5";
            label5.Size = new Size(349, 30);
            label5.TabIndex = 9;
            label5.Text = "Don't have an account yet? Sign Up.";
            label5.Click += label5_Click;
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
            tableLayoutPanel1.TabIndex = 10;
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
            guna2Button5.Location = new Point(1276, 0);
            guna2Button5.Name = "guna2Button5";
            guna2Button5.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button5.Size = new Size(121, 87);
            guna2Button5.TabIndex = 11;
            guna2Button5.Text = "X";
            guna2Button5.Click += guna2Button5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 964);
            Controls.Add(guna2Button5);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 6, 4, 6);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
    }
}
