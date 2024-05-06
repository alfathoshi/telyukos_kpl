using System;
using telyukos;
class Program
{
    static void Main(string[] args)
    {
        ReservasiKos reservasi = new ReservasiKos(); // Membuat objek ReservasiKos
       

        while (true) // Loop utama program
        {
            switch (reservasi.currentState) // Menentukan aksi berdasarkan state saat ini
            {
                case ReservasiKos.ReservasiState.START:
                    Console.WriteLine("===== RESERVASI KOS =====");
                    Console.WriteLine("Tekan Enter untuk memulai...");
                    Console.ReadLine();
                    reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.MULAI);
                    break;

                case ReservasiKos.ReservasiState.LIHAT_INFORMASI_KOS:
                    reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.MELIHAT_KOS);
                    break;

                case ReservasiKos.ReservasiState.PILIH_KOS:
                    Console.Write("Pilih Kos: ");
                    string chooseKos = Console.ReadLine();

                    switch (chooseKos)
                    {
                        case "1":
                            Console.WriteLine("==== Anda memilih Kos Mawar ====");
                            Console.WriteLine(" Fasilitas: ");
                            Console.WriteLine("> Kamar Mandi ");
                            Console.WriteLine("> Dapur ");
                            Console.WriteLine("> Kamar Tidur ");
                            Console.WriteLine("1.) Reservasi");
                            Console.WriteLine("2.) Batal");
                            string choose = Console.ReadLine();
                            if (choose == "1")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.PILIH_RESERVASI);
                            }
                            else if (choose == "2")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.BACK);
                            }
                            break;
                        case "2":
                            Console.WriteLine("==== Anda memilih Kos Melati ====");
                            Console.WriteLine(" Fasilitas: ");
                            Console.WriteLine("> Kamar Mandi ");
                            Console.WriteLine("> Dapur ");
                            Console.WriteLine("> Kamar Tidur ");
                            Console.WriteLine("1.) Reservasi");
                            Console.WriteLine("2.) Batal");
                            string choose1 = Console.ReadLine();
                            if (choose1 == "1")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.PILIH_RESERVASI);
                            }
                            else if (choose1 == "2")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.BACK);
                            }
                            break;
                        case "3":
                            Console.WriteLine("==== Anda memilih Kos Semuanya Indah ====");
                            Console.WriteLine(" Fasilitas: ");
                            Console.WriteLine("> Kamar Mandi ");
                            Console.WriteLine("> Dapur ");
                            Console.WriteLine("> Kamar Tidur ");
                            Console.WriteLine("1.) Reservasi");
                            Console.WriteLine("2.) Batal");
                            string choose2 = Console.ReadLine();
                            if (choose2 == "1")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.PILIH_RESERVASI);
                            }
                            else if (choose2 == "2")
                            {
                                reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.BACK);
                            }
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.BACK);
                            Console.ReadLine();
                            break;
                    }
                    break;

                case ReservasiKos.ReservasiState.RESERVASI:
                    reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.MENGISI_DATA);
                    break;


                case ReservasiKos.ReservasiState.DAFTAR_RESERVASI:
                    reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.DAFTAR_DITERIMA);
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiKos.ReservasiState.START;
                    break;

             
            }
        }
    }
}