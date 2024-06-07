using API.Controllers;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using telyukos.Model;

namespace GUI
{
    public partial class MyKosPemilik : Form
    {
        private static Kos kos;
        private HttpClient httpClient;
        private static AuthController app = new AuthController();
     
        public MyKosPemilik(Kos kost)
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda
            kos = kost;

        }
        
      
    }
}
