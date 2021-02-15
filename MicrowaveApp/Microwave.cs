using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace MicrowaveApp
{
    class Microwave
    {
        public enum MicrowaveState
        {
            Running,
            Paused,
            Stopped
        }

        public enum MicrowaveTriggers
        {
            Start,
            Pause,
            Stop
        }

        public StateMachine<MicrowaveState, MicrowaveTriggers> _microwave;

        public Microwave()
        {
            _microwave = new StateMachine<MicrowaveState, MicrowaveTriggers>(MicrowaveState.Stopped);

            _microwave.Configure(MicrowaveState.Running)
                .Permit(MicrowaveTriggers.Stop, MicrowaveState.Stopped)
                .Permit(MicrowaveTriggers.Pause, MicrowaveState.Paused);

            _microwave.Configure(MicrowaveState.Paused)
                .PermitIf(MicrowaveTriggers.Start, MicrowaveState.Running, () => _door.IsInState(StateManager.DoorState.Closed))
                .Permit(MicrowaveTriggers.Stop, MicrowaveState.Stopped);

            _microwave.Configure(MicrowaveState.Stopped)
                .PermitIf(MicrowaveTriggers.Start, MicrowaveState.Running, () => _door.IsInState(StateManager.DoorState.Closed));
        }

        public void Start()
        {
            _microwave.Fire(MicrowaveTriggers.Start);
            if (_lamp.CanFire(StateManager.LampTriggers.TurnOn))
            {
                _lamp.Fire(StateManager.LampTriggers.TurnOn);
            }
        }

        public void Stop()
        {
            _microwave.Fire(MicrowaveTriggers.Stop);
            if (_lamp.CanFire(StateManager.LampTriggers.TurnOff))
            {
                _lamp.Fire(StateManager.LampTriggers.TurnOff);
            }


        }

        public void Pause()
        {
            _microwave.Fire(MicrowaveTriggers.Pause);

        }




    }


}