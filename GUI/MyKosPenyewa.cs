using System.Net.Http.Json;
using User = telyukos.Model.User;

namespace GUI
{
    public partial class MyKosPenyewa : Form
    {

        private HttpClient httpClient;
        private static User Akun;

        // Konstruktor untuk menginisialisasi API
        public MyKosPenyewa(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            Akun = user;
        }

        //menampilkan data kos yang disewa pada label dari hasil method LoadUserMyKosPenyewa
        private async void MyKosPenyewa_Load(object sender, EventArgs e)
        {
            //memanggil method LoadUserMyKosPenyewa
            await LoadUserMyKosPenyewa();
        }

        // Method untuk menampilkan data yang telah disewa oleh penyewa
        public async Task LoadUserMyKosPenyewa()
        {
            try
            {
                // Pastikan email diambil dari Akun yang sudah diset setelah login
                var userEmail = Akun?.Email;
                if (string.IsNullOrEmpty(userEmail))
                {
                    MessageBox.Show("User email is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Permintaan untuk mendapatkan semua data kos
                var response = await httpClient.GetAsync("api/Auth/");
                response.EnsureSuccessStatusCode();

                // Periksa apakah responsnya berhasil
                if (response.IsSuccessStatusCode)
                {
                    // mengecek apakah email saat login sudah sesuai dengan email pada list user
                    var allUsers = await response.Content.ReadFromJsonAsync<List<User>>();
                    var currentUser = allUsers?.Find(Akun => Akun.Email == userEmail);

                    // mengecek data kos dan nama email kosong atau tidak
                    if (currentUser != null && currentUser.Kos != null)
                    {
                        // Dengan asumsi Kos adalah daftar kos yang disewa, tampilkan data tersebut kedalam label
                        foreach (var kos in currentUser.Kos)
                        {
                            NamaLabel.Text = kos.Nama.ToString();
                            HargaLabel.Text = kos.Harga.ToString();
                            AlamatLabel.Text = kos.Alamat.ToString();
                            KapasitasLabel.Text = kos.Kapasitas.ToString();
                        }
                    }
                    else
                    {
                        //jika data kos tidak ada kosong
                        MessageBox.Show("Tidak ditemukan data kos untuk pengguna saat ini.");
                    }
                }
                else
                {
                    // jika responnya tidak berhasil
                    MessageBox.Show("Gagal memuat data kos.");
                }
            }
            catch (Exception ex)
            {
                //kondisi jika email user dan data kos tidak valid
                MessageBox.Show($"Kesalahan saat memuat data kos: {ex.Message}");
            }
        }

        private async void BatalSewaButton_Click(object sender, EventArgs e)
        {
            // Pastikan Akun dan Kos diset dengan detail yang benar
            var userEmail = Akun?.Email;
            var kosNama = NamaLabel.Text; // Dengan asumsi kos nama ditampilkan di namaLabel

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(kosNama))
            {
                //kondisi jika nama email dan nama kos tidak valid
                MessageBox.Show("User email or kos name is not available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tampilkan kotak dialog konfirmasi untuk batal sewa
            var confirmResult = MessageBox.Show("Apakah Anda yakin ingin membatalkan sewa kos ini?", "Konfirmasi Batal Sewa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                //mengecek response pada api di auth
                HttpResponseMessage response = await httpClient.DeleteAsync($"api/Auth/cancel-rental/{userEmail}/{kosNama}");

                if (response.IsSuccessStatusCode)
                {
                    //jika succes maka data masa sewa kos berhasil di batalkan
                    MessageBox.Show("Sewa kos berhasil dibatalkan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadUserMyKosPenyewa(); // merefresh form myKosPenyewa
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    //jika status data kos tidak sesuai
                    MessageBox.Show("Kos tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //kondisi jika email, dan data kos tidak valid
                    MessageBox.Show("Gagal membatalkan sewa kos: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void KapasitasLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
