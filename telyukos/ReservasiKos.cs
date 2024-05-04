using System;
using telyukos;
using System.Diagnostics;
using static telyukos.RentStatus;

namespace PenyewaKos

{
    internal class ReservasiKos
    {
        public enum ReservasiState { START, PILIH_KOS, RESERVASI, LIHAT_INFORMASI_KOS, DAFTAR_RESERVASI, RESERVASI_BERHASIL, RESERVASI_GAGAL }
        public enum ReservasiTrigger { MULAI, MELIHAT_KOS, MENGISI_DATA, BACK, DAFTAR_DITERIMA, DAFTAR_DITOLAK, PILIH_RESERVASI }

        public ReservasiState currentState = ReservasiState.START;
        public class Transition
        {
            public ReservasiState stateAwal;
            public ReservasiTrigger trigger;
            public ReservasiState stateAkhir;
            public Transition(ReservasiState stateAwal, ReservasiTrigger trigger, ReservasiState stateAkhir)
            {
                this.stateAwal = stateAwal;
                this.trigger = trigger;
                this.stateAkhir = stateAkhir;
            }
        }
        Transition[] transisi =
        {
            new Transition(ReservasiState.START, ReservasiTrigger.MULAI, ReservasiState.LIHAT_INFORMASI_KOS),
            new Transition(ReservasiState.LIHAT_INFORMASI_KOS,ReservasiTrigger.MELIHAT_KOS,ReservasiState.PILIH_KOS),
            new Transition(ReservasiState.PILIH_KOS,ReservasiTrigger.PILIH_RESERVASI,ReservasiState.RESERVASI),
            new Transition(ReservasiState.PILIH_KOS,ReservasiTrigger.BACK,ReservasiState.LIHAT_INFORMASI_KOS),
            new Transition(ReservasiState.RESERVASI,ReservasiTrigger.MENGISI_DATA,ReservasiState.DAFTAR_RESERVASI),
            new Transition(ReservasiState.DAFTAR_RESERVASI,ReservasiTrigger.DAFTAR_DITERIMA,ReservasiState.RESERVASI_BERHASIL),
            new Transition(ReservasiState.DAFTAR_RESERVASI,ReservasiTrigger.DAFTAR_DITOLAK,ReservasiState.RESERVASI_GAGAL),


     };

        public ReservasiState GetNextState(ReservasiState stateAwal, ReservasiTrigger trigger)
        {
            if (!Enum.IsDefined(typeof(ReservasiState), stateAwal))
            {
                throw new ArgumentException("State Awal Tidak Valid");
            }
            if (!Enum.IsDefined(typeof(ReservasiTrigger), trigger))
            {
                throw new ArgumentException("Trigger Tidak Valid");
            }
                ReservasiState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition perubahan = transisi[i];
                if (stateAwal == perubahan.stateAwal && trigger == perubahan.trigger)
                {
                    stateAkhir = perubahan.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(ReservasiTrigger trigger)
        {
            RentsStatus rent1 = RentsStatus.Status1;
            string status1 = getRentStatus(RentsStatus.Status1);
            

            currentState = GetNextState(currentState, trigger);
            Debug.Assert(currentState == GetNextState(currentState, trigger));
            if (currentState == ReservasiState.START)
            {
                Console.WriteLine("!Peringatan! Transisi tidak terjadi karena state awal dan akhir sama!");
            }
            else if (currentState == ReservasiState.RESERVASI)
            {
                Console.WriteLine("=====DAFTAR--RESERVASI=====");
                Console.Write("Nama Penyewa: ");
                string namaLengkap = Console.ReadLine();
                Console.Write("Nomor HP: ");
                string nomorHP = Console.ReadLine();
                Console.Write("Jenis Kelamin: ");
                string gender = Console.ReadLine();
                Console.Write("Jumlah Penyewa: ");
                string jumlahPenyewa = Console.ReadLine();
                Console.Write("Durasi Sewa: ");
                string duration = Console.ReadLine();
            }
            else if (currentState == ReservasiState.LIHAT_INFORMASI_KOS)
            {
                
                Console.WriteLine("===== DAFTAR KOS =====");
                Console.WriteLine("1.) Kos Mawar [Jl.Damai No.1] [Rp 1.000.000/bulan] - " + status1);
                Console.WriteLine("2.) Kos Melati [Jl.Peace No.1] [Rp 2.000.000/bulan] - " + status1);
                Console.WriteLine("3.) Kos Semuanya Indah [Jl.Salam No.1] [Rp 3.000.000/bulan] - " + status1);
            }
            else if (currentState == ReservasiState.RESERVASI_BERHASIL)
            {
                Console.WriteLine("RESERVASI BERHASIL!!");
            }
            else if (currentState == ReservasiState.RESERVASI_GAGAL)
            {
                Console.WriteLine("RESERVASI GAGAL!!");
            }
        }    
    }
}
