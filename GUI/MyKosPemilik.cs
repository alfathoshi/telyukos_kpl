using API.Controllers;
using Microsoft.AspNetCore.Components.Sections;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telyukos.Model;
using telyukos.State;
using telyukos_library.Searching;
using User = telyukos.Model.User;

namespace GUI
{
    public partial class MyKosPemilik : Form
    {
        private static User Akun;
        private HttpClient httpClient;

        // Konstruktor untuk menginisialisasi API
        public MyKosPemilik(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            Akun = user;

        }

        //menampilkan data kos yang disewa pada gridtable dan textfield dari hasil method LoadUserMyKosPenyewa
        private async void MyKosPemilik_Load(object sender, EventArgs e)
        {
            //memanggil method LoadUserMyKosPemilik
            await LoadUserMyKosPemilik();
        }

        // Method untuk menampilkan data yang telah didaftarkan oleh pemilik
        public async Task LoadUserMyKosPemilik()
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
                    var currentUser = allUsers?.Find(user => user.Email == userEmail);

                    // mengecek data kos dan nama email kosong atau tidak
                    if (currentUser != null && currentUser.Kos != null)
                    {
                        // jika data tersebut ada masukan ke DataGridView
                        dataGridView1.Rows.Clear(); // Hapus baris yang sudah tidak digunakan

                        foreach (var kos in currentUser.Kos)                        {
                            var row = new DataGridViewRow();
                            //membuat colum pada data gridview
                            row.CreateCells(dataGridView1);

                            row.Cells[0].Value = kos.Nama;
                            row.Cells[1].Value = kos.Harga;
                            row.Cells[2].Value = kos.Alamat;
                            row.Cells[3].Value = kos.Kapasitas;

                            dataGridView1.Rows.Add(row);
                        }
                    }
                    else
                    {
                        //jika data kos tidak ada
                        MessageBox.Show("Tidak ditemukan data kos untuk pengguna saat ini.");
                    }
                }
                else
                {
                    //kondisi ketika response tidak berhasil karena email tidak sesuai
                    MessageBox.Show("Gagal memuat data kos.");
                }
            }
            catch (Exception ex)
            {
                //kondisi ketika email dan data kos tidak valid
                MessageBox.Show($"Error loading kos data: {ex.Message}");
            }

        }

        // Method untuk menampilkan data di textfield, ketika klik pada grid table
        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // mengecek Pastikan indeks baris valid
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Isi kolom textfield dengan nilai dari baris sesuai yang dipilih
                NamaText.Text = row.Cells[0].Value?.ToString();
                HargaText.Text = row.Cells[1].Value?.ToString();
                AlamatText.Text = row.Cells[2].Value?.ToString();
                KapasitasText.Text = row.Cells[3].Value?.ToString();
            }
        }

        // method button untuk mengedit data kos
        private async void editButton_Click(object sender, EventArgs e)
        {
            //Dengan asumsi variable baru ditampilkan di textfield
            string newNama = NamaText.Text;
            string newHargaString = HargaText.Text;
            string newAlamat = AlamatText.Text;
            string newKapasitasString = KapasitasText.Text;
            var email = Akun.Email;

            // kondisi untuk mengubah harga dan kapasitas string menjadi bilangan bulat/int
            if (!int.TryParse(newHargaString, out int newHarga))
            {
                MessageBox.Show("Harga harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(newKapasitasString, out int newKapasitas))
            {
                MessageBox.Show("Kapasitas harus berupa angka.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buat objek User untuk mengubah password dan email
            Kos updatedKos = new Kos { Nama = newNama, Harga = newHarga, Alamat = newAlamat, Kapasitas = newKapasitas };

            // Buat permintaan PUT untuk mengubah password dan email
            HttpResponseMessage response = await httpClient.PutAsJsonAsync($"api/Auth/update-kos/{email}", updatedKos);

            if (response.IsSuccessStatusCode)
            {
                //kondisi jika data berhasil diupdate
                MessageBox.Show("Data Berhasil Terupdate", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                //kondisi jika nama kos tidak sesuai dengan saat daftar kos
                MessageBox.Show("Nama Kos tidak sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //kondisi jika email dan data kos tidak valid
                MessageBox.Show("Gagal mengubah data kos :" + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // method button untuk hapus data kos
        private async void hapusButton_Click(object sender, EventArgs e)
        {
            // Periksa apakah ada baris yang dipilih di DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //untuk ambil baris yang dipilih
                var selectedRow = dataGridView1.SelectedRows[0];
                //Ambil nama kos dari sel pertama
                var kosNama = selectedRow.Cells[0].Value?.ToString();
                // Ambil email pengguna dari objek Akun
                var email = Akun.Email;

                // Periksa apakah nama kos valid
                if (string.IsNullOrEmpty(kosNama))
                {
                    MessageBox.Show("Kos tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tampilkan kotak dialog konfirmasi untuk penghapusan 
                var confirmResult = MessageBox.Show("Apakah Anda yakin ingin menghapus kos ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Jika pengguna mengkonfirmasi penghapusan
                if (confirmResult == DialogResult.Yes)
                {
                    // Kirim permintaan DELETE untuk menghapus data kos
                    HttpResponseMessage response = await httpClient.DeleteAsync($"api/Auth/delete-kos/{email}/{kosNama}");

                    // Periksa apakah permintaan berhasil
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Kos berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //update data grid table view setelah dihapus
                        await LoadUserMyKosPemilik(); 
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        //kondisi jika data kos yang ingin dihapus tidak sesuai
                        MessageBox.Show("Kos tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        //kondisi jika data kos dan email tidak valid 
                        MessageBox.Show("Gagal menghapus kos: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                //kondisi jika belum memilih table grid 
                MessageBox.Show("Pilih kos yang ingin dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
