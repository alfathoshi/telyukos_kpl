using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    public class SewaState
    {
        public enum ReservasiState {LIHAT_KOS, PILIH_KOS, RESERVASI, RESERVASI_BERHASIL, RESERVASI_CANCEL }
        public enum ReservasiTrigger { PILIH_KOS, KONFIRMASI, CANCEL }

        public ReservasiState currentState = ReservasiState.LIHAT_KOS;
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
            new Transition(ReservasiState.LIHAT_KOS,ReservasiTrigger.PILIH_KOS,ReservasiState.RESERVASI),
            new Transition(ReservasiState.RESERVASI,ReservasiTrigger.KONFIRMASI,ReservasiState.RESERVASI_BERHASIL),
            new Transition(ReservasiState.RESERVASI,ReservasiTrigger.CANCEL,ReservasiState.RESERVASI_CANCEL),

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
