using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using telyukos;
using telyukos_library.Menu;

internal class Program
{
    private static bool isLoggedIn = false;
    private static string roleAkun = "";

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

                        if (responseLogin.IsSuccessStatusCode)
                        {
                            HttpResponseMessage responseGetUser = await httpClient.GetAsync("api/Auth/" + email);
                            responseGetUser.EnsureSuccessStatusCode();
                            User user = await responseGetUser.Content.ReadFromJsonAsync<User>();

                            string responseBodyLogin = await responseLogin.Content.ReadAsStringAsync();
                            isLoggedIn = true;
                            roleAkun = user.Role;
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
                if (roleAkun == "penyewa")
                {
                    Console.WriteLine("penyewa");
                    break;
                }
                else
                {
                    _menu.mainMenuOwner();


                    string menuChoice = Console.ReadLine();

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
