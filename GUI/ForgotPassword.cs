using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        //todo
        //buat dia cek saja jika verification code (textbox1) bukan 1111, maka dia akan bilang kode verifikasi tidak sesuai. Jika 1111, maka ubah password yang ada di json (Akses controller API) sesuai dengan alamat email pada textbox2, ubahan password seperti yang di textbox3, jika email tidak ada di json maka bilang email tidak valid.

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
