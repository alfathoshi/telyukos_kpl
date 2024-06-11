namespace GUI.Renter
{
    partial class MyKos
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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(531, 389);
            label1.Name = "label1";
            label1.Size = new Size(505, 149);
            label1.TabIndex = 1;
            label1.Text = "MY KOS";
            // 
            // MyKos
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 964);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyKos";
            Text = "MyKos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}