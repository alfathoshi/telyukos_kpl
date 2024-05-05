using telyukos_library.Menu;

namespace telyukos
{
    public class RegisterState
    {

        public enum StateRegister { START, INPUT, AUTH, REGISTER_BERHASIL, REGISTER_GAGAL }

        public enum AkunTrigger { PILIH_AUTH, MENGISI_DATA, REGISTER_DITERIMA, REGISTER_DITOLAK }

        class Transition
        {
            public StateRegister StateAwal;
            public AkunTrigger Trigger;
            public StateRegister StateAkhir;

            public Transition(StateRegister stateAwal, AkunTrigger trigger, StateRegister stateAkhir)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {

            new Transition(StateRegister.START,AkunTrigger.PILIH_AUTH ,StateRegister.INPUT),
            new Transition(StateRegister.INPUT,AkunTrigger.MENGISI_DATA, StateRegister.AUTH),
            new Transition(StateRegister.AUTH,AkunTrigger.REGISTER_DITERIMA, StateRegister.REGISTER_BERHASIL),
            new Transition(StateRegister.AUTH, AkunTrigger.REGISTER_DITOLAK, StateRegister.REGISTER_GAGAL),
        };

        public StateRegister currentState;
        public StateRegister getNextState(StateRegister StateAwal, AkunTrigger trigger)
        {
            StateRegister StateAkhir = StateAwal;
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
        Menu menu = new Menu();
        public void ActiveTrigger(AkunTrigger Trigger)
        {
            currentState = getNextState(currentState, Trigger);

            if (currentState == StateRegister.START)
            {
                menu.header();

            }
        }
    }
}
