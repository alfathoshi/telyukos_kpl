using Microsoft.VisualBasic.ApplicationServices;
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
using telyukos;
using telyukos.Model;
using telyukos_library.Searching;
using User = telyukos.Model.User;


namespace GUI.Owner
{
    public partial class MyKosOwner : UserControl
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        private User akun;
        Kos[] listKos;
        Kos selectedKos;
        apiClient apiClient;
        public MyKosOwner(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            apiClient = new apiClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/");
            akun = user;
            loadDataKos();
            InitializeDataGridView();
            dataGridView1.SizeChanged += DataGridView1_SizeChanged;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }


        private void InitializeDataGridView()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToOrderColumns = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.MultiSelect = false;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selected = dataGridView1.SelectedRows[0].DataBoundItem as Kos;
                if (selected != null)
                {
                    NamaText.Text = selected.Nama;
                    HargaText.Text = selected.Harga.ToString();
                    AlamatText.Text = selected.Alamat;
                    KapasitasText.Text = selected.Kapasitas.ToString();
                }
                selectedKos = selected;
            }

        }

        private void DataGridView1_SizeChanged(object sender, EventArgs e)
        {
            // Adjust column widths to fit the DataGridView size
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }
        public async Task loadDataKos()
        {
            try
            {
                HttpResponseMessage resp = await httpClient.GetAsync($"api/Auth/{akun.Email}");
                resp.EnsureSuccessStatusCode();
                akun = await resp.Content.ReadFromJsonAsync<User>();

                listKos = akun.Kos.ToArray();

                if (listKos == null || listKos.Length == 0)
                {
                    Console.WriteLine("Tidak ada data Kos.");
                }
                else
                {
                    // Urutkan data berdasarkan ID
                    SelectionSort<Kos>.SortAscending(listKos, k => k.Id);

                    // Bind the sorted data to the DataGridView
                    dataGridView1.DataSource = listKos;

                    Console.WriteLine("Data Kos berhasil dimuat.");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Gagal mendapatkan data Kos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddKos addKosGui = new AddKos(akun);
            addKosGui.ShowDialog();
        }

        private async void EditButton_Click(object sender, EventArgs e)
        {
            //Dengan asumsi variable baru ditampilkan di textfield
            string newNama = NamaText.Text;
            string newHargaString = HargaText.Text;
            string newAlamat = AlamatText.Text;
            string newKapasitasString = KapasitasText.Text;
            var email = akun.Email;

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
            Kos updatedKos = new Kos { Id = selectedKos.Id, Nama = newNama, Harga = newHarga, Alamat = newAlamat, Kapasitas = newKapasitas };

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
            loadDataKos();
        }

        private async void HapusButton_Click(object sender, EventArgs e)
        {
            // Periksa apakah ada baris yang dipilih di DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //untuk ambil baris yang dipilih

                //Ambil nama kos dari sel pertama
                var kosNama = selectedKos.Nama;
                // Ambil email pengguna dari objek Akun
                var email = akun.Email;

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
                    await apiClient.DeleteKos(httpClient, selectedKos.Id);
                    // Periksa apakah permintaan berhasil
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Kos berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //update data grid table view setelah dihapus
                        await loadDataKos();
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
