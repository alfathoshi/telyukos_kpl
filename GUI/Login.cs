using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using telyukos.Model;
using telyukos.State;

namespace GUI
{
    public partial class Login : Form
    {
        private static User Akun;
        private HttpClient httpClient;
        private static AuthState app = new AuthState();

        public Login()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

            // Add event handler for password TextBox
            textBox2.TextChanged += new EventHandler(this.textBox2_TextChanged);

            // Add event handler for login button
            button1.Click += new EventHandler(this.button1_Click);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            // Ambil email dan password dari textbox
            string email = textBox1.Text;
            string password = textBox2.Text;

            // Buat objek User untuk login
            User loginUser = new User { Email = email, Password = password, Role = "" };

            // Kirim permintaan POST untuk login
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/Auth/login", loginUser);

            // Periksa respons dari server
            if (response.IsSuccessStatusCode)
            {
                app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGIN_DITERIMA);

                // Dapatkan data user berdasarkan email
                response = await httpClient.GetAsync("api/Auth/" + email);
                response.EnsureSuccessStatusCode();

                // Deserialisasi data user
                User user = await response.Content.ReadFromJsonAsync<User>();

                // Tampilkan pesan sukses
                Akun = user;
                MessageBox.Show("Login berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //ntar pindah disini
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                // Tampilkan pesan error jika email atau password tidak sesuai
                MessageBox.Show("Email / Password tidak sesuai", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Tampilkan pesan error untuk status kode lain
                MessageBox.Show("Gagal login: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string password = textBox2.Text;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
            SignUp signUpGui = new SignUp();
            
            signUpGui.ShowDialog();

            Close();

        }
    }
}
