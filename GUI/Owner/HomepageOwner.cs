using System.Net.Http.Json;
using telyukos.Model;
using telyukos_library.Searching;

namespace GUI.Owner
{
    public partial class HomepageOwner : UserControl
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        private static User akun;
        Kos[] listKos;
        Kos selectedKos;
        public HomepageOwner(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/");
            akun = user;
            loadDataKos();
            InitializeDataGridView();
            InitializeComboBox();
            dataGridView1.SizeChanged += DataGridView1_SizeChanged;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void InitializeComboBox()
        {
            // Populate the ComboBox with price ranges

            rangeHarga.SelectedIndex = 0; // Set default selection to "All"

            rangeHarga.SelectedIndexChanged += ComboBoxPriceRange_SelectedIndexChanged;
        }

        private void ComboBoxPriceRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRange = rangeHarga.SelectedItem.ToString();
            IEnumerable<Kos> filteredKosList;

            switch (selectedRange)
            {
                case "< 5,000,000":
                    filteredKosList = listKos.Where(k => k.Harga >= 0 && k.Harga <= 5000000);
                    break;
                case "5,000,000 - 10,000,000":
                    filteredKosList = listKos.Where(k => k.Harga >= 5000001 && k.Harga <= 10000000);
                    break;
                case "> 10,000,000":
                    filteredKosList = listKos.Where(k => k.Harga >= 10000001);
                    break;
                default:
                    filteredKosList = listKos; // Show all if "All" is selected
                    break;
            }

            // Bind the filtered data to the DataGridView
            dataGridView1.DataSource = filteredKosList.ToList();
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
                HttpResponseMessage resp = await httpClient.GetAsync("api/Kos");
                resp.EnsureSuccessStatusCode();
                listKos = await resp.Content.ReadFromJsonAsync<Kos[]>();

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

        public async Task CariKos(String namaKos)
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

        private void cariButton_Click(object sender, EventArgs e)
        {
            CariKos(namaKos.Text);
        }
    }
}
