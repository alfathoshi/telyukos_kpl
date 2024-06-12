using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Net.Http.Json;
using telyukos.Model;

namespace GUI.Renter
{
    public partial class Profile : UserControl
    {
        private static User Akun;
        private HttpClient httpClient;
        public Profile(User user)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            Akun = user;
            LoadUserProfilePenyewa();
        }

        public void LoadUserProfilePenyewa()
        {
            EditEmail.Text = Akun.Email;
            RoleLabel.Text = Akun.Role;
            if (Akun.Email.Contains("@gmail.com"))
            {
                UsernameLabelPasien.Text = Akun.Email.Substring(0, Akun.Email.IndexOf('@')).Trim();
            }
            else
            {
                UsernameLabelPasien.Text = Akun.Email;
            }
        }
        private async void EditButtonPasien_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoleLabelPasien_Click(object sender, EventArgs e)
        {

        }

        private async void EditButtonPenyewa_Click(object sender, EventArgs e)
        {
            string newEmail = EditEmail.Text;

            // Buat objek User untuk mengubah password dan email
            var user = new { Email = newEmail, Password = "", Role = "" };

            // Buat permintaan API untuk mengubah password dan email.
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/Auth/update-profile/", user);

            //kondisi jika profile berhasil diubah.
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Email berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //kondisi jika profile email saat login harus sesuai dengan saat sign up , agar dapat masuk kedalam profile 
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Email tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            ForgotPassword updatePass = new ForgotPassword();
            updatePass.Show();
        }
    }
}
