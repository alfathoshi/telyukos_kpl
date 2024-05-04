using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using telyukos_library.Searching;
using telyukos_library.Common;
using System.Reflection.Emit;
<<<<<<< HEAD
using telyukos_library.Sorting;
using telyukos_library;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Menu.LoginMenu;
﻿using System.Net.Http.Json;
using telyukos;
using telyukos_library.Menu;
using telyukos_library.Searching;
=======
>>>>>>> parent of 7610afb (implements static method)

internal class Program
{
    private static bool isLoggedIn = false;
    private static User Akun;

    static async Task Main(string[] args)
    {
<<<<<<< HEAD
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

        bool exit = false;
        while (!exit)
        {
            Menu _menu = new Menu();
            if (!isLoggedIn)
            {
                _menu.header();

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        // Login
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        User loginUser = new User { Email = email, Password = password, Role = "" };
                        HttpResponseMessage responseLogin = await httpClient.PostAsJsonAsync("api/Auth/login", loginUser);

                        Console.WriteLine();
                        if (responseLogin.IsSuccessStatusCode)
                        {
                            HttpResponseMessage responseGetUser = await httpClient.GetAsync("api/Auth/" + email);
                            responseGetUser.EnsureSuccessStatusCode();
                            User user = await responseGetUser.Content.ReadFromJsonAsync<User>();

                            string responseBodyLogin = await responseLogin.Content.ReadAsStringAsync();
                            isLoggedIn = true;
                            Akun = user;
                            Console.WriteLine("Login berhasil");

                        }
                        else if (responseLogin.StatusCode == System.Net.HttpStatusCode.BadRequest || responseLogin.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            Console.WriteLine("Email / Password tidak sesuai");
                        }
                        else
                        {
                            // Handle other status codes
                            Console.WriteLine("Failed to login: " + responseLogin.StatusCode);
                        }
                        break;

                    case "2":
                        // Register
                        Console.Write("Email: ");
                        string newEmail = Console.ReadLine();
                        Console.Write("Password: ");
                        string newPassword = Console.ReadLine();
                        Console.Write("Role (penyewa/pemilik): ");
                        string role = Console.ReadLine();

                        User newUser = new User { Email = newEmail, Password = newPassword, Role = role };
                        HttpResponseMessage responseRegister = await httpClient.PostAsJsonAsync("api/Auth/register", newUser);

                        if (responseRegister.IsSuccessStatusCode)
                        {
                            string responseBodyRegister = await responseRegister.Content.ReadAsStringAsync();
                            Console.WriteLine("Response Register:");
                            Console.WriteLine(responseBodyRegister);
                        }
                        else if (responseRegister.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            string errorMessage = await responseRegister.Content.ReadAsStringAsync();
                            Console.WriteLine("Failed to register: " + errorMessage);
                        }
                        else
                        {
                            string errorMessage = await responseRegister.Content.ReadAsStringAsync();
                            if (errorMessage.Contains("Email sudah terdaftar"))
                            {
                                Console.WriteLine("Email sudah terdaftar");
                            }
                            else
                            {
                                Console.WriteLine("Failed to register: " + responseRegister.StatusCode);
                            }
                        }
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {

                if (Akun.Role == "penyewa")
                {
                    _menu.mainManuRenter();
                    string menuChoice = Console.ReadLine();
                    Console.WriteLine();

                    switch (menuChoice)
                    {
                        case "1":
                            HttpResponseMessage responseGetAll = await httpClient.GetAsync("api/Kos");
                            responseGetAll.EnsureSuccessStatusCode();
                            Kos[] allKos = await responseGetAll.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            allKos = allKos.OrderBy(k => k.Id).ToArray();

                            Console.WriteLine("Data Kos:");
                            foreach (var kos in allKos)
                            {
                                Console.WriteLine($"Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }
                            _menu.chooseKosMenu();
                            string choice = Console.ReadLine();
                            if (choice == "1")
                            {
                                Kos kosRent = new Kos();
                                Console.WriteLine("Silahkan tulis nama kos");
                                Console.Write("Kos: ");
                                string namakos = Console.ReadLine();
                                foreach (var kos in allKos)
                                {
                                    if (kos.Nama == namakos)
                                        kosRent = kos;
                                }
                                HttpResponseMessage responseRent = await httpClient.PutAsJsonAsync("api/Auth/user", kosRent);
                                responseRent.EnsureSuccessStatusCode();
                                Console.WriteLine();
                                Console.WriteLine("Reservasi Kos Berhasil");
                                Console.WriteLine("Silahkan selesaikan pembayaran");
                            }
                            break;
                        case "2":
                            Console.WriteLine("Cari Kos");
                            Console.WriteLine("Silahkan tulis nama kos");
                            Console.Write("Kos: ");
                            string namaKos = Console.ReadLine();
                            break;
                        case "3":
                            Console.WriteLine("My Kos");

                            Console.WriteLine("Data Kos:");
                            foreach (var kos in Akun.Kos)
                            {
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }
                            break;
                        case "4":
                            isLoggedIn = false; break;
                        case "5":
                            Environment.Exit(0); break;
                    }
                }
                else
                {
                    _menu.mainMenuOwner();


                    string menuChoice = Console.ReadLine();
                    Console.WriteLine();

                    switch (menuChoice)
                    {
                        case "1":
                            _menu.uploadKos();
                            // Tambah Kos
                            Console.Write("Nama Kos: ");
                            string namaKos = Console.ReadLine();

                            int hargaKos;
                            bool isHargaValid = false;
                            do
                            {
                                Console.Write("Harga Kos: ");
                                string hargaKosInput = Console.ReadLine();
                                if (int.TryParse(hargaKosInput, out hargaKos))
                                {
                                    isHargaValid = true;
                                }
                                else
                                {
                                    Console.WriteLine("Input harga tidak valid. Silakan masukkan angka.");
                                }
                            } while (!isHargaValid);

                            Console.Write("Alamat Kos: ");
                            string alamatKos = Console.ReadLine();

                            Kos newKos = new Kos { Nama = namaKos, Harga = hargaKos, Alamat = alamatKos };
                            HttpResponseMessage responsePost = await httpClient.PostAsJsonAsync("api/Kos", newKos);
                            responsePost.EnsureSuccessStatusCode();
                            string responseBodyPost = await responsePost.Content.ReadAsStringAsync();
                            Console.WriteLine("Response POST:");
                            Console.WriteLine(responseBodyPost);
                            break;


                        case "2":
                            // Update Kos
                            int indexUpdate;
                            bool isIndexValid;
                            do
                            {
                                Console.Write("Index Kos yang akan diupdate: ");
                                string inputIndexUpdate = Console.ReadLine();
                                isIndexValid = int.TryParse(inputIndexUpdate, out indexUpdate);
                                if (!isIndexValid)
                                {
                                    Console.WriteLine("Index Kos harus berupa angka. Silakan coba lagi.");
                                }
                            } while (!isIndexValid);

                            Console.Write("Nama Kos baru: ");
                            string namaKosUpdate = Console.ReadLine();
                            int hargaKosUpdate;
                            bool isHargaValid_UPDATE;
                            do
                            {
                                Console.Write("Harga Kos baru: ");
                                string inputHargaKosUpdate = Console.ReadLine();
                                isHargaValid_UPDATE = int.TryParse(inputHargaKosUpdate, out hargaKosUpdate);
                                if (!isHargaValid_UPDATE)
                                {
                                    Console.WriteLine("Harga Kos harus berupa angka. Silakan coba lagi.");
                                }
                            } while (!isHargaValid_UPDATE);

                            Console.Write("Alamat Kos baru: ");
                            string alamatKosUpdate = Console.ReadLine();

                            Kos updatedKos = new Kos { Nama = namaKosUpdate, Harga = hargaKosUpdate, Alamat = alamatKosUpdate };
                            HttpResponseMessage responsePut = await httpClient.PutAsJsonAsync($"api/Kos/{indexUpdate}", updatedKos);
                            responsePut.EnsureSuccessStatusCode();
                            string responseBodyPut = await responsePut.Content.ReadAsStringAsync();
                            Console.WriteLine("Response PUT:");
                            Console.WriteLine(responseBodyPut);
                            break;


                        case "3":
                            // Hapus Kos

                            //GET DULU
                            HttpResponseMessage ambil = await httpClient.GetAsync("api/Kos");
                            ambil.EnsureSuccessStatusCode();
                            Kos[] kosAda = await ambil.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            kosAda = kosAda.OrderBy(k => k.Id).ToArray();

                            Console.WriteLine("Data Kos:");
                            foreach (var kos in kosAda)
                            {
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }

                            int indexDelete;
                            bool isIndexValid_DEL;
                            do
                            {
                                Console.Write("Pilih ID kos yang akan dihapus: ");
                                string inputIndexDelete = Console.ReadLine();
                                isIndexValid_DEL = int.TryParse(inputIndexDelete, out indexDelete);
                                if (!isIndexValid_DEL)
                                {
                                    Console.WriteLine("ID harus berupa angka. Silakan coba lagi.");
                                }
                            } while (!isIndexValid_DEL);

                            HttpResponseMessage responseDelete = await httpClient.DeleteAsync($"api/Kos/{indexDelete}");
                            responseDelete.EnsureSuccessStatusCode();
                            string responseBodyDelete = await responseDelete.Content.ReadAsStringAsync();
                            Console.WriteLine("Response DELETE:");
                            Console.WriteLine(responseBodyDelete);
                            break;



                        case "4":
                            // Tampilkan Semua Kos
                            HttpResponseMessage responseGetAll = await httpClient.GetAsync("api/Kos");
                            responseGetAll.EnsureSuccessStatusCode();
                            Kos[] allKos = await responseGetAll.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            allKos = allKos.OrderBy(k => k.Id).ToArray();

                            Console.WriteLine("Data Kos:");
                            foreach (var kos in allKos)
                            {
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }
                            break;
                        case "5":
                            isLoggedIn = false; break;

                        case "0":
                            exit = true;
                            break;

                        default:
                            Console.WriteLine("Pilihan tidak sesuai.");
                            break;
                    }
                }

            }

            Console.WriteLine();
        }
    }

}
=======
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


        // ========== Tutorial make generate ID
        int numberOfIDs = 20; // Jumlah ID yang ingin dihasilkan

        Console.WriteLine("Generated IDs:");

        for (int i = 0; i < numberOfIDs; i++)
        {
            string id = RandomIntegerGenerator.GenerateID();
            Console.WriteLine(id);
        }

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

    // buat class yang mau diparsing duluu
    public class Mahasiswa
    {
        public int NIM;
        public string nama;
        public string alamat;
    }

}
>>>>>>> parent of 7610afb (implements static method)
