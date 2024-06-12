using System.Diagnostics;
using System.Net.Http.Json;
using telyukos;
using telyukos.Model;
using telyukos.State;
using telyukos_library.Contract;
using telyukos_library.Menu;
using telyukos_library.Searching;

class Program
{
    private static User Akun;
    private static AuthState app = new AuthState();
    private static SewaState sewa = new SewaState();
    static apiClient api = new apiClient();
    static HttpResponseMessage response;

    static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

        app.currentState = AuthState.State.START;

        while (app.currentState != AuthState.State.EXIT)
        {

            Menu _menu = new Menu();

            if (app.currentState != AuthState.State.LOGIN)
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
                        response = await httpClient.PostAsJsonAsync("api/Auth/login", loginUser);
                        Console.WriteLine();
                        if (response.IsSuccessStatusCode)
                        {
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGIN_DITERIMA);

                            response = await httpClient.GetAsync("api/Auth/" + email);
                            response.EnsureSuccessStatusCode();
                            User user = await response.Content.ReadFromJsonAsync<User>();

                            string responseBodyLogin = await response.Content.ReadAsStringAsync();
                            Akun = user;
                            Console.WriteLine("Login berhasil");

                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest || response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
                        {
                            Console.WriteLine("Email / Password tidak sesuai");
                        }
                        else
                        {
                            // Handle other status codes
                            Console.WriteLine("Failed to login: " + response.StatusCode);
                        }
                        break;

                    case "2":
                        // Register
                        Console.Write("Email: ");
                        string newEmail = Console.ReadLine();
                        Console.Write("Password: ");
                        string newPassword = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Role: \n1. Penyewa | 2. Pemilik \nPilih: ");
                        string role = Console.ReadLine();
                        Console.WriteLine();
                        if (role == "1")
                        {
                            role = Role.getRole(Role.RoleUser.RENTER);
                        }
                        else if (role == "2")
                        {
                            role = Role.getRole(Role.RoleUser.OWNER);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Choice");
                            
                        }

                        User newUser = new User { Email = newEmail, Password = newPassword, Role = role };
                        response = await httpClient.PostAsJsonAsync("api/Auth/register", newUser);


                        if (response.IsSuccessStatusCode)
                        {
                            string responseBodyRegister = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Response Register:");
                            Console.WriteLine(responseBodyRegister);
                        }
                        else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                        {
                            string errorMessage = await response.Content.ReadAsStringAsync();
                            Console.WriteLine("Failed to register: " + errorMessage);
                        }
                        else
                        {
                            string errorMessage = await response.Content.ReadAsStringAsync();
                            if (errorMessage.Contains("Email sudah terdaftar"))
                            {
                                Console.WriteLine("Email sudah terdaftar");
                            }
                            else
                            {
                                Console.WriteLine("Failed to register: " + response.StatusCode);
                            }
                        }
                        break;
                    case "0":
                        app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            else
            {
                if (Akun.Role == Role.getRole(Role.RoleUser.RENTER))
                {
                    _menu.mainManuRenter();
                    string menuChoice = Console.ReadLine();
                    Console.WriteLine();

                    switch (menuChoice)
                    {
                        case "1":
                            response = await httpClient.GetAsync("api/Kos");
                            response.EnsureSuccessStatusCode();
                            Kos[] allKos = await response.Content.ReadFromJsonAsync<Kos[]>();

                            if (allKos.Length == 0)
                            {
                                Console.WriteLine("Tidak ada kos untuk ditampilkan");
                            }
                            else
                            {
                                // Urutkan data berdasarkan ID
                                SelectionSort<Kos>.SortAscending(allKos, k => k.Id);


                                Console.WriteLine("Data Kos:");
                                foreach (var kos in allKos)
                                {
                                    Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}, Status: {kos.Status}");
                                }

                                Console.WriteLine();
                                Console.WriteLine("Silahkan pilih kos untuk reservasi (masukkan ID kos):");
                                int selectedId;
                                if (!int.TryParse(Console.ReadLine(), out selectedId))
                                {
                                    Console.WriteLine("Inputan tidak sesuai dengan ID kos manapun");
                                    break;
                                }

                                // Cari kos berdasarkan ID yang dipilih
                                Kos kosRent = allKos.FirstOrDefault(k => k.Id == selectedId);
                                if (kosRent == null)
                                {
                                    Console.WriteLine("Kos dengan ID tersebut tidak ditemukan");
                                    break;
                                }
                                else if (kosRent.Penyewa.Count() == kosRent.Kapasitas)
                                {
                                    Console.WriteLine("Kos sudah penuh");
                                    break;
                                }
                                sewa.currentState = SewaState.ReservasiState.RESERVASI;
                                Console.WriteLine();
                                Console.WriteLine($"Konfirmasi sewa kos: y/n");
                                Console.Write("Choice: ");
                                string choice = Console.ReadLine();

                                if (choice == "y")
                                {
                                    response = await httpClient.PutAsJsonAsync("api/Auth/" + Akun.Email, kosRent);
                                    if (response.IsSuccessStatusCode)
                                    {
                                        kosRent.Penyewa.Add(Akun.Email);
                                        if (kosRent.Penyewa.Count() == kosRent.Kapasitas)
                                        {
                                            kosRent.Status = KosStatus.RentsStatus.FULL;
                                        }
                                        Kos updatedKos = kosRent;
                                        response = await httpClient.PutAsJsonAsync($"api/Kos/{selectedId}", updatedKos);
                                        response.EnsureSuccessStatusCode();
                                        Console.WriteLine();
                                        sewa.ActiveTrigger(SewaState.ReservasiTrigger.KONFIRMASI);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Email sudah terdaftar");

                                    }
                                }
                                else if (choice == "n")
                                {
                                    sewa.ActiveTrigger(SewaState.ReservasiTrigger.CANCEL);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Choice");
                                }
                            }
                            break;
                        case "2":
                            response = await httpClient.GetAsync("api/Kos");
                            response.EnsureSuccessStatusCode();
                            Kos[] findKos = await response.Content.ReadFromJsonAsync<Kos[]>();

                            // Urutkan data berdasarkan ID
                            SelectionSort<Kos>.SortAscending(findKos, k => k.Id);

                            Console.WriteLine("Cari Kos");
                            Console.WriteLine("Silahkan tulis nama kos");
                            Console.Write("Kos: ");
                            string namaKos = Console.ReadLine();
                            Kos cariKos = SearchKos.Search(findKos, k => k.Nama.Equals(namaKos));
                            if (cariKos != null)
                            {
                                Console.WriteLine($"Kos dengan nama '{namaKos}' ditemukan.");
                                Console.WriteLine($"ID: {cariKos.Id}");
                                Console.WriteLine($"Harga: {cariKos.Harga}");
                                Console.WriteLine($"Alamat: {cariKos.Alamat}");
                            }
                            else
                            {
                                Console.WriteLine($"Kos dengan nama '{namaKos}' tidak ditemukan.");
                            }
                            Console.WriteLine();
                            Console.Write("Tap to back...");
                            Console.ReadLine();
                            break;
                        case "3":
                            response = await httpClient.GetAsync("api/Auth/" + Akun.Email);
                            response.EnsureSuccessStatusCode();
                            User user = await response.Content.ReadFromJsonAsync<User>();
                            Console.WriteLine("My Kos");
                            Console.WriteLine();
                            Console.WriteLine("Data Kos:");
                            foreach (var kos in user.Kos)
                            {
                                Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                            }
                            Console.WriteLine();
                            Console.Write("Tap to back...");
                            Console.ReadLine();
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
                            Console.WriteLine();
                            Console.Write("Tap to back...");
                            Console.ReadLine();
                            break;
                        case "5":
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGOUT);
                            ; break;

                        case "0":
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice"); break;
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
                            Console.Write("Kapasitas Kos: ");
                            int kapasitas = int.Parse(Console.ReadLine());

                            Kos newKos = new Kos { Nama = namaKos, Harga = hargaKos, Alamat = alamatKos, Kapasitas = kapasitas, Status = KosStatus.RentsStatus.AVAIL, Penyewa = new List<string>() };
                            await api.AddNewKos(httpClient, Akun, newKos);

                            break;
                        case "2":
                            // Update Kos
                            int indexUpdate;
                            bool isIndexValid;
                            await api.GetAndDisplayKos(httpClient);
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
                            Debug.Assert(namaKosUpdate != null, message: "Tidak boleh null");
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

                            Console.Write("Kapasitas Baru: ");
                            int cap = int.Parse(Console.ReadLine());

                            Kos updatedKos = new Kos { Nama = namaKosUpdate, Harga = hargaKosUpdate, Alamat = alamatKosUpdate, Kapasitas = cap };
                            HttpResponseMessage response = await httpClient.PutAsJsonAsync($"api/Kos/{indexUpdate}", updatedKos);
                            response.EnsureSuccessStatusCode();
                            string responseBodyPut = await response.Content.ReadAsStringAsync();
                            Console.WriteLine();
                            Console.WriteLine("Response PUT:");
                            Console.WriteLine(responseBodyPut);
                            break;


                        case "3":
                            // Hapus Kos
                            //GET DULU 
                            await api.GetAndDisplayKos(httpClient);

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
                            await api.DeleteKos(httpClient, indexDelete);
                            break;

                        case "4":
                            // Tampilkan Semua Kos
                            await api.GetAndDisplayKos(httpClient);
                            Console.WriteLine();
                            Console.Write("Tap to back...");
                            Console.ReadLine();
                            break;
                        case "5":
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.LOGOUT);
                            break;

                        case "0":
                            app.currentState = app.getNextState(app.currentState, AuthState.Trigger.CLOSE);
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
