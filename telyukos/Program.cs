using System;
using telyukos;
using static telyukos.Fasilitas;
class Program
{
    static void Main(string[] args)
    {
        ReservasiKos reservasi = new ReservasiKos(); // Membuat objek ReservasiKos
        string obj1 = getFacility(Facility.Objek1); string obj2 = getFacility(Facility.Objek2); string obj3 = getFacility(Facility.Objek3); string obj4 = getFacility(Facility.Objek4); string obj5 = getFacility(Facility.Objek5); string obj6 = getFacility(Facility.Objek6); string obj7 = getFacility(Facility.Objek7); string obj8 = getFacility(Facility.Objek8); string obj9 = getFacility(Facility.Objek9); string obj10 = getFacility(Facility.Objek10);


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
                            Console.WriteLine("> " + obj1);
                            Console.WriteLine("> " + obj7);
                            Console.WriteLine("> " + obj8);
                            Console.WriteLine("> " + obj9);
                            Console.WriteLine("> " + obj3);
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
                            Console.WriteLine("> " + obj2);
                            Console.WriteLine("> " + obj5);
                            Console.WriteLine("> " + obj1);
                            Console.WriteLine("> " + obj4);
                            Console.WriteLine("> " + obj3);
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
                            Console.WriteLine("> " + obj7);
                            Console.WriteLine("> " + obj8);
                            Console.WriteLine("> " + obj9);
                            Console.WriteLine("> " + obj10);
                            Console.WriteLine("> " + obj1);
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
                    // Simulasi proses approval/penolakan reservasi penyewa 
                    int randomApproval = new Random().Next(0, 2); // 0: Ditolak, 1: Diterima

                    if (randomApproval == 0)
                    {
                        reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.DAFTAR_DITOLAK);
                    }
                    else
                    {
                        reservasi.ActiveTrigger(ReservasiKos.ReservasiTrigger.DAFTAR_DITERIMA);
                    }
                    break;

                case ReservasiKos.ReservasiState.RESERVASI_BERHASIL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiKos.ReservasiState.START;
                    break;

                case ReservasiKos.ReservasiState.RESERVASI_GAGAL:
                    Console.WriteLine("Tekan Enter untuk kembali ke awal...");
                    Console.ReadLine();
                    reservasi.currentState = ReservasiKos.ReservasiState.START;
                    break;
            }
        }
    }
}
