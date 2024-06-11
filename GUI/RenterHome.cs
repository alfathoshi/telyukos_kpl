using GUI.Renter;
using System.Net.Http.Json;
using telyukos.Model;
using telyukos_library.Searching;

namespace GUI
{
    public partial class RenterHome : Form
    {

        private static List<Kos> listkos;

        FormHome home;
        Reservasi formReservasi;


        public RenterHome()
        {
            InitializeComponent();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RenterHome_Load(object sender, EventArgs e)
        {

        }





        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new FormHome();
                home.MdiParent = this;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formReservasi == null)
            {
                formReservasi = new Reservasi();
                formReservasi.MdiParent = this;
                formReservasi.Show();
            }
            else
            {
                formReservasi.Activate();
            }
        }
    }
}
