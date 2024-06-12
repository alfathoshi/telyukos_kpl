using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;
using telyukos.Model;
using System.Linq;
using System.Drawing;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace GUI
{
    public partial class SignUp : Form
    {
        private HttpClient httpClient;

        public SignUp()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

            // Event handler for password textbox text changed
            textBoxPassword.TextChanged += TextBoxPassword_TextChanged;

            // Event handler for password textbox text changed
            textBoxEmail.TextChanged += textBoxEmail_TextChanged;
        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            string role = comboBoxRole.SelectedItem.ToString();

            // Validasi input email, password, dan role di sini jika diperlukan
            if (IsValidPassword(password) && IsValidEmail(email))
            {
                User newUser = new User { Email = email, Password = password, Role = role };
                HttpResponseMessage response = await httpClient.PostAsJsonAsync("api/Auth/register", newUser);

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Registrasi berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //ntar pindah
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Gagal melakukan registrasi: " + errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string errorMessage = await response.Content.ReadAsStringAsync();
                    if (errorMessage.Contains("Email sudah terdaftar"))
                    {
                        MessageBox.Show("Email sudah terdaftar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Gagal melakukan registrasi: " + response.StatusCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (!IsValidPassword(password))
            {
                MessageBox.Show("Gagal melakukan registrasi: Password tidak sesuai.");
            }
            else if (!IsValidEmail(email))
            {
                MessageBox.Show("Gagal melakukan registrasi: Email tidak sesuai.");
            }

        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            string password = textBoxPassword.Text;
            if (IsValidPassword(password))
            {
                labelPasswordCheck.Text = "Valid Password";
                labelPasswordCheck.ForeColor = Color.Green;
            }
            else
            {
                labelPasswordCheck.Text = "Password must include symbols and numbers";
                labelPasswordCheck.ForeColor = Color.Red;
            }
        }

        private bool IsValidPassword(string password)
        {
            return password.Any(char.IsDigit) && password.Any(ch => !char.IsLetterOrDigit(ch));
        }

        private bool IsValidEmail(string email)
        {
            return email.Contains("@gmail.com");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {
            Login loginGui = new Login();
            loginGui.ShowDialog();

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            if (IsValidEmail(email))
            {
                labelEmailCheck.Text = "Valid Email";
                labelEmailCheck.ForeColor = Color.Green;
            }
            else
            {
                labelEmailCheck.Text = "Email harus menggunakan domain";
                labelEmailCheck.ForeColor = Color.Red;
            }
        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}