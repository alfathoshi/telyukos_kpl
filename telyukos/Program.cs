using PenyewaKos;
using System;
using telyukos;
using static PenyewaKos.ReservasiKos;
using static telyukos.RentStatus;

class Program
{
    static void Main(string[] args)
    {
        RentsStatus rent1 = RentsStatus.Status1;
        RentsStatus rent2 = RentsStatus.Status2;
        
        string status1 = getRentStatus(RentsStatus.Status1);
        string status2 = getRentStatus(RentsStatus.Status2);
        
        ReservasiKos reservasi = new ReservasiKos(); // Membuat objek ReservasiKos

        while (true) // Loop utama program
        {
            // Console.Clear(); // Membersihkan layar

            switch (reservasi.currentState) // Menentukan aksi berdasarkan state saat ini
            {
                case ReservasiState.START:
                    Console.WriteLine("===== RESERVASI KOS =====");
                    Console.WriteLine("Tekan Enter untuk memulai...");
                    Console.ReadLine();
                    reservasi.ActiveTrigger(ReservasiTrigger.MULAI);
                    break;

                case ReservasiState.LIHAT_INFORMASI_KOS:
                    reservasi.ActiveTrigger(ReservasiTrigger.MELIHAT_KOS);
                    break;

                case ReservasiState.PILIH_KOS:
                    Console.Write("Pilih Kos: ");
                    string chooseKos = Console.ReadLine();

                    switch (chooseKos)
                    {
                        case "1":
                            Console.WriteLine("===== Kos Mawar =====");
                            Console.WriteLine("> Fasilitas : Kasur, Meja, Kursi, Kulkas");
                            Console.WriteLine("> Semua Kamar " + status1);
                            Console.WriteLine("> 5 Kamar Telah " + status2);
                            reservasi.ActiveTrigger(ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        case "2":
                            Console.WriteLine("===== Kos Melati =====");
                            Console.WriteLine("> Fasilitas : Kasur, Meja, Kursi");
                            Console.WriteLine("> Semua Kamar " + status1);
                            Console.WriteLine("> 1 Kamar Telah " + status2);
                            reservasi.ActiveTrigger(ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        case "3":
                            Console.WriteLine("===== Kos Semuanya Indah =====");
                            Console.WriteLine("Fasilitas : Kasur, Meja, Kursi, AC, Kulkas");
                            Console.WriteLine("> Semua Kamar " + status1);
                            Console.WriteLine("> 3 Kamar Telah " + status2);
                            reservasi.ActiveTrigger(ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            reservasi.ActiveTrigger(ReservasiTrigger.BACK);
                            Console.ReadLine();
                            break;          
                    }   
                    break;

                case ReservasiState.RESERVASI:
                    reservasi.ActiveTrigger(ReservasiTrigger.MENGISI_DATA);
                    break;

                case ReservasiState.DAFTAR_RESERVASI:
                    // Simulasi proses approval/penolakan reservasi penyewa 
                    int randomApproval = new Random().Next(0, 2); // 0: Ditolak, 1: Diterima

                    if (randomApproval == 0)
                    {
                        reservasi.ActiveTrigger(ReservasiTrigger.DAFTAR_DITOLAK);
                    }
                    else
                    {
                        reservasi.ActiveTrigger(ReservasiTrigger.DAFTAR_DITERIMA);
                    }
                    break;

                case ReservasiState.RESERVASI_BERHASIL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiState.START;
                    break;

                case ReservasiState.RESERVASI_GAGAL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiState.START;
                    break;
            }
        }
    }
}


