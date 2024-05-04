﻿using System;
using telyukos;


namespace PenyewaKos

{
    internal class ReservasiKos
    {
        public enum ReservasiState { PILIH_KOS, RESERVASI, LIHAT_INFORMASI_KOS, DAFTAR_RESERVASI, RESERVASI_BERHASIL, RESERVASI_GAGAL }
        public enum ReservasiTrigger { MELIHAT_KOS, MENGISI_DATA, BACK, DAFTAR_DITERIMA, DAFTAR_DITOLAK, PILIH_RESERVASI }

        public ReservasiState currentState = ReservasiState.LIHAT_INFORMASI_KOS;
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
            new Transition(ReservasiState.LIHAT_INFORMASI_KOS,ReservasiTrigger.MELIHAT_KOS,ReservasiState.PILIH_KOS),
            new Transition(ReservasiState.PILIH_KOS,ReservasiTrigger.PILIH_RESERVASI,ReservasiState.RESERVASI),
            new Transition(ReservasiState.PILIH_KOS,ReservasiTrigger.BACK,ReservasiState.LIHAT_INFORMASI_KOS),
            new Transition(ReservasiState.RESERVASI,ReservasiTrigger.MENGISI_DATA,ReservasiState.DAFTAR_RESERVASI),
            new Transition(ReservasiState.DAFTAR_RESERVASI,ReservasiTrigger.DAFTAR_DITERIMA,ReservasiState.RESERVASI_BERHASIL),
            new Transition(ReservasiState.DAFTAR_RESERVASI,ReservasiTrigger.DAFTAR_DITOLAK,ReservasiState.RESERVASI_GAGAL),


     };

        public ReservasiState GetNextState(ReservasiState stateAwal, ReservasiTrigger trigger)
        {
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
            currentState = GetNextState(currentState, trigger);
            if (currentState == ReservasiState.DAFTAR_RESERVASI)
            {
                Console.WriteLine("=====DAFTAR--RESERVASI=====");
            }else if(currentState ==  ReservasiState.RESERVASI_BERHASIL)
            {
                Console.WriteLine("RESERVASI BERHASIL!!");
            }else if(currentState == ReservasiState.RESERVASI_GAGAL)
            {
                Console.WriteLine("RESERVASI GAGAL!!");
            }


        }

       
    }
}