using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telyukos.Model;

namespace GUI.Renter
{
    public partial class My_Kos : UserControl
    {
        private HttpClient httpClient;
        private static User Akun;
        public My_Kos(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            Akun = user;
            LoadUserMyKosPenyewa();
        }
        public async void LoadUserMyKosPenyewa()
        {
            var userEmail = Akun?.Email;
            var response = await httpClient.GetAsync("api/Auth/");
            response.EnsureSuccessStatusCode();
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
    }
}
