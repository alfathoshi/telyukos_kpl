using System;
using System.Security;
using telyukos;

namespace telyukos
{
    internal class Akun
    {

        public enum stateAkun {Start,RegisPemilik,RegisPenyewa,LoginPemilik,LoginPenyewa,Login,Registrasi,TampilanRegisPenyewa,TampilanRegisPemilik,TampilanLoginPemiilik,TampilanLoginPenyewa, Keluar }

        public enum AkunTrigger{StateRegis,PilihPemilik,PilihPenyewa,StateLogin,Batal,submit}

        class Transition
        {
            public stateAkun StateAwal;
            public AkunTrigger Trigger;
            public stateAkun StateAkhir;

            public Transition (stateAkun stateAwal,  stateAkun stateAkhir, AkunTrigger trigger)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(stateAkun.Start, stateAkun.Registrasi,AkunTrigger.StateRegis),
            new Transition(stateAkun.Start, stateAkun.Login,AkunTrigger.StateLogin),
            new Transition(stateAkun.Start, stateAkun.Keluar,AkunTrigger.Batal),

            //Regis
            new Transition(stateAkun.Registrasi,stateAkun.RegisPemilik,AkunTrigger.PilihPemilik),
            new Transition(stateAkun.Registrasi,stateAkun.RegisPenyewa,AkunTrigger.PilihPenyewa),
            new Transition(stateAkun.Registrasi,stateAkun.Keluar,AkunTrigger.Batal),

            //pemilik
            new Transition(stateAkun.RegisPemilik,stateAkun.TampilanRegisPemilik,AkunTrigger.submit),
            new Transition(stateAkun.RegisPemilik,stateAkun.TampilanRegisPemilik,AkunTrigger.Batal),

            //penyewa
            new Transition(stateAkun.RegisPenyewa,stateAkun.TampilanRegisPenyewa, AkunTrigger.submit),
            new Transition(stateAkun.RegisPenyewa,stateAkun.TampilanRegisPenyewa,AkunTrigger.Batal),

            //Logim
            new Transition(stateAkun.Login,stateAkun.LoginPemilik,AkunTrigger.PilihPemilik),
            new Transition(stateAkun.Login, stateAkun.LoginPenyewa,AkunTrigger.PilihPenyewa),
            new Transition(stateAkun.Login,stateAkun.Keluar,AkunTrigger.Batal),

            //pemilik
            new Transition(stateAkun.LoginPemilik,stateAkun.TampilanLoginPemiilik,AkunTrigger.submit),
            new Transition(stateAkun.LoginPemilik,stateAkun.TampilanLoginPemiilik,AkunTrigger.Batal),

            //penyewa
            new Transition(stateAkun.LoginPenyewa,stateAkun.TampilanLoginPenyewa,AkunTrigger.submit),
            new Transition(stateAkun.LoginPenyewa,stateAkun.TampilanLoginPenyewa,AkunTrigger.Batal)
        };

        public stateAkun currentState = stateAkun.Start;
        public stateAkun getNextState(stateAkun StateAwal,AkunTrigger trigger)
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
            menu tampilanMenu = new menu();
            stateAkun StateAkhir  = getNextState(currentState,Trigger);
            currentState = StateAkhir;
        }
    }
}

