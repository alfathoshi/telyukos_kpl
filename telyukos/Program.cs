using System;
using telyukos;

class Program
{
    static void Main(string[] args)
    {
        ReservasiKost reservasi = new ReservasiKost(); // Membuat objek ReservasiKos

        while (true) // Loop utama program
        {
             Console.Clear(); // Membersihkan layar

            switch (reservasi.currentState) // Menentukan aksi berdasarkan state saat ini
            {
                case ReservasiKost.ReservasiState.START:
                    Console.WriteLine("===== RESERVASI KOS =====");
                    Console.WriteLine("Tekan Enter untuk memulai...");
                    Console.ReadLine();
                    reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.MULAI);
                    break;

                case ReservasiKost.ReservasiState.LIHAT_INFORMASI_KOS:
                    reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.MELIHAT_KOS);
                    break;

                case ReservasiKost.ReservasiState.PILIH_KOS:
                    Console.Write("Pilih Kos: ");
                    string chooseKos = Console.ReadLine();

                    switch (chooseKos)
                    {
                        case "1":
                            Console.WriteLine("Anda memilih Kos Mawar");
                            reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        case "2":
                            Console.WriteLine("Anda memilih Kos Melati");
                            reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        case "3":
                            Console.WriteLine("Anda memilih Kos Semuanya Indah");
                            reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.PILIH_RESERVASI);
                            break;
                        default:
                            Console.WriteLine("Pilihan tidak valid.");
                            reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.BACK);
                            Console.ReadLine();
                            break;
                    }
                    break;

                case ReservasiKost.ReservasiState.RESERVASI:
                    reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.MENGISI_DATA);
                    break;

                case ReservasiKost.ReservasiState.DAFTAR_RESERVASI:
                    // Simulasi proses approval/penolakan reservasi penyewa 
                    int randomApproval = new Random().Next(0, 2); // 0: Ditolak, 1: Diterima

                    if (randomApproval == 0)
                    {
                        reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.DAFTAR_DITOLAK);
                    }
                    else
                    {
                        reservasi.ActiveTrigger(ReservasiKost.ReservasiTrigger.DAFTAR_DITERIMA);
                    }
                    break;

                case ReservasiKost.ReservasiState.RESERVASI_BERHASIL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiKost.ReservasiState.START;
                    break;

                case ReservasiKost.ReservasiState.RESERVASI_GAGAL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiKost.ReservasiState.START;
                    break;
            }
        }
    }
}
