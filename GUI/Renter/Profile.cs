using System.Net.Http.Json;
using GUI.Owner;
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

        private async void EditButtonPenyewa_Click(object sender, EventArgs e)
        {
            string newEmail = EditEmail.Text;
            string newPassword = Akun.Password;
            string roleLama = Akun.Role;

            // Buat objek User untuk mengubah password dan email.
            User user = new User { Email = newEmail, Password = newPassword, Role = roleLama };

            // Buat permintaan API untuk mengubah password dan email.
            HttpResponseMessage response = await httpClient.PutAsJsonAsync("api/Auth/update-profile/", user);

            //kondisi jika profile berhasil diubah.
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Profile Berhasil Diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Akun = user;

                // Close the current form and open a new instance with updated user data
                var parentForm = this.FindForm(); // Find the parent form
                if (parentForm != null)
                {
                    parentForm.Close(); // Close the parent form
                }

                // Open a new instance of the form with the updated user data
                RenterHome renterHome = new RenterHome(Akun);
                renterHome.Show();
            }
            //kondisi jika profile email saat login harus sesuai dengan saat sign up , agar dapat masuk kedalam profile 
            else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                MessageBox.Show("Email tidak valid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //kondisi jika password yang diubah tidak valid.
            else
            {
                MessageBox.Show("Gagal mengubah password: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Akun = user;
            LoadUserProfilePenyewa();
        }

        private void changePass_Click(object sender, EventArgs e)
        {
            ForgotPassword updatePass = new ForgotPassword();
            updatePass.Show();
        }
    }
}