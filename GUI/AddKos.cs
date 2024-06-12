using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using telyukos.Model;
using telyukos.State;

namespace GUI
{
    public partial class AddKos : Form
    {
        private readonly HttpClient _httpClient;
        private readonly User _akun;

        public event EventHandler KosAdded;

        public AddKos(User akun)
        {
            InitializeComponent();
            _httpClient = new HttpClient { BaseAddress = new Uri("https://localhost:7126/") };
            _akun = akun;
        }

        private void AddKos_Load(object sender, EventArgs e) { }

        private void NamaKosBox_TextChanged(object sender, EventArgs e) { }

        private void HargaBox_TextChanged(object sender, EventArgs e) { }

        private void AlamatBox_TextChanged(object sender, EventArgs e) { }

        private void KapasitasBox_TextChanged(object sender, EventArgs e) { }

        private async void TambahButton_Click(object sender, EventArgs e)
        {
            if (IsValidInput(out string errorMessage))
            {
                Kos newKos = CreateKosFromInput();

                try
                {
                    HttpResponseMessage response = await _httpClient.PostAsJsonAsync("api/Kos", newKos);
                    response.EnsureSuccessStatusCode();

                    KosAdded?.Invoke(this, EventArgs.Empty); // Trigger event

                    MessageBox.Show("Kos berhasil ditambahkan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gagal menambahkan kos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(NamaKosBox.Text) ||
                string.IsNullOrEmpty(HargaBox.Text) ||
                string.IsNullOrEmpty(AlamatBox.Text) ||
                string.IsNullOrEmpty(KapasitasBox.Text))
            {
                errorMessage = "Semua field harus diisi.";
                return false;
            }

            if (!int.TryParse(HargaBox.Text, out int hargaKos) || hargaKos < 1000000)
            {
                errorMessage = "Harga harus berupa angka dan minimal Rp. 1.000.000.";
                return false;
            }

            if (!int.TryParse(KapasitasBox.Text, out int kapasitas) || kapasitas < 10)
            {
                errorMessage = "Kapasitas harus berupa angka dan minimal 10.";
                return false;
            }

            return true;
        }

        private Kos CreateKosFromInput()
        {
            return new Kos
            {
                Nama = NamaKosBox.Text,
                Harga = int.Parse(HargaBox.Text),
                Alamat = AlamatBox.Text,
                Kapasitas = int.Parse(KapasitasBox.Text),
                Status = KosStatus.RentsStatus.AVAIL,
                Penyewa = new List<string>()
            };
        }
    }
}
