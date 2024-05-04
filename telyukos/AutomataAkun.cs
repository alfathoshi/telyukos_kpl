using telyukos_library.Menu;

namespace telyukos
{
    internal class AutomataAkun
    {

        public enum stateAkun { START, REGIS_PEMILIK, REGIS_PENYEWA, LOGIN, REGISTRASI, REGISTER_BERHASIL, KELUAR, SUBMITREG, SUBMITLOG, MENU_AWAL, HOME_PAGE_PEMILIK, HOME_PAGE_PENYEWA, GAGAL_LOGIN, BERHASIL_DAFTAR }

        public enum AkunTrigger { TULIS_START, PILIH_PEMILIK, PILIH_PENYEWA, BATAL, MENGISI_DATA, PILIH_REGIS, PILIH_LOGIN, REGISTER_BERHASIL, LOGIN_DITERIMA, LOGIN_DITOLAK }

        class Transition
        {
            public stateAkun StateAwal;
            public AkunTrigger Trigger;
            public stateAkun StateAkhir;

            public Transition(stateAkun stateAwal, AkunTrigger trigger, stateAkun stateAkhir)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(stateAkun.START,AkunTrigger.TULIS_START ,stateAkun.MENU_AWAL),
            new Transition(stateAkun.MENU_AWAL,AkunTrigger.PILIH_REGIS, stateAkun.REGISTRASI),
            new Transition(stateAkun.MENU_AWAL,AkunTrigger.PILIH_LOGIN, stateAkun.LOGIN),
            new Transition(stateAkun.MENU_AWAL,AkunTrigger.BATAL, stateAkun.KELUAR),

            //Regis
            new Transition(stateAkun.REGISTRASI,AkunTrigger.PILIH_PEMILIK,stateAkun.REGIS_PEMILIK),
            new Transition(stateAkun.REGISTRASI,AkunTrigger.PILIH_PENYEWA,stateAkun.REGIS_PENYEWA),
            new Transition(stateAkun.REGISTRASI,AkunTrigger.BATAL,stateAkun.KELUAR),

            //pemilik
            new Transition(stateAkun.REGIS_PEMILIK,AkunTrigger.MENGISI_DATA,stateAkun.SUBMITREG),
            new Transition(stateAkun.SUBMITREG,AkunTrigger.REGISTER_BERHASIL,stateAkun.BERHASIL_DAFTAR),
            new Transition(stateAkun.REGIS_PEMILIK,AkunTrigger.BATAL,stateAkun.KELUAR),

            

            //penyewa
            new Transition(stateAkun.REGIS_PENYEWA, AkunTrigger.MENGISI_DATA,stateAkun.SUBMITREG),
            new Transition(stateAkun.SUBMITREG, AkunTrigger.REGISTER_BERHASIL,stateAkun.BERHASIL_DAFTAR),
            new Transition(stateAkun.REGIS_PENYEWA,AkunTrigger.BATAL,stateAkun.KELUAR),
            

            //LOGIN
            //pemilik
            new Transition(stateAkun.LOGIN,AkunTrigger.MENGISI_DATA,stateAkun.SUBMITLOG),
            new Transition(stateAkun.SUBMITLOG,AkunTrigger.LOGIN_DITERIMA,stateAkun.HOME_PAGE_PEMILIK),
            new Transition(stateAkun.SUBMITLOG,AkunTrigger.LOGIN_DITOLAK,stateAkun.GAGAL_LOGIN),
            new Transition(stateAkun.LOGIN,AkunTrigger.BATAL,stateAkun.KELUAR),

            //penyewa
            new Transition(stateAkun.LOGIN,AkunTrigger.MENGISI_DATA,stateAkun.SUBMITLOG),
            new Transition(stateAkun.SUBMITLOG,AkunTrigger.LOGIN_DITERIMA,stateAkun.HOME_PAGE_PENYEWA),
            new Transition(stateAkun.SUBMITLOG,AkunTrigger.LOGIN_DITOLAK,stateAkun.GAGAL_LOGIN),
            new Transition(stateAkun.LOGIN,AkunTrigger.BATAL,stateAkun.KELUAR),
        };

        public stateAkun currentState = stateAkun.START;
        public stateAkun getNextState(stateAkun StateAwal, AkunTrigger trigger)
        {
            stateAkun StateAkhir = StateAwal;
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
            //menu awal
            Menu menu = new Menu();
            menu.header();
            currentState = getNextState(currentState, Trigger);

            if (currentState == stateAkun.BERHASIL_DAFTAR)
            {
                Console.WriteLine("REGISTRASI BERHASIL!!");
            }
            else if (currentState == stateAkun.HOME_PAGE_PEMILIK)
            {
                menu.mainMenuOwner(); 
            }
            else if (currentState == stateAkun.HOME_PAGE_PENYEWA)
            {
                menu.mainManuRenter();
            }
            else if (currentState == stateAkun.GAGAL_LOGIN)
            {
                Console.WriteLine("                    LOGIN GAGAL!!                 ");
                Console.WriteLine("Sesuaikan Username & Password yang anda telah buat");
            }

        }
    }
}

