using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ForgotPassword : Form
    {
        private HttpClient httpClient;

        public ForgotPassword()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
        }

        private async void buttonSubmit_Click(object sender, EventArgs e)
        {
            string verificationCode = textBoxVerificationCode.Text;
            string email = textBoxEmail.Text;
            string newPassword = textBoxNewPassword.Text;

            if (verificationCode != "1111")
            {
                MessageBox.Show("Kode verifikasi tidak sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Buat objek User untuk mengubah password
            var user = new { Email = email, Password = newPassword, Role = "" };

            // Buat permintaan PUT untuk mengubah password
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/Auth/change-password", user);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Password berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Email tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Gagal mengubah password: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }


    }
}
