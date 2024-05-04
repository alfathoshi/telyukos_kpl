using PenyewaKos;
using System;
using telyukos;
using static PenyewaKos.ReservasiKos;
using static telyukos.RentStatus;
using System.Reflection.Emit;
using telyukos_library.Menu;
using telyukos;
using static telyukos.Akun;
using telyukos_library.Menu.MainMenu;
using telyukos_library.Searching;

class Program
{
    static void Main(string[] args)
    {
        RentsStatus rent1 = RentsStatus.Status1;
        RentsStatus rent2 = RentsStatus.Status2;
        
        string status1 = getRentStatus(RentsStatus.Status1);
        string status2 = getRentStatus(RentsStatus.Status2);
        
        ReservasiKos reservasi = new ReservasiKos(); // Membuat objek ReservasiKos

                    a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                    Console.WriteLine("Selesai Isi Data :)");
                    Console.WriteLine();
                    Console.WriteLine("1. Login");
                    Console.WriteLine("2. Batal");
                    Console.Write("Pilih: ");
                    string Pilih2 = Console.ReadLine();
                    if (Pilih2 == "1")
                    {
                        a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA);
                        break;
                        
                        //int idx = SequentialSearch<string>.Search(usn, usernameLogin);
                        //int idx1 = SequentialSearch<string>.Search(pw, passwordLogin);
                        /*if (idx != -1 && idx1 != -1)
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITERIMA);
                        } 
                        else
                        {
                            a.ActiveTrigger(AkunTrigger.LOGIN_DITOLAK);
                        }*/
                    }
                    else if (Pilih2 == "2")
                    {
                        a.ActiveTrigger(AkunTrigger.BATAL);
                        Console.WriteLine("Batal Login...");
                    }
                }
                else if (Pilih1 == "2")
                {
                    a.ActiveTrigger(AkunTrigger.PILIH_PENYEWA);
                    Console.WriteLine("Isi Data Login");
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine();

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
                        a.ActiveTrigger(AkunTrigger.BATAL);
                    }

                }
                else if (Pilih3 == "2")
                {
                    a.ActiveTrigger(AkunTrigger.PILIH_PENYEWA);
                    Console.WriteLine("Isi Data Registrasi"); //Data user belum bisa kesimpen
                    Console.Write("Username: ");
                    string username = Console.ReadLine();
                    Console.Write("Password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine();
                    a.ActiveTrigger(AkunTrigger.MENGISI_DATA);
                    Console.WriteLine("Selesai Isi Data :)");
                    Console.WriteLine();

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


