using GUI.Renter;
using telyukos.Model;

namespace GUI.Owner
{
    public partial class OwnerHome : Form
    {
        private User akun;
        public OwnerHome(User user)
        {
            InitializeComponent();
            akun = user;
            HomepageOwner home = new HomepageOwner(akun);
            addUserControl(home);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelController.Controls.Clear();
            panelController.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void closeApp(object sender, EventArgs e)
        {
            Dispose();
        }

        private void myKosTab(object sender, EventArgs e)
        {
            MyKosOwner mykos = new MyKosOwner(akun);
            addUserControl(mykos);
        }

        private void homepageTab(object sender, EventArgs e)
        {
            HomepageOwner home = new HomepageOwner(akun);
            addUserControl(home);
        }

        private void profileTab(object sender, EventArgs e)
        {
            ProfileOwner profile = new ProfileOwner(akun);
            addUserControl(profile);
        }
    }
}
