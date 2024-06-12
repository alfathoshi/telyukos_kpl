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

namespace GUI.Renter
{
    public partial class Homepage : UserControl
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        public Homepage()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/");
            loadDataKos();
            InitializeDataGridView();
            dataGridView1.SizeChanged += DataGridView1_SizeChanged;
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

        private void DataGridView1_SizeChanged(object sender, EventArgs e)
        {
            // Adjust column widths to fit the DataGridView size
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
        }
        public async void loadDataKos()
        {
            try
            {
                HttpResponseMessage resp = await httpClient.GetAsync("api/Kos");
                resp.EnsureSuccessStatusCode();
                Kos[] kosAda = await resp.Content.ReadFromJsonAsync<Kos[]>();

                if (kosAda == null || kosAda.Length == 0)
                {
                    Console.WriteLine("Tidak ada data Kos.");
                }
                else
                {
                    // Urutkan data berdasarkan ID
                    SelectionSort<Kos>.SortAscending(kosAda, k => k.Id);

                    // Bind the sorted data to the DataGridView
                    dataGridView1.DataSource = kosAda;

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

        public async void CariKos(String namaKos)
        {
            resp = await httpClient.GetAsync("api/Kos");
            resp.EnsureSuccessStatusCode();
            Kos[] findKos = await resp.Content.ReadFromJsonAsync<Kos[]>();

            // Urutkan data berdasarkan ID
            SelectionSort<Kos>.SortAscending(findKos, k => k.Id);
            Kos cariKos = SearchKos.Search(findKos, k => k.Nama.Equals(namaKos));
            if (cariKos != null)
            {
                MessageBox.Show($"Kos dengan nama {namaKos} ditemukan", "Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = new List<Kos> { cariKos };
            }
            else
            {
                MessageBox.Show($"Kos dengan nama {namaKos} tidak ditemukan", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CariKos(textBox1.Text);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
