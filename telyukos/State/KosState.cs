namespace telyukos.State
{
    internal class createKos
    {
        public enum kosState { BELUM_TERDAFTAR, DAFTAR, BERHASIL, GAGAL }
        public enum kosTrigger { MENGISI_DATA, DAFTAR_DITERIMA, DAFTAR_DITOLAK, DAFTAR_DICANCEL }

        public kosState currentState = kosState.BELUM_TERDAFTAR;
        public class Transition
        {
            public kosState stateAwal;
            public kosTrigger trigger;
            public kosState stateAkhir;
            public Transition(kosState stateAwal, kosTrigger trigger, kosState stateAkhir)
            {
                this.stateAwal = stateAwal;
                this.trigger = trigger;
                this.stateAkhir = stateAkhir;
            }
        }
        Transition[] transisi =
        {
            new Transition(kosState.BELUM_TERDAFTAR, kosTrigger.MENGISI_DATA, kosState.DAFTAR),
            new Transition(kosState.DAFTAR, kosTrigger.DAFTAR_DITERIMA, kosState.BERHASIL),
            new Transition(kosState.DAFTAR, kosTrigger.DAFTAR_DITOLAK, kosState.GAGAL),
            new Transition(kosState.BERHASIL, kosTrigger.DAFTAR_DICANCEL, kosState.BELUM_TERDAFTAR),
        };

        public kosState GetNextState(kosState stateAwal, kosTrigger trigger)
        {
            kosState stateAkhir = stateAwal;
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

        public void ActiveTrigger(kosTrigger trigger)
        {
            currentState = GetNextState(currentState, trigger);
            if (currentState == kosState.BERHASIL)
            {
                Console.WriteLine("Pendaftaran berhasil!");
            }
            else if (currentState == kosState.GAGAL)
            {
                Console.WriteLine("Pendaftaran gagal");
            }
            else if (currentState == kosState.BELUM_TERDAFTAR)
            {
                Console.WriteLine("Kos tidak terdaftar");
            }
        }
    }
}
