using System;
using telyukos;

namespace telyukos
{
    internal class menu
    {
        public void header()
        {
            Console.WriteLine("###     -----------------     ###");
            Console.WriteLine("###         TelyuKos          ###");
            Console.WriteLine("###        Kelompok 3         ###");
            Console.WriteLine("###         KPL 2024          ###");
            Console.WriteLine("###     -----------------     ###");
        }

        public void authPage()
        {
            Console.WriteLine("###     -------- Login or Register --------     ###");
            Console.WriteLine();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("0. Keluar");
        }

        public void loginPage()
        {
            Console.WriteLine("###     -------- Login --------     ###");
            Console.WriteLine();
            Console.WriteLine("Login as : ");
            Console.WriteLine("1. Pemilik Kos");
            Console.WriteLine("2. Penyewa Kos");
            Console.WriteLine();
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("1. Login");
            Console.WriteLine("0. Keluar");
        }

        public void registerPage()
        {
            Console.WriteLine("###     -------- Login --------     ###");
            Console.WriteLine();
            Console.WriteLine("Register as : ");
            Console.WriteLine("1. Pemilik Kos");
            Console.WriteLine("2. Penyewa Kos");
            Console.WriteLine();
            Console.Write("Username : ");
            string username = Console.ReadLine();
            Console.Write("Password : ");
            string password = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("1. Buat Akun");
            Console.WriteLine("0. Keluar");
        }

        public void ownerMainPage()
        {
            Console.WriteLine("###     -------- Menu Utama --------     ###");
            Console.WriteLine();
            Console.WriteLine("1. Tambahkan Kos");
            Console.WriteLine("2. Lihat Data Kos");
            Console.WriteLine("0. Keluar");
        }

        public void renterMainPage()
        {
            Console.WriteLine("###     -------- Menu Utama --------     ###");
            Console.WriteLine();
            Console.WriteLine("1. Lihat Kos");
            Console.WriteLine("2. Cari Kos");
            Console.WriteLine("3. Riwayat Sewa");
            Console.WriteLine("0. Keluar");
        }
    }
}