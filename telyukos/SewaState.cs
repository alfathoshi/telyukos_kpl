using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    public class SewaState
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
    }
}
