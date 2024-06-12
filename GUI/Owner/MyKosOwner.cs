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
using telyukos.Model;
using telyukos_library.Searching;
using User = telyukos.Model.User;


namespace GUI.Owner
{
    public partial class MyKosOwner : UserControl
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        private static User akun;
        Kos[] listKos;
        Kos selectedKos;
        public MyKosOwner(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
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

    }
}
