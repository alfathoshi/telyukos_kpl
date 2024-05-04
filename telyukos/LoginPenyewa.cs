using System;
using System.Diagnostics.CodeAnalysis;
using telyukos_library.Menu.MainMenu;
using static telyukos.Akun;


namespace telyukos
{
    internal class AkunLoginPenyewa
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
        menu tampilan = new menu();
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
                tampilan.renterMainPage();
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



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static telyukos.Akun;
using telyukos;

namespace telyukos
{
    internal class AkunLoginPenyewa
    {
        public enum LoginPenyewaState {LOGIN,SUBMITLOG,HOME_PAGE_PENYEWA,GAGAL_LOGIN,KELUAR}
        public enum LoginPenyewaTrigger { MENGISI_DATA,LOGIN_DITERIMA_PENYEWA,LOGIN_DITOLAK,BATAL}

        class Transition
        {
            public LoginPenyewaState StateAwal;
            public LoginPenyewaTrigger Trigger;
            public LoginPenyewaState StateAkhir;


            public Transition(LoginPenyewaState stateAwal, LoginPenyewaTrigger trigger, LoginPenyewaState stateAkhir)


            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {
            new Transition(LoginPenyewaState.LOGIN, LoginPenyewaTrigger.MENGISI_DATA, LoginPenyewaState.SUBMITLOG),
            new Transition(LoginPenyewaState.SUBMITLOG, LoginPenyewaTrigger.LOGIN_DITERIMA_PENYEWA, LoginPenyewaState.HOME_PAGE_PENYEWA),
            new Transition(LoginPenyewaState.SUBMITLOG, LoginPenyewaTrigger.LOGIN_DITOLAK, LoginPenyewaState.GAGAL_LOGIN),
            new Transition(LoginPenyewaState.LOGIN, LoginPenyewaTrigger.BATAL, LoginPenyewaState.KELUAR),
        };

        public LoginPenyewaState currentState = LoginPenyewaState.LOGIN;

        public LoginPenyewaState getNextState(LoginPenyewaState StateAwal, LoginPenyewaTrigger trigger)

        {
            LoginPenyewaState StateAkhir = StateAwal;
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

            public void ActiveTrigger(LoginPenyewaTrigger Trigger)
            {
                currentState = getNextState(currentState, Trigger);


            }


        }
    }
*/