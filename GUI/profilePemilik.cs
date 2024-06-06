using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Http.Json;
using telyukos.Model;
using telyukos.State;
using API.Controllers;
using System.Text.Json;
using Newtonsoft.Json;
using System.Formats.Asn1;

namespace GUI
{
    public partial class profilePemilik : Form
    {
        private static User Akun;
        private HttpClient httpClient;
        private static AuthController app = new AuthController();
        public profilePemilik(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            Akun = user;

        }

        private async void profilePemilik_Load(object sender, EventArgs e)
        {
            await LoadUserProfile();
        }



        public async Task LoadUserProfile()
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

                // Buat permintaan GET untuk mengambil profil user
                var response = await httpClient.GetAsync($"api/Auth/" + userEmail);

                // Periksa status respons
                if (response.IsSuccessStatusCode)
                {
                    // Baca dan deserialisasi data user
                    var responseData = await response.Content.ReadAsStringAsync();
                    var user = JsonConvert.DeserializeObject<User>(responseData);

                    // Cek apakah data user tidak null
                    if (user != null)
                    {
                        EmailText.Text = user.Email;
                        PasswordText.Text = user.Password;
                        Role.Text = user.Role;
                        UsernameLabel.Text = user.Email;
                    }
                    else
                    {
                        MessageBox.Show("User profile not found.");
                    }
                }
                else
                {
                    MessageBox.Show("User profile not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading profile: {ex.Message}");
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void EditButton_Click(object sender, EventArgs e)
        {

            string newEmail = EmailText.Text;
            string newPassword = PasswordText.Text;
            string Rolelama = Role.Text;

            // Buat objek User untuk mengubah password dan email
            var user = new { Email = newEmail, Password = newPassword, Role = Rolelama };

            // Buat permintaan PUT untuk mengubah password dan email
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/Auth/update-profile/", user);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Profile Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
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



        private void UsernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void RoleLabel_Click(object sender, EventArgs e)
        {

        }

        private void EmailText_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
