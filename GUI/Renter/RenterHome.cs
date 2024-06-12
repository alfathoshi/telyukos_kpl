using GUI.Renter;
using telyukos.Model;

namespace GUI
{
    public partial class RenterHome : Form
    {

        private static User akun;

        public RenterHome(User user)
        {
            InitializeComponent();
            akun = user;
            Homepage home = new Homepage(akun);
            addUserControl(home);

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelController.Controls.Clear();
            panelController.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Homepage home = new Homepage(akun);
            addUserControl(home);
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            My_Kos mykos = new My_Kos(akun);
            addUserControl(mykos);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Profile profile = new Profile(akun);
            addUserControl(profile);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
