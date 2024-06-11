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

namespace GUI
{
    public partial class FormHome : Form
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        public FormHome()
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
            // Make DataGridView read-only
            dataGridView1.ReadOnly = true;

            // Set selection mode to FullRowSelect
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Disable user ability to sort columns
            dataGridView1.AllowUserToOrderColumns = false;

            // Optional: Disable user ability to add or delete rows
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;

            // Optional: Set multi-select to false to allow only one row to be selected at a time
            dataGridView1.MultiSelect = false;

            // Set no rows selected by default
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            // Auto size columns to fill DataGridView
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
    }
}
