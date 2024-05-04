
using System.Reflection.Emit;
using telyukos_library.Menu;
using telyukos;
using static telyukos.Akun;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Searching;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using telyukos_library.Menu.PemilikKos;
using System.ComponentModel.Design;
using telyukos;




internal class Program
{

    public static void Main(string[] args)
    {

        bool login = false;
        Role role = new Role();
        AkunRegisPemilik a = new AkunRegisPemilik();
        a.ActiveTrigger(AkunRegisPemilik.AkunTrigger.TULIS_START);
        AkunRegisPenyewa d = new AkunRegisPenyewa();
        d.ActiveTrigger(AkunRegisPenyewa.AkunTrigger.TULIS_START);
        AkunLoginPemilik b = new AkunLoginPemilik();
        b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.TULIS_START);
        AkunLoginPenyewa c = new AkunLoginPenyewa();
        c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.TULIS_START);
        menu tampilan = new menu();
        Akun e = new Akun();
        e.ActiveTrigger(AkunTrigger.TULIS_START);

        Console.Write("Masukkan Pilihan : ");
        int INPUT = Convert.ToInt32(Console.ReadLine());
        AkunLoginPemilik.StatePemilik stateAkhir = AkunLoginPemilik.StatePemilik.START;
        AkunRegisPemilik.StatePemilik stateAwal = AkunRegisPemilik.StatePemilik.START;




        while (INPUT != 0)
        {
            if (INPUT == 1)
            {
                stateAwal = AkunRegisPemilik.StatePemilik.REGISTRASI;
            }
            else if (INPUT == 2)
            {
                stateAkhir = AkunLoginPemilik.StatePemilik.LOGIN;

            }


            switch (stateAkhir)
            {
                case AkunLoginPemilik.StatePemilik.LOGIN:
                    b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.PILIH_LOGIN);
                    Console.WriteLine("###     -------- Login --------     ###");
                    Console.WriteLine();


                        b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Isi Data Login");
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih2 = Console.ReadLine();


                        if (Pilih2 == "1")
                        {

                            Role.getRole(Role.Roles.Role2).ToString();
                            Debug.Assert(username == "budi" && password == "doremi" || username == "joko" && password == "ganteng", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(username != null && password != null, "Username & Password tidak boleh kosong");
                        if (username == "budi" && password == "doremi")
                        {
                            b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.LOGIN_DITERIMA);
                            string input = Console.ReadLine();
                            while (input != "0")
                            {
                                if (input == "1")
                                {
                                    Console.WriteLine("berhasil ditambahkan");
                                    Console.WriteLine("Kembali? (tulis back)");
                                    string back = Console.ReadLine();
                                    if (back == "back")
                                    {
                                        b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.LOGIN_DITERIMA);
                                    }
                                    input = Console.ReadLine();
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("===== DAFTAR KOS =====");
                                    Console.WriteLine("1.) Kos Mawar [Jl.Damai No.1] [Rp 1.000.000/bulan] - ");
                                    Console.WriteLine("2.) Kos Melati [Jl.Peace No.1] [Rp 2.000.000/bulan] - ");
                                    Console.WriteLine("3.) Kos Semuanya Indah [Jl.Salam No.1] [Rp 3.000.000/bulan] - ");
                                    Console.WriteLine("Kembali? (tulis back)");
                                    string back = Console.ReadLine();
                                    if (back == "back")
                                    {
                                        b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.LOGIN_DITERIMA);
                                    }
                                    input = Console.ReadLine();
                                }

                            }
                            tampilan.authPage();
                        }else if(username == "joko" && password == "ganteng")
                        {
                            c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.LOGIN_DITERIMA);
                            string input = Console.ReadLine();
                            while (input != "0")
                            {
                                if (input == "1")
                                {
                                    Console.WriteLine("berhasil ditambahkan");
                                    Console.WriteLine("Kembali? (tulis back)");
                                    string back = Console.ReadLine();
                                    if (back == "back")
                                    {
                                        c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.LOGIN_DITERIMA);
                                    }
                                    input = Console.ReadLine();
                                }
                                else if (input == "2")
                                {
                                    Console.WriteLine("===== DAFTAR KOS =====");
                                    Console.WriteLine("1.) Kos Mawar [Jl.Damai No.1] [Rp 1.000.000/bulan] - ");
                                    Console.WriteLine("2.) Kos Melati [Jl.Peace No.1] [Rp 2.000.000/bulan] - ");
                                    Console.WriteLine("3.) Kos Semuanya Indah [Jl.Salam No.1] [Rp 3.000.000/bulan] - ");
                                    Console.WriteLine("Kembali? (tulis back)");
                                    string back = Console.ReadLine();
                                    if (back == "back")
                                    {
                                        c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.LOGIN_DITERIMA);
                                    }
                                    input = Console.ReadLine();
                                }

                            }
                            tampilan.authPage();
                        }

                        if (username != "budi" && password != "doremi")
                            {
                                b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.LOGIN_DITOLAK);
                            }
                        }
                        else if (Pilih2 == "2")
                        {
                            tampilan.authPage();
                        }

       
                        /*Role.getRole(Role.Roles.Role1).ToString();
                        c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.PILIH_LOGIN);
                        Console.WriteLine("###     -------- Login --------     ###");
                        Console.WriteLine();

                        c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Isi Data Login");
                        Console.Write("Username: ");
                        string usernamep = Console.ReadLine();
                        Console.Write("Password: ");
                        string passwordp = Console.ReadLine();
                        Console.WriteLine();

                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih3 = Console.ReadLine();

                        if (Pilih3 == "1")
                        {
                            Debug.Assert(usernamep == "joko" && passwordp == "ganteng", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(usernamep != null && passwordp != null, "Username & Password tidak boleh kosong");
                            if (usernamep == "joko" && passwordp == "ganteng")
                            {
                                c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.LOGIN_DITERIMA);
                                string input = Console.ReadLine();
                            }
                            else if (usernamep != "joko" && passwordp != "ganteng") ;
                            {
                                c.ActiveTrigger(AkunLoginPenyewa.AkunTrigger.LOGIN_DITOLAK);
                            }
                        }
                        else if (Pilih3 == "2")
                        {
                            Console.WriteLine();
                        }
                */
                    break;
            }

            switch (stateAwal)
            {
                case AkunRegisPemilik.StatePemilik.REGISTRASI:
                    a.ActiveTrigger(AkunRegisPemilik.AkunTrigger.PILIH_REGIS);
                    Console.WriteLine("###     -------- Registrasi --------     ###");
                    Console.WriteLine();
                    Console.WriteLine("Regist as : ");
                    Console.WriteLine("1. Pemilik Kos");
                    Console.WriteLine("2. Penyewa Kos");
                    Console.WriteLine("0. Keluar");
                    Console.Write("Pilih: ");
                    string Pilih4 = Console.ReadLine();
                    
                    Debug.Assert(Pilih4 == "PEMILIK" || Pilih4 == "PENYEWA", "Role Selain diatas tersebut tidak tersedia");

                    if (Pilih4 == Role.getRole(Role.Roles.Role2).ToString())
                    {
                        login = true;
                        a.ActiveTrigger(AkunRegisPemilik.AkunTrigger.PILIH_PEMILIK);
                        Console.WriteLine("Isi Data Registrasi");
                        Console.Write("Username: ");
                        string usernamePemilik = Console.ReadLine();
                        Console.Write("Password: ");
                        string passwordPemilik = Console.ReadLine();
                        Console.WriteLine();

                        a.ActiveTrigger(AkunRegisPemilik.AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();

                        Console.WriteLine("1. Buat Akun");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih5 = Console.ReadLine();

                        if (Pilih5 == "1")
                        {
                                a.ActiveTrigger(AkunRegisPemilik.AkunTrigger.REGISTER_BERHASIL);

                                b.ActiveTrigger(AkunLoginPemilik.AkunTrigger.PILIH_LOGIN);
                        }
                        else if (Pilih5 == "2")
                        {
                            tampilan.authPage();
                        }
                    }


                    if (Pilih4 == Role.getRole(Role.Roles.Role1).ToString())
                    {
                        login = true;
                        d.ActiveTrigger(AkunRegisPenyewa.AkunTrigger.PILIH_PENYEWA);
                        Console.WriteLine("Isi Data Registrasi");
                        Console.Write("Username: ");
                        string usernamePenyewa = Console.ReadLine();
                        Console.Write("Password: ");
                        string passwordPenyewa = Console.ReadLine();
                        Console.WriteLine();

                        d.ActiveTrigger(AkunRegisPenyewa.AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();

                        Console.WriteLine("1. Buat Akun");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih5 = Console.ReadLine();

                        if (Pilih5 == "1")
                        {
                            Debug.Assert(usernamePenyewa == "joko" && passwordPenyewa == "ganteng", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(usernamePenyewa != null && passwordPenyewa != null, "Username & Password tidak boleh kosong");
                            if (usernamePenyewa == "joko" && passwordPenyewa == "ganteng")
                            {
                                d.ActiveTrigger(AkunRegisPenyewa.AkunTrigger.REGISTER_BERHASIL);
                                tampilan.ownerMainPage();
                            }
                        }
                        else if (Pilih5 == "2")
                        {
                            tampilan.authPage();
                        }
                    }
                    break;
            }
        }
        Console.WriteLine("End Program");
    }

}

        

                
