using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using telyukos_library.Searching;
using telyukos_library.Common;
using System.Reflection.Emit;

internal class Program
{
    private static void Main(string[] args)
    {
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