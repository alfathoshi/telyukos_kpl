using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telyukos.Model;

namespace GUI
{
    public partial class HomePageOwner : Form
    {
        private HttpClient httpClient;
        private List<Kos> kosList;
        private static User Akun; // Variabel untuk menyimpan informasi pemilik kos yang sedang login
        public HomePageOwner(User akun)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            kosList = new List<Kos>();
            Akun = akun; // Simpan informasi pemilik kos yang sedang login
            LoadKosList();
        }

        private async void LoadKosList()
        {
            try
            {
                // Ambil data kos-kosan dari API
                HttpResponseMessage response = await httpClient.GetAsync("api/Kos"); // Sesuaikan dengan endpoint API Anda
                response.EnsureSuccessStatusCode();

                // Deserialisasi data kos-kosan
                kosList = await response.Content.ReadFromJsonAsync<List<Kos>>();

                // Tampilkan data kos-kosan di listBoxKos
                DisplayKosList(kosList);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat data kos-kosan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void listBoxKos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil kos yang dipilih dan tampilkan detailnya
            if (listBoxKos.SelectedItem != null)
            {
                var selectedKos = listBoxKos.SelectedItem.ToString();
                // Lakukan sesuatu dengan selectedKos, misalnya memuat detail kos
                LoadKosDetail(selectedKos);
            }
        }

        private async void LoadKosDetail(string namaKos)
        {
            try
            {
                // Ambil data detail kos dari API berdasarkan nama kos
                HttpResponseMessage response = await httpClient.GetAsync($"api/Kos/{namaKos}"); // Sesuaikan dengan endpoint API Anda
                response.EnsureSuccessStatusCode();

                // Deserialisasi data detail kos
                var kosDetail = await response.Content.ReadFromJsonAsync<Kos>();

                // Tampilkan detail kos di listBoxDetail
                listBoxDetail.Items.Clear();
                listBoxDetail.Items.Add($"Nama: {kosDetail.Nama}");
                listBoxDetail.Items.Add($"Alamat: {kosDetail.Alamat}");
                listBoxDetail.Items.Add($"Harga: {kosDetail.Harga}");
                listBoxDetail.Items.Add($"Kapasitas: {kosDetail.Kapasitas}");
                listBoxDetail.Items.Add($"Status: {kosDetail.Status}");
                if (kosDetail.Penyewa != null && kosDetail.Penyewa.Count > 0)
                {
                    listBoxDetail.Items.Add("Penyewa:");
                    foreach (var penyewa in kosDetail.Penyewa)
                    {
                        listBoxDetail.Items.Add($"- {penyewa}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat detail kos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBoxDetail_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DisplayKosList(List<Kos> list)
        {
            listBoxKos.Items.Clear();
            foreach (var kos in list)
            {
                listBoxKos.Items.Add(kos.Nama); // Sesuaikan dengan properti yang ingin ditampilkan
            }
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Ambil teks pencarian dari SearchBox
            string searchText = SearchBox.Text.ToLower();

            // Filter daftar kos berdasarkan teks pencarian
            var filteredKosList = kosList.Where(k => k.Nama.ToLower().Contains(searchText)).ToList();

            // Tampilkan daftar kos yang difilter di listBoxKos
            if (filteredKosList.Count > 0)
            {
                DisplayKosList(filteredKosList);
            }
            else
            {
                listBoxKos.Items.Clear();
                listBoxKos.Items.Add("Kos yang anda cari tidak ditemukan");
            }
        }

        private void FilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Ambil teks filter dari FilterBox
            string selectedFilter = FilterBox.SelectedItem.ToString();

            // Filter daftar kos berdasarkan harga
            List<Kos> filteredKosList;
            if (selectedFilter == "Harga Tertinggi")
            {
                filteredKosList = kosList.OrderByDescending(k => k.Harga).ToList();
            }
            else if (selectedFilter == "Harga Terendah")
            {
                filteredKosList = kosList.OrderBy(k => k.Harga).ToList();
            }
            else
            {
                filteredKosList = kosList; // Jika tidak ada filter, tampilkan semua kos
            }

            // Tampilkan daftar kos yang difilter di listBoxKos
            DisplayKosList(filteredKosList);
        }

        private void CariButton_Click(object sender, EventArgs e)
        {

        }

        private void HomePageOwner_Load(object sender, EventArgs e)
        {

        }

        private void TambahKosButton_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void OwnerName_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Username: {Akun.Email}", "Pemilik Kos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
