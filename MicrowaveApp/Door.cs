using Stateless;

namespace MicrowaveApp
{

    public enum door_State
    {
        Open,
        Closed
    }

    public enum door_Triggers
    {
        Open,
        Close
    }

    class Door
    {

        public StateMachine<door_State, door_Triggers> StateMachine;

        public Door()
        {
            StateMachine = new StateMachine<door_State, door_Triggers>(door_State.Closed);

            StateMachine.Configure(door_State.Closed)
                .Permit(door_Triggers.Open, door_State.Open);

            StateMachine.Configure(door_State.Open)
                .Permit(door_Triggers.Close, door_State.Closed);
        }

        public void Open()
        {
            StateMachine.Fire(door_Triggers.Open);
        }


        public void Close()
        {
            StateMachine.Fire(door_Triggers.Close);
        }
    }
}
