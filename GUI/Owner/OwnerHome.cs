using GUI.Renter;
using telyukos.Model;

namespace GUI.Owner
{
    public partial class OwnerHome : Form
    {
        private static User akun;
        public OwnerHome(User user)
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

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            MyKosOwner mykos = new MyKosOwner(akun);
            addUserControl(mykos);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Homepage home = new Homepage(akun);
            addUserControl(home);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ProfileOwner profile = new ProfileOwner(akun);
            addUserControl(profile);
        }
    }
}
