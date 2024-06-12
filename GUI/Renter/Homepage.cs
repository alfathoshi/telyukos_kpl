using System.Net.Http.Json;
using telyukos.Model;
using telyukos.State;
using telyukos_library.Contract;
using telyukos_library.Searching;

namespace GUI.Renter
{
    public partial class Homepage : UserControl
    {
        private HttpClient httpClient;
        private HttpResponseMessage resp;
        private static User akun;
        Kos[] listKos;
        Kos selectedKos;
        public Homepage(User user)
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
                    selectedKosDetailsLabel.Text = selected.Nama;
                }
                selectedKos = selected;
            }
            else
            {
                selectedKosDetailsLabel.Text = "No Kos selected";
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

        /*public void filterKos()
        {
            int minPrice;
            bool validInputMinPrice = false;
            do
            {
                Console.Write("Masukkan harga minimum: ");
                minPrice = Convert.ToInt32(Console.ReadLine());

                // Memeriksa apakah harga minimum memenuhi kontrak
                validInputMinPrice = FilterContract.CheckContract(minPrice, 100000, 15000000);

                if (!validInputMinPrice)
                {
                    Console.WriteLine("Input tidak sesuai kontrak. Harga minimal harus lebih dari atau sama dengan Rp. 100.000");
                }
            } while (!validInputMinPrice);

            int maxPrice;
            bool validInputMaxPrice = false;
            do
            {
                Console.Write("Masukkan harga maksimum: ");
                maxPrice = Convert.ToInt32(Console.ReadLine());

                // Memeriksa apakah harga maksimum memenuhi kontrak
                validInputMaxPrice = FilterContract.CheckContract(maxPrice, 100000, 15000000);

                if (!validInputMaxPrice)
                {
                    Console.WriteLine("Input tidak sesuai kontrak. Harga maksimal harus kurang dari atau sama dengan Rp. 15.000.000");
                }
            } while (!validInputMaxPrice);

            var filteredKos = FilterKosByPrice(filterKos, minPrice, maxPrice);

            if (filteredKos.Any())
            {
                Console.WriteLine($"Kos dengan harga antara {minPrice} dan {maxPrice} ditemukan:");
                foreach (var kos in filteredKos)
                {
                    Console.WriteLine($"ID: {kos.Id},  Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                }
            }
            else
            {
                Console.WriteLine($"Tidak ada kos dengan harga antara {minPrice} dan {maxPrice} ditemukan.");
            }
        }*/

        public async Task reservasiAsync(Kos selectedKos)
        {
            if (selectedKos == null)
            {
                MessageBox.Show("No Kos selected");
                return;
            }

            // Find the Kos in the list
            Kos kosRent = listKos.FirstOrDefault(k => k.Id == selectedKos.Id);
            if (kosRent == null)
            {
                MessageBox.Show("Kos not found");
                return;
            }

            // Check if the Kos is full
            if (kosRent.Penyewa.Count >= kosRent.Kapasitas)
            {
                MessageBox.Show("Kos is already full");
                return;
            }

            // Ask for confirmation
            DialogResult dialogResult = MessageBox.Show($"Apakah anda akan reservasi kos {selectedKos.Nama}?", "Reservasi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Update user's Kos information
                    resp = await httpClient.PutAsJsonAsync($"api/Auth/{akun.Email}", kosRent);
                    if (resp.IsSuccessStatusCode)
                    {
                        // Add user to the list of tenants
                        kosRent.Penyewa.Add(akun.Email);

                        // Update the status if full
                        if (kosRent.Penyewa.Count >= kosRent.Kapasitas)
                        {
                            kosRent.Status = KosStatus.RentsStatus.FULL;
                        }

                        // Update the Kos information on the server
                        Kos updatedKos = kosRent;
                        resp = await httpClient.PutAsJsonAsync($"api/Kos/{selectedKos.Id}", updatedKos);
                        resp.EnsureSuccessStatusCode();

                        MessageBox.Show("Silahkan selesaikan pembayaran.");
                    }
                    else
                    {
                        MessageBox.Show("Kos ini dalam masa sewa.");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Failed to reserve Kos: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
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

        private void button2_Click(object sender, EventArgs e)
        {
            reservasiAsync(selectedKos);
        }
    }
}
