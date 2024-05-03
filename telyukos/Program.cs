using System.Reflection.Emit;
using telyukos_library.Menu;
using telyukos;
using static telyukos.Akun;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Searching;
using PenyewaKos;


internal class Program
{
    static void Main(string[] args)
    {
        Akun a = new Akun();
      
        a.ActiveTrigger(AkunTrigger.TULIS_START);
        MainMenu mm = new MainMenu();
        string Pilih = Console.ReadLine();

        while (Pilih != "0")
        {
            if (Pilih == "1")
            {
                a.ActiveTrigger(AkunTrigger.PILIH_LOGIN);
                Console.WriteLine("###     -------- Login --------     ###");
                Console.WriteLine();
                Console.WriteLine("Login as : ");
                Console.WriteLine("1. Pemilik Kos");
                Console.WriteLine("2. Penyewa Kos");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih: ");
                string Pilih1 = Console.ReadLine();
                if (Pilih1 == "1")
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
                        a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA);
                        
                        //int idx = SequentialSearch<string>.Search(usn, usernameLogin);
                        //int idx1 = SequentialSearch<string>.Search(pw, passwordLogin);
                        /*if (idx != -1 && idx1 != -1)
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA);
                        } 
                        else
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                        }*/
                    }
                    else if (Pilih2 == "2")
                    {
                        a.ActiveTrigger(AkunTrigger.BATAL);
                        Console.WriteLine("Batal Login...");
                    }
                }
                else if (Pilih1 == "2")
                {
                    a.ActiveTrigger(AkunTrigger.PILIH_PENYEWA);
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
                        //int idx = SequentialSearch<string>.Search(usn, usernameLogin);
                        //int idx1 = SequentialSearch<string>.Search(pw, passwordLogin);
                        /*if (idx != -1 && idx1 != -1)
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA);
                        } 
                        else
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                        }*/
                    }
                    else if (Pilih2 == "2")
                    {
                        a.ActiveTrigger(AkunTrigger.BATAL);
                        Console.WriteLine("Batal Login...");
                    }
                }
                else if (Pilih1 == "0")
                {
                    a.ActiveTrigger(AkunTrigger.BATAL); Console.WriteLine("Batal Login..."); //Masih error
                }
            }
            else if (Pilih == "2")
            {
                a.ActiveTrigger(AkunTrigger.PILIH_REGIS);
                Console.WriteLine("###     -------- Registrasi --------     ###");
                Console.WriteLine();
                Console.WriteLine("Regist as : ");
                Console.WriteLine("1. Pemilik Kos");
                Console.WriteLine("2. Penyewa Kos");
                Console.WriteLine("0. Keluar");
                Console.Write("Pilih: ");
                string Pilih3 = Console.ReadLine();

                if (Pilih3 == "1")
                {
                    a.ActiveTrigger(AkunTrigger.PILIH_PEMILIK);
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

    }
}



