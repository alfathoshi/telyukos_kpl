
﻿using System.Reflection.Emit;
using telyukos_library.Menu;
using telyukos;
using static telyukos.Akun;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Searching;
using PenyewaKos;

using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using telyukos_library.Searching;
using telyukos_library.Common;
using System.Reflection.Emit;
using telyukos_library.Sorting;
using telyukos_library;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Menu.PemilikKos;
using telyukos_library.Menu.LoginMenu;
using System;


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

=======

        //===============================================================
        //=                                                             =
        //=                                                             =
        //=                     Tutorial Make Library                   =
        //=           Silahkan uncomment tutorial yang mau dipake       =
        //=                                                             =
        //=                                                             =
        //===============================================================



        // ========== Tutorial make binary search nya ==========

        //int[] intArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        //double[] doubleArray = { 1.2, 3.4, 5.6, 7.8, 9.0, 10.1, 12.3, 14.5, 16.7, 18.9 };
        //string[] stringArray = { "apple", "banana", "cherry", "date", "grape", "kiwi", "mango" };

        //Console.WriteLine("Searching in intArray:");
        //Console.WriteLine("Index of 10: " + BinarySearch<int>.Search(intArray, 10));
        //Console.WriteLine("Index of 13: " + BinarySearch<int>.Search(intArray, 13));

        //Console.WriteLine("\nSearching in doubleArray:");
        //Console.WriteLine("Index of 10.1: " + BinarySearch<double>.Search(doubleArray, 10.1));
        //Console.WriteLine("Index of 11.0: " + BinarySearch<double>.Search(doubleArray, 11.0));

        //Console.WriteLine("\nSearching in stringArray:");
        //Console.WriteLine("Index of 'banana': " + BinarySearch<string>.Search(stringArray, "banana"));
        //Console.WriteLine("Index of 'lemon': " + BinarySearch<string>.Search(stringArray, "lemon"));


        // ========== Tutorial make Sequential Search nya ==========

        //int[] intArray = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        //double[] doubleArray = { 1.2, 3.4, 5.6, 7.8, 9.0, 10.1, 12.3, 14.5, 16.7, 18.9 };
        //string[] stringArray = { "apple", "banana", "cherry", "date", "grape", "kiwi", "mango" };

        //Console.WriteLine("Searching in intArray:");
        //Console.WriteLine("Index of 10: " + SequentialSearch<int>.Search(intArray, 10));
        //Console.WriteLine("Index of 13: " + SequentialSearch<int>.Search(intArray, 13));

        //Console.WriteLine("\nSearching in doubleArray:");
        //Console.WriteLine("Index of 10.1: " + SequentialSearch<double>.Search(doubleArray, 10.1));
        //Console.WriteLine("Index of 11.0: " + SequentialSearch<double>.Search(doubleArray, 11.0));

        //Console.WriteLine("\nSearching in stringArray:");
        //Console.WriteLine("Index of 'banana': " + SequentialSearch<string>.Search(stringArray, "banana"));
        //Console.WriteLine("Index of 'lemon': " + SequentialSearch<string>.Search(stringArray, "lemon"));


        // ========== Tutorial make generate ID ====================
        //int numberOfIDs = 20; // Jumlah ID yang ingin dihasilkan

        //Console.WriteLine("Generated IDs:");

        //for (int i = 0; i < numberOfIDs; i++)
        //{
        //    string id = RandomIntegerGenerator.GenerateID();
        //    Console.WriteLine(id);
        //}

        // =========== Tutorial make Selection Sort ================

        //int[] intArray = { 64, 25, 12, 22, 11 };
        //double[] doubleArray = { 1.3, 5.5, 0.7, 2.1, 3.8 };
        //string[] stringArray = { "banana", "apple", "orange", "grape", "kiwi" };

        //// Ascending sort
        //Console.WriteLine("Ascending Sort:");
        //SelectionSort<int>.SortAscending(intArray);
        //// Display array utk foreach, function nya ada dibawah, cek aja
        //DisplayArray(intArray);

        //SelectionSort<double>.SortAscending(doubleArray);
        //DisplayArray(doubleArray);

        //SelectionSort<string>.SortAscending(stringArray);
        //DisplayArray(stringArray);

        //// Descending sort
        //Console.WriteLine("\nDescending Sort:");
        //SelectionSort<int>.SortDescending(intArray);
        //DisplayArray(intArray);

        //SelectionSort<double>.SortDescending(doubleArray);
        //DisplayArray(doubleArray);

        //SelectionSort<string>.SortDescending(stringArray);
        //DisplayArray(stringArray);


        // ==================== Tutorial memakai library menu ========================

        // karena method di class nya memakai static, jadi g perlu dibuat objek
        // Langsung aja tulis Class.NamaMethod();

        // Contoh:
        PilihRole.Role();


        // ========== tutorial parsing pake library newtonsoft ==========
        //Mahasiswa objMhs = new Mahasiswa();

        //objMhs.NIM = 122011389;
        //objMhs.nama = "Alan";
        //objMhs.alamat = "Bandung";

        //// Serialisasi
        //string JsonOutpuMahasiswa = JsonConvert.SerializeObject(objMhs);
        //// pastiin letak folder nya sesuai, yg dibawah cmn contoh ya
        //File.WriteAllText("D://JSON/Mahasiswa.json", JsonOutpuMahasiswa);

        // Deserialisasi
        //string HasilBacaJson = File.ReadAllText("D://JSON/Mahasiswa.json");
        //// pastiin letak folder nya sesuai, yg dibawah cmn contoh ya
        //Mahasiswa MhsBaca = JsonConvert.DeserializeObject<Mahasiswa>(HasilBacaJson);

        //Console.WriteLine("======== Newtonsoft.Json ========");
        //Console.WriteLine("NIM: " + MhsBaca.NIM);
        //Console.WriteLine("Nama: " + MhsBaca.nama);
        //Console.WriteLine("Alamat: " + MhsBaca.alamat);

    }
}




    // buat class yang mau diparsing duluu
    public class Mahasiswa
    {
        public int NIM;
        public string nama;
        public string alamat;

    }

    //buat foreach
    public static void DisplayArray<T>(T[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

