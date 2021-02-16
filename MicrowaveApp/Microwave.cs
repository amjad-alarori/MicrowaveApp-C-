using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace MicrowaveApp
{

    public enum microwave_State
    {
        Running,
        Paused,
        Stopped
    }

    public enum microwave_Triggers
    {
        Start,
        Pause,
        Stop
    }

    class Microwave
    {

        public StateMachine<microwave_State, microwave_Triggers> StateMachine;

        public Microwave()
        {
            StateMachine = new StateMachine<microwave_State, microwave_Triggers>(microwave_State.Stopped);
        }

        public void Start()
        {
            StateMachine.Fire(microwave_Triggers.Start);
        }

        public void Stop()
        {
            StateMachine.Fire(microwave_Triggers.Stop);
        }

        public void Pause()
        {
            StateMachine.Fire(microwave_Triggers.Pause);
        }

    }

}