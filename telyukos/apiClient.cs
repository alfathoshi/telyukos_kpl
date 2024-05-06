using System.Net;
using System.Net.Http.Json;
using telyukos.Model;
using telyukos_library.Searching;

namespace telyukos
{
    public class apiClient
    {
        private HttpResponseMessage resp;
        public async Task GetAndDisplayKos(HttpClient httpClient)
        {
            
            try
            {
                resp = await httpClient.GetAsync("api/Kos");
                resp.EnsureSuccessStatusCode();
                Kos[] kosAda = await resp.Content.ReadFromJsonAsync<Kos[]>();

                if (kosAda == null || kosAda.Length == 0)
                {
                    Console.WriteLine("Tidak ada data Kos.");
                }
                else
                {
                    // Urutkan data berdasarkan ID
                   SelectionSort<Kos>.SortAscending(kosAda, k => k.Id);

                    Console.WriteLine("Data Kos:");
                    foreach (var kos in kosAda)
                    {
                        Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}");
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Gagal mendapatkan data Kos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }


        public async Task DeleteKos(HttpClient httpClient, int indexDelete)
        {
            resp = await httpClient.DeleteAsync($"api/Kos/{indexDelete}");
            if (resp.IsSuccessStatusCode)
            {
                string responseBodyDelete = await resp.Content.ReadAsStringAsync();
                Console.WriteLine("Response DELETE:");
                Console.WriteLine(responseBodyDelete);
            }
            else if (resp.StatusCode == HttpStatusCode.NotFound)
            {
                Console.WriteLine("Kos tidak ditemukan");
            }
            else if (resp.StatusCode == HttpStatusCode.BadRequest)
            {
                Console.WriteLine("Permintaan tidak valid");
            }
            else
            {
                Console.WriteLine("Gagal menghapus kos: " + resp.StatusCode);
            }
        }

        public async Task ReserveKos(HttpClient httpClient)
        {
            try
            {
                resp = await httpClient.GetAsync("api/Kos");
                resp.EnsureSuccessStatusCode();
                Kos[] allKos = await resp.Content.ReadFromJsonAsync<Kos[]>();

                // Urutkan data berdasarkan ID
                SelectionSort<Kos>.SortAscending(allKos, k => k.Id);


                Console.WriteLine("Data Kos:");
                foreach (var kos in allKos)
                {
                    Console.WriteLine($"ID: {kos.Id}, Nama: {kos.Nama}, Harga: {kos.Harga}, Alamat: {kos.Alamat}, Status:");
                }

                Console.WriteLine();
                Console.WriteLine("Silahkan pilih kos untuk reservasi (masukkan ID kos):");
                int selectedId;
                if (!int.TryParse(Console.ReadLine(), out selectedId))
                {
                    Console.WriteLine("Inputan tidak sesuai dengan ID kos manapun");
                    return;
                }

                // Cari kos berdasarkan ID yang dipilih
                Kos kosRent = allKos.FirstOrDefault(k => k.Id == selectedId);
                if (kosRent == null)
                {
                    Console.WriteLine("Kos dengan ID tersebut tidak ditemukan");
                    return;
                }

                HttpResponseMessage responseRent = await httpClient.PutAsJsonAsync("api/Auth/user", kosRent);
                responseRent.EnsureSuccessStatusCode();
                Console.WriteLine();
                Console.WriteLine("Reservasi Kos Berhasil");
                Console.WriteLine("Silahkan selesaikan pembayaran");
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Gagal melakukan reservasi kos: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }

        public async Task AddNewKos(HttpClient httpClient, User Akun, Kos newKos)
        {
            try
            {
                resp = await httpClient.PostAsJsonAsync("api/Kos", newKos);
                resp.EnsureSuccessStatusCode();
                HttpResponseMessage responseRent = await httpClient.PutAsJsonAsync("api/Auth/" + Akun.Email, newKos);
                responseRent.EnsureSuccessStatusCode();
                string responseBodyPost = await resp.Content.ReadAsStringAsync();
                Console.WriteLine();
                Console.WriteLine("Response POST:");
                Console.WriteLine(responseBodyPost);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Gagal menambahkan Kos baru: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }
        }


    }
}