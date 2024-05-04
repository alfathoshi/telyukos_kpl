using System;
using telyukos_library.Menu.MainMenu;
using static telyukos.Akun;
using telyukos;

//Automata
namespace telyukos
{

    internal class AkunRegisPemilik
    {
        public enum StatePemilik { START, REGIS_PEMILIK, REGISTRASI, REGISTER_BERHASIL, KELUAR, SUBMITREG, MENU_AWAL, HOME_PAGE_PEMILIK, BERHASIL_DAFTAR }

        public enum AkunTrigger { TULIS_START, PILIH_PEMILIK, BATAL, MENGISI_DATA, PILIH_REGIS, REGISTER_BERHASIL }

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
            new Transition(StatePemilik.MENU_AWAL,AkunTrigger.PILIH_REGIS, StatePemilik.REGISTRASI),
            new Transition(StatePemilik.MENU_AWAL,AkunTrigger.BATAL, StatePemilik.KELUAR),

            //Regis
            new Transition(StatePemilik.REGISTRASI,AkunTrigger.PILIH_PEMILIK,StatePemilik.REGIS_PEMILIK),
            new Transition(StatePemilik.REGISTRASI,AkunTrigger.BATAL,StatePemilik.MENU_AWAL),
            new Transition(StatePemilik.REGIS_PEMILIK, AkunTrigger.MENGISI_DATA,StatePemilik.SUBMITREG),
            new Transition(StatePemilik.SUBMITREG, AkunTrigger.REGISTER_BERHASIL,StatePemilik.BERHASIL_DAFTAR),
            new Transition(StatePemilik.REGIS_PEMILIK,AkunTrigger.BATAL,StatePemilik.MENU_AWAL),
        };

        public StatePemilik currentState = StatePemilik.START;
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
                Console.WriteLine("=== REGISTRASI ===");

            }
            else if (currentState == StatePemilik.REGISTRASI)
            {
                Console.WriteLine("=== Silakan Registrasi ===");
            }
            else if (currentState == StatePemilik.REGISTER_BERHASIL)
            {
                Console.WriteLine("--- Berhasil Melakukan Registrasi ---");
            }
            else if (currentState == StatePemilik.KELUAR)
            {
                Console.WriteLine("--- Batal Registrasi ---");
            }
            else if (currentState == StatePemilik.SUBMITREG)
            {
                Console.WriteLine("--- Submit Data Registrasi ---");
            }
            else if (currentState == StatePemilik.MENU_AWAL)
            {
                MainMenu m = new MainMenu();
            }
            else if (currentState == StatePemilik.BERHASIL_DAFTAR)
            {
                Console.WriteLine("=== Berhasil Registrasi ===");
            }

        }


    }


}


/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telyukos
{
    internal class AkunRegisPemilik
    {

    }
}*/
