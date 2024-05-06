using System.Net.Http.Json;
using telyukos;
using telyukos_library.Menu;
using telyukos_library.Searching;
using telyukos_library.Common;
using System;
using telyukos_library.Contract;

internal class Program
{
    private static bool isLoggedIn = false;
    private static User Akun;

    static async Task Main(string[] args)
    {
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
                            ResetConsole.Reset();
                            Console.WriteLine("Login berhasil");

                        }
                        else if (responseLogin.StatusCode == System.Net.HttpStatusCode.BadRequest || responseLogin.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            Console.WriteLine("Email / Password tidak sesuai");
                            ResetConsole.Reset();
                        }
                        else
                        {
                            // Handle other status codes
                            Console.WriteLine("Failed to login: " + responseLogin.StatusCode);
                            ResetConsole.Reset();
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
                            ResetConsole.Reset();
                            Console.WriteLine("Response Register:");
                            Console.WriteLine(responseBodyRegister);
                        }
                        else if (responseRegister.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            string errorMessage = await responseRegister.Content.ReadAsStringAsync();
                            ResetConsole.Reset();
                            Console.WriteLine("Failed to register: " + errorMessage);
                        }
                        else
                        {
                            string errorMessage = await responseRegister.Content.ReadAsStringAsync();
                            if (errorMessage.Contains("Email sudah terdaftar"))
                            {
                                ResetConsole.Reset();
                                Console.WriteLine("Email sudah terdaftar");
                            }
                            else
                            {
                                ResetConsole.Reset();
                                Console.WriteLine("Failed to register: " + responseRegister.StatusCode);
                            }
                        }
                        break;

                    case "0":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        ResetConsole.Reset();
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
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
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
                                ResetConsole.Reset();
                                Console.WriteLine("Reservasi Kos Berhasil");
                                Console.WriteLine("Silahkan selesaikan pembayaran");
                            }
                            break;
                        case "2":
                            HttpResponseMessage res = await httpClient.GetAsync("api/Kos");
                            res.EnsureSuccessStatusCode();
                            Kos[] findKos = await res.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            findKos = findKos.OrderBy(k => k.Id).ToArray();
                            Console.WriteLine("Cari Kos");
                            Console.WriteLine("Silahkan tulis nama kos");
                            Console.Write("Kos: ");
                            string namaKos = Console.ReadLine();
                            //Console.WriteLine(SequentialSearch<Kos>.Search(findKos, new Kos { Nama = namaKos }));

                            ResetConsole.Reset();
                            Kos cariKos = SearchKos.Search(findKos, k => k.Nama.Equals(namaKos));
                            if (cariKos != null)
                            {
                                Console.WriteLine($"Kos dengan nama '{namaKos}' ditemukan.");
                                Console.WriteLine($"ID: {cariKos.Id}");
                                Console.WriteLine($"Harga: {cariKos.Harga}");
                                Console.WriteLine($"Alamat: {cariKos.Alamat}");
                            }

                            Console.WriteLine();
                            Console.WriteLine("Silahkan pilih kos untuk reservasi (masukkan ID kos):");
                            int selectedId;
                            if (!int.TryParse(Console.ReadLine(), out selectedId))
                            {
                                Console.WriteLine($"Kos dengan nama '{namaKos}' tidak ditemukan.");
                            }


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
                            //Filter kos
                            HttpResponseMessage resp = await httpClient.GetAsync("api/Kos");
                            resp.EnsureSuccessStatusCode();
                            Kos[] filterKos = await resp.Content.ReadFromJsonAsync<Kos[]>();
                            static IEnumerable<Kos> FilterKosByPrice(Kos[] kosList, int minPrice, int maxPrice)
                            {
                                return kosList.Where(k => k.Harga >= minPrice && k.Harga <= maxPrice);
                            }

                            Console.WriteLine("Filter Kos Berdasarkan Rentang Harga");
                            int minPrice;
                            bool validInputMinPrice = false;
                            do
                            {
                                Console.Write("Masukkan harga minimum: ");
                                minPrice = Convert.ToInt32(Console.ReadLine());

                                // Memeriksa apakah harga minimum memenuhi kontrak
                                validInputMinPrice = FilterContract.CheckContract(minPrice, 100000, 15000000);

                                if (!validInputMinPrice)
                                {
                                    Console.WriteLine("Input tidak sesuai kontrak. Harga minimal harus lebih dari atau sama dengan Rp. 100.000");
                                }
                            } while (!validInputMinPrice);

                            int maxPrice;
                            bool validInputMaxPrice = false;
                            do
                            {
                                Console.Write("Masukkan harga maksimum: ");
                                maxPrice = Convert.ToInt32(Console.ReadLine());

                                // Memeriksa apakah harga maksimum memenuhi kontrak
                                validInputMaxPrice = FilterContract.CheckContract(maxPrice, 100000, 15000000);

                                if (!validInputMaxPrice)
                                {
                                    Console.WriteLine("Input tidak sesuai kontrak. Harga maksimal harus kurang dari atau sama dengan Rp. 15.000.000");
                                }
                            } while (!validInputMaxPrice);

                            var filteredKos = FilterKosByPrice(filterKos, minPrice, maxPrice);

                            if (filteredKos.Any())
                            {
                                Console.WriteLine($"Kos dengan harga antara {minPrice} dan {maxPrice} ditemukan:");
                                foreach (var kos in filteredKos)
                                {
                                    Console.WriteLine($"ID: {kos.Id},  Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Tidak ada kos dengan harga antara {minPrice} dan {maxPrice} ditemukan.");
                            }

                            break;
                        case "5":
                            isLoggedIn = false; break;
                        case "6":
                            Environment.Exit(0); break;
                    }
                }
                else
                {
                    _menu.mainMenuOwner();


                    string menuChoice = Console.ReadLine();
                    Console.WriteLine();

                    //Pemilik Kos

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
                            ResetConsole.Reset();
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
                            ResetConsole.Reset();
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
                            ResetConsole.Reset();
                            break;



                        case "4":
                            // Tampilkan Semua Kos
                            HttpResponseMessage responseGetAll = await httpClient.GetAsync("api/Kos");
                            responseGetAll.EnsureSuccessStatusCode();
                            Kos[] allKos = await responseGetAll.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            allKos = allKos.OrderBy(k => k.Id).ToArray();

                            ResetConsole.Reset();
                            Console.WriteLine("Data Kos:");
                            foreach (var kos in allKos)
                            {
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }
                            break;
                        case "5":
                            isLoggedIn = false;
                            ResetConsole.Reset();
                            break;

                        case "0":
                            exit = true;
                            ResetConsole.Reset();
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
