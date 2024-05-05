using telyukos_library.Menu;

namespace telyukos.State
{
    public class AuthState
    {
        public enum State { START, LOGIN, EXIT }

        public enum Trigger { MASUK, LOGIN_DITERIMA, CLOSE, LOGOUT }

        class Transition
        {
            public State StateAwal;
            public Trigger Trigger;
            public State StateAkhir;

            public Transition(State stateAwal, Trigger trigger, State stateAkhir)
            {
                StateAwal = stateAwal;
                StateAkhir = stateAkhir;
                Trigger = trigger;
            }
        }

        Transition[] transitions =
        {
            new Transition(State.START,Trigger.LOGIN_DITERIMA ,State.LOGIN),
            new Transition(State.LOGIN,Trigger.CLOSE, State.EXIT),
            new Transition(State.START, Trigger.CLOSE, State.EXIT),
            new Transition(State.LOGIN, Trigger.LOGOUT, State.START)
        };

        public State currentState;
        public State getNextState(State StateAwal, Trigger trigger)
        {
            State StateAkhir = StateAwal;
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
    }
}
