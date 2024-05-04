using System;
using telyukos_library.Menu.MainMenu;
using static telyukos.Akun;
using telyukos;

//Automata
namespace telyukos
{

    internal class AkunRegisPenyewa
    {
        public enum StatePenyewa { START, REGIS_PENYEWA, REGISTRASI, REGISTER_BERHASIL, KELUAR, SUBMITREG, MENU_AWAL, HOME_PAGE_PENYEWA, BERHASIL_DAFTAR }

        public enum AkunTrigger { TULIS_START, PILIH_PENYEWA, BATAL, MENGISI_DATA, PILIH_REGIS, REGISTER_BERHASIL }

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
            new Transition(StatePenyewa.MENU_AWAL,AkunTrigger.PILIH_REGIS, StatePenyewa.REGISTRASI),
            new Transition(StatePenyewa.MENU_AWAL,AkunTrigger.BATAL, StatePenyewa.KELUAR),

            //Regis
            new Transition(StatePenyewa.REGISTRASI,AkunTrigger.PILIH_PENYEWA,StatePenyewa.REGIS_PENYEWA),
            new Transition(StatePenyewa.REGISTRASI,AkunTrigger.BATAL,StatePenyewa.MENU_AWAL),
            new Transition(StatePenyewa.REGIS_PENYEWA, AkunTrigger.MENGISI_DATA,StatePenyewa.SUBMITREG),
            new Transition(StatePenyewa.SUBMITREG, AkunTrigger.REGISTER_BERHASIL,StatePenyewa.BERHASIL_DAFTAR),
            new Transition(StatePenyewa.REGIS_PENYEWA,AkunTrigger.BATAL,StatePenyewa.MENU_AWAL),
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
                Console.WriteLine("=== REGISTRASI ===");

            }
            else if (currentState == StatePenyewa.REGISTRASI)
            {
                Console.WriteLine("=== Silakan Registrasi ===");
            }
            else if (currentState == StatePenyewa.REGISTER_BERHASIL)
            {
                Console.WriteLine("--- Berhasil Melakukan Registrasi ---");
            }
            else if (currentState == StatePenyewa.KELUAR)
            {
                Console.WriteLine("--- Batal Registrasi ---");
            }
            else if (currentState == StatePenyewa.SUBMITREG)
            {
                Console.WriteLine("--- Submit Data Registrasi ---");
            }
            else if (currentState == StatePenyewa.MENU_AWAL)
            {
                MainMenu m = new MainMenu();
            }
            else if (currentState == StatePenyewa.BERHASIL_DAFTAR)
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
    internal class AkunRegisPenyewa
    {
    }
}*/
