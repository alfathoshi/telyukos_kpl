using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenLoginForm();
        }

        private void OpenLoginForm()
        {
            RenterHome loginForm = new RenterHome();
            loginForm.FormClosed += (s, args) => this.Close();
            loginForm.ShowDialog();
        }
    }
}
