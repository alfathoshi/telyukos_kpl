using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using telyukos;

internal class Program
{
    private static User loggedInUser;
    private static bool isLoggedIn = false;

    static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

        bool exit = false;
        while (!exit)
        {
            if (!isLoggedIn)
            {
                Console.WriteLine("Login or Register:");
                Console.WriteLine("1. Login");
                Console.WriteLine("2. Register");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Login
                        Console.Write("Email: ");
                        string email = Console.ReadLine();
                        Console.Write("Password: ");
                        string password = Console.ReadLine();

                        User loginUser = new User { Email = email, Password = password };
                        HttpResponseMessage responseLogin = await httpClient.PostAsJsonAsync("api/Auth/login", loginUser);

                        if (responseLogin.IsSuccessStatusCode)
                        {
                            string responseBodyLogin = await responseLogin.Content.ReadAsStringAsync();
                            Console.WriteLine("Response Login:");
                            Console.WriteLine(responseBodyLogin);

                            if (responseBodyLogin == "Login berhasil")
                            {
                                isLoggedIn = true;
                                Console.WriteLine("Login berhasil");
                            }
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

                        User newUser = new User { Email = newEmail, Password = newPassword };
                        HttpResponseMessage responseRegister = await httpClient.PostAsJsonAsync("api/Auth/register", newUser);
                        responseRegister.EnsureSuccessStatusCode();
                        string responseBodyRegister = await responseRegister.Content.ReadAsStringAsync();
                        Console.WriteLine("Response Register:");
                        Console.WriteLine(responseBodyRegister);
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
                Console.WriteLine();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Kos");
                Console.WriteLine("2. Update Kos");
                Console.WriteLine("3. Delete Kos");
                Console.WriteLine("4. Show All Kos");
                Console.WriteLine("0. Exit");
                Console.Write("Choice: ");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        // Tambah Kos
                        Console.Write("Nama Kos: ");
                        string namaKos = Console.ReadLine();
                        Console.Write("Harga Kos: ");
                        int hargaKos = int.Parse(Console.ReadLine());
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
                        Console.Write("Index Kos yang akan diupdate: ");
                        int indexUpdate = int.Parse(Console.ReadLine());
                        Console.Write("Nama Kos baru: ");
                        string namaKosUpdate = Console.ReadLine();
                        Console.Write("Harga Kos baru: ");
                        int hargaKosUpdate = int.Parse(Console.ReadLine());
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
                        Console.Write("Index Kos yang akan dihapus: ");
                        int indexDelete = int.Parse(Console.ReadLine());

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

            Console.WriteLine();
        }
    }

}
