using System.Net.Http.Json;
using telyukos;

internal class Program
{
    static async Task Main(string[] args)
    {
        HttpClient httpClient = new HttpClient();
        httpClient.BaseAddress = new Uri("https://localhost:7126/"); // Sesuaikan dengan URL API Anda

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Tambah Kos");
            Console.WriteLine("2. Update Kos");
            Console.WriteLine("3. Hapus Kos");
            Console.WriteLine("4. Tampilkan Semua Kos");
            Console.WriteLine("0. Keluar");
            Console.Write("Pilihan Anda: ");
            string choice = Console.ReadLine();

            switch (choice)
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
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih lagi.");
                    break;
            }

            Console.WriteLine();
        }
    }

}

/*CRUD Pemilik Kos {
	Create Kos (Automata, Table Driven, RunCog, API)
	Read Kos (Library, API)
	Edit Kos (Automata, Table Driven, RunCog, API)
	Delete Kos (Automata, Table Driven, RunCog, API)
}*/
