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

        private void homepageTab(object sender, EventArgs e)
        {
            Homepage home = new Homepage(akun);
            addUserControl(home);
        }

        private void myKosTab(object sender, EventArgs e)
        {
            My_Kos mykos = new My_Kos(akun);
            addUserControl(mykos);
        }

        private void profileTab(object sender, EventArgs e)
        {
            Profile profile = new Profile(akun);
            addUserControl(profile);
        }
        private void closeApp(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
