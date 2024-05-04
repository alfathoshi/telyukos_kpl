
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



internal class Program
{

    public static void Main(string[] args)
    {

        Akun a = new Akun();
        Role role = new Role();
        a.ActiveTrigger(AkunTrigger.TULIS_START);
        menu tampilan = new menu();

        Console.Write("Masukkan Pilihan : ");
        int INPUT = Convert.ToInt32(Console.ReadLine());
        stateAkun stateAwal;

        while (INPUT !=  0)
        {
            if (INPUT == 1)
            {
                stateAwal = stateAkun.LOGIN;
            }
            else
            {
                stateAwal = stateAkun.REGISTRASI;
            }

            switch (stateAwal)
            {
                case stateAkun.LOGIN:
                    a.ActiveTrigger(AkunTrigger.PILIH_LOGIN);
                    Console.WriteLine("###     -------- Login --------     ###");
                    Console.WriteLine();
                    Console.WriteLine("Login as : ");
                    Console.WriteLine("0. Pemilik Kos");
                    Console.WriteLine("1. Penyewa Kos");
                    Console.WriteLine("2. Keluar");
                    Console.Write("Pilih: ");
                    int Pilih1 = Convert.ToInt32(Console.ReadLine());
                    Debug.Assert(Pilih1 == 0|| Pilih1 == 1, "Role Selain diatas tersebut tidak tersedia");


                    if (Pilih1 != 0)
                    {
                        a.ActiveTrigger(AkunTrigger.PILIH_PEMILIK);
                        Console.WriteLine("Isi Data Login");
                        Console.Write("Username: ");
                        string username = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();
                        Console.WriteLine();

                        a.ActiveTrigger(AkunTrigger.MENGISI_DATA);

                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih2 = Console.ReadLine();

                        if (Pilih2 == "1")
                        {
                            Console.WriteLine("test");
                            Debug.Assert(username == "budi" && password == "doremi", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(username != null && password != null, "Username & Password tidak boleh kosong");
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA_PEMILIK);
                            Console.WriteLine("test");

                            if (username != "budi" && password != "doremi")
                            {
                                a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                            }
                        }
                        else if (Pilih2 == "2")
                        {
                            tampilan.authPage();
                        }
                    }
                    if (Pilih1 == 1)
                    {
                        a.ActiveTrigger(AkunTrigger.PILIH_PENYEWA);
                        Console.WriteLine("Isi Data Login");
                        Console.Write("Username: ");
                        string usernamep = Console.ReadLine();
                        Console.Write("Password: ");
                        string passwordp = Console.ReadLine();
                        Console.WriteLine();

                        a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();
                        Console.WriteLine("1. Login");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih2 = Console.ReadLine();

                        if (Pilih2 == "1")
                        {
                            Debug.Assert(usernamep == "joko" && passwordp == "ganteng", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(usernamep != null && passwordp != null, "Username & Password tidak boleh kosong");
                            if (usernamep == "joko" && passwordp == "ganteng")
                            {
                                a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA_PENYEWA);
                            }
                            else if (usernamep != "joko" && passwordp != "ganteng") ;
                            {
                                a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                            }
                        }
                        else if (Pilih2 == "2")
                        {
                            Console.WriteLine();
                        }
                    }
                    break;

                case stateAkun.REGISTRASI:
                    a.ActiveTrigger(AkunTrigger.PILIH_REGIS);
                    Console.WriteLine("###     -------- Registrasi --------     ###");
                    Console.WriteLine();
                    Console.WriteLine("Regist as : ");
                    Console.WriteLine("1. Pemilik Kos");
                    Console.WriteLine("2. Penyewa Kos");
                    Console.WriteLine("0. Keluar");
                    Console.Write("Pilih: ");
                    string Pilih3 = Console.ReadLine();
                    Debug.Assert(Pilih3 == "pemilik" || Pilih3 == "penyewa", "Role Selain diatas tersebut tidak tersedia");

                    if (Pilih3 == "pemilik")
                    {
                        a.ActiveTrigger(AkunTrigger.PILIH_PEMILIK);
                        Console.WriteLine("Isi Data Registrasi");
                        Console.Write("Username: ");
                        string usernamePemilik = Console.ReadLine();
                        Console.Write("Password: ");
                        string passwordPemilik = Console.ReadLine();
                        Console.WriteLine();

                        a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                        Console.WriteLine("Selesai Isi Data :)");
                        Console.WriteLine();

                        Console.WriteLine("1. Buat Akun");
                        Console.WriteLine("2. Batal");
                        Console.Write("Pilih: ");
                        string Pilih4 = Console.ReadLine();

                        if (Pilih4 == "1")
                        {
                            Debug.Assert(usernamePemilik == "budi" && passwordPemilik == "doremi", "Username dan Password harus sesuai dengan saat regis");
                            Debug.Assert(usernamePemilik != null && passwordPemilik != null, "Username & Password tidak boleh kosong");
                            if (usernamePemilik == "budi" && passwordPemilik == "doremi")
                            {
                                a.ActiveTrigger(AkunTrigger.REGISTER_BERHASIL);
                                tampilan.ownerMainPage();
                            }
                            else
                            {
                                a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                            }
                        }
                        else if (Pilih4 == "2")
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
                
                   
                  /*  a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                    Console.WriteLine("Selesai Isi Data :)");
                    Console.WriteLine();

                    Console.WriteLine("1. Buat Akun");
                    Console.WriteLine("2. Batal");
                    Console.Write("Pilih: ");
                    string Pilih4 = Console.ReadLine();
                    if (Pilih4 == "1")
                    {
                        a.ActiveTrigger(AkunTrigger.REGISTER_BERHASIL);
                    }
                    else if (Pilih4 == "2")
                    {
                        a.ActiveTrigger(AkunTrigger.BATAL);
                    }

                }
                else if (Pilih3 == "2")
                {
                    a.ActiveTrigger(AkunTrigger.PILIH_PENYEWA);
                    Console.WriteLine("Isi Data Registrasi");
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine();
                    a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                    Console.WriteLine("Selesai Isi Data :)");
                    Console.WriteLine();

                    Console.WriteLine("1. Buat Akun");
                    Console.WriteLine("2. Batal");
                    Console.Write("Pilih: ");
                    string Pilih4 = Console.ReadLine();
                    if (Pilih4 == "1")
                    {
                        a.ActiveTrigger(AkunTrigger.REGISTER_BERHASIL);
                    }
                    else if (Pilih4 == "2")
                    {
                        a.ActiveTrigger(AkunTrigger.BATAL);
                    }
                }
                else if (Pilih3 == "0")
                {
                    a.ActiveTrigger(AkunTrigger.BATAL); Console.WriteLine("Batal Registrasi..."); //Masih error
                }

            }
            else if (Pilih == "0")
            {
                a.ActiveTrigger(AkunTrigger.BATAL);  //Masih error
            }
        }

    }*/