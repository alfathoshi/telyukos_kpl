using System;
using telyukos_library.Menu.MainMenu;
using static telyukos.Akun;


namespace telyukos
{
    internal class AkunLoginPemilik
    {

        public enum StatePemilik { START, LOGIN, KELUAR, SUBMITLOG, MENU_AWAL, HOME_PAGE_PEMILIK, GAGAL_LOGIN }

        public enum AkunTrigger { TULIS_START, BATAL, MENGISI_DATA, PILIH_LOGIN, LOGIN_DITERIMA, LOGIN_DITOLAK }

        class Transition
        {
            public StatePemilik StateAwal;
            public AkunTrigger Trigger;
            public StatePemilik StateAkhir;

            public Transition(StatePemilik stateAwal, AkunTrigger trigger, StatePemilik stateAkhir)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(StatePemilik.START,AkunTrigger.TULIS_START ,StatePemilik.MENU_AWAL),
            new Transition(StatePemilik.MENU_AWAL,AkunTrigger.PILIH_LOGIN, StatePemilik.LOGIN),
            new Transition(StatePemilik.MENU_AWAL,AkunTrigger.BATAL, StatePemilik.KELUAR),

            //Regis
            new Transition(StatePemilik.LOGIN,AkunTrigger.MENGISI_DATA,StatePemilik.SUBMITLOG),
            new Transition(StatePemilik.SUBMITLOG,AkunTrigger.LOGIN_DITERIMA,StatePemilik.HOME_PAGE_PEMILIK),
            new Transition(StatePemilik.SUBMITLOG,AkunTrigger.LOGIN_DITOLAK,StatePemilik.GAGAL_LOGIN),
            new Transition(StatePemilik.LOGIN,AkunTrigger.BATAL,StatePemilik.MENU_AWAL),
        };

        public StatePemilik currentState = StatePemilik.START;
        menu tampilan = new menu();
        public StatePemilik getNextState(StatePemilik StateAwal, AkunTrigger trigger)
        {
            StatePemilik StateAkhir = StateAwal;
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

            if (currentState == StatePemilik.START)
            {
                Console.WriteLine("=== LOGIN ===");

            }
            else if (currentState == StatePemilik.LOGIN)
            {
                Console.WriteLine("=== Silakan Login ===");
            }
            else if (currentState == StatePemilik.HOME_PAGE_PEMILIK)
            {
                tampilan.ownerMainPage();
            }
            else if (currentState == StatePemilik.KELUAR)
            {
                Console.WriteLine("--- Batal Login ---");
            }
            else if (currentState == StatePemilik.GAGAL_LOGIN)
            {
                Console.WriteLine("--- Data Salah ---");
            }
            else if (currentState == StatePemilik.MENU_AWAL)
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
    internal class AkunLoginPemilik
    {
        public enum LoginPemilikState { LOGIN, SUBMITLOG, HOME_PAGE_PEMILIK, GAGAL_LOGIN, KELUAR }
        public enum LoginPemilikTrigger { MENGISI_DATA, LOGIN_DITERIMA_PEMILIK, LOGIN_DITOLAK, BATAL }

        class Transition
        {
            public LoginPemilikState StateAwal;
            public LoginPemilikTrigger Trigger;
            public LoginPemilikState StateAkhir;


            public Transition(LoginPemilikState stateAwal, LoginPemilikTrigger trigger, LoginPemilikState stateAkhir)


            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(LoginPemilikState.LOGIN, LoginPemilikTrigger.MENGISI_DATA, LoginPemilikState.SUBMITLOG),
            new Transition(LoginPemilikState.SUBMITLOG, LoginPemilikTrigger.LOGIN_DITERIMA_PEMILIK, LoginPemilikState.HOME_PAGE_PEMILIK),
            new Transition(LoginPemilikState.SUBMITLOG, LoginPemilikTrigger.LOGIN_DITOLAK, LoginPemilikState.GAGAL_LOGIN),
            new Transition(LoginPemilikState.LOGIN, LoginPemilikTrigger.BATAL, LoginPemilikState.KELUAR),
        };

        public LoginPemilikState currentState = LoginPemilikState.LOGIN;

        public LoginPemilikState getNextState(LoginPemilikState StateAwal, LoginPemilikTrigger trigger)

        {
            LoginPemilikState StateAkhir = StateAwal;
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

        menu tampilan =  new menu();
        public void ActiveTrigger(LoginPemilikTrigger Trigger)
        {

            currentState = getNextState(currentState, Trigger);

            if(currentState == LoginPemilikState.HOME_PAGE_PEMILIK) 
            {
                Console.WriteLine("Selamat Datang Di Akun Pemilik");
            }
            else if(currentState == LoginPemilikState.GAGAL_LOGIN)
            {
                Console.WriteLine("                    LOGIN GAGAL!!                 ");
                Console.WriteLine("Sesuaikan Username & Password yang anda telah buat");
            }
            else if(currentState == LoginPemilikState.KELUAR)
            {
                tampilan.authPage();
            }

        }
    }
}
*/