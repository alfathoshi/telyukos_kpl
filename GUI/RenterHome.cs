using System.Net.Http.Json;
using telyukos.Model;
using telyukos_library.Searching;

namespace GUI
{
    public partial class RenterHome : Form
    {

        private static List<Kos> listkos;
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        FormHome home;


        public RenterHome()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RenterHome_Load(object sender, EventArgs e)
        {

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
                home.FormClosed += Home_FormClosed;
                home.MdiParent = this;
                home.Show();
            } else
            {
                home.Activate();
            }
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }
    }
}
