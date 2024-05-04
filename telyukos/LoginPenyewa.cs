using System;
using telyukos_library.Menu.MainMenu;
using static telyukos.Akun;


namespace telyukos
{
    internal class LoginPenyewa
    {

        public enum StatePenyewa { START, LOGIN, KELUAR, SUBMITLOG, MENU_AWAL, HOME_PAGE_PENYEWA, GAGAL_LOGIN }

        public enum AkunTrigger { TULIS_START, BATAL, MENGISI_DATA, PILIH_LOGIN, LOGIN_DITERIMA, LOGIN_DITOLAK }

        class Transition
        {
            public StatePenyewa StateAwal;
            public AkunTrigger Trigger;
            public StatePenyewa StateAkhir;

            public Transition(StatePenyewa stateAwal, AkunTrigger trigger, StatePenyewa stateAkhir)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(StatePenyewa.START,AkunTrigger.TULIS_START ,StatePenyewa.MENU_AWAL),
            new Transition(StatePenyewa.MENU_AWAL,AkunTrigger.PILIH_LOGIN, StatePenyewa.LOGIN),
            new Transition(StatePenyewa.MENU_AWAL,AkunTrigger.BATAL, StatePenyewa.KELUAR),

            //Regis
            new Transition(StatePenyewa.LOGIN,AkunTrigger.MENGISI_DATA,StatePenyewa.SUBMITLOG),
            new Transition(StatePenyewa.SUBMITLOG,AkunTrigger.LOGIN_DITERIMA,StatePenyewa.HOME_PAGE_PENYEWA),
            new Transition(StatePenyewa.SUBMITLOG,AkunTrigger.LOGIN_DITOLAK,StatePenyewa.GAGAL_LOGIN),
            new Transition(StatePenyewa.LOGIN,AkunTrigger.BATAL,StatePenyewa.MENU_AWAL),
        };

        public StatePenyewa currentState = StatePenyewa.START;
        public StatePenyewa getNextState(StatePenyewa StateAwal, AkunTrigger trigger)
        {
            StatePenyewa StateAkhir = StateAwal;
            for (int i = 0; i < transitions.Length; i++)
            {
                Transition perubahan = transitions[i];
                if (StateAwal == perubahan.StateAwal && trigger == perubahan.Trigger)
                {
                    StateAkhir = perubahan.StateAkhir;
                }
            }
            return StateAkhir;
        }
        public void ActiveTrigger(AkunTrigger Trigger)
        {
            currentState = getNextState(currentState, Trigger);

            if (currentState == StatePenyewa.START)
            {
                Console.WriteLine("=== LOGIN ===");

            }
            else if (currentState == StatePenyewa.LOGIN)
            {
                Console.WriteLine("=== Silakan Login ===");
            }
            else if (currentState == StatePenyewa.HOME_PAGE_PENYEWA)
            {
                Console.WriteLine("==========PENYEWA==========");
                Console.WriteLine("1.Lihat Daftar Kos ");
                Console.WriteLine("2.Informasi Kos");
                Console.WriteLine("3.Reservasi Kos");
                Console.WriteLine("0.Kembali");
            }
            else if (currentState == StatePenyewa.KELUAR)
            {
                Console.WriteLine("--- Batal Login ---");
            }
            else if (currentState == StatePenyewa.GAGAL_LOGIN)
            {
                Console.WriteLine("--- Data Salah ---");
            }
            else if (currentState == StatePenyewa.MENU_AWAL)
            {
                MainMenu m = new MainMenu();
            }

        }
    }

}
