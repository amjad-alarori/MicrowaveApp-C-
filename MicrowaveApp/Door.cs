using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace MicrowaveApp
{
    class Door
    {
        public enum DoorState
        {
            Open,
            Closed
        }

        public enum DoorTriggers
        {
            Open,
            Close
        }

        public StateMachine<DoorState, DoorTriggers> _door;

        public Door()
        {
            _door = new StateMachine<DoorState, DoorTriggers>(DoorState.Closed);

            _door.Configure(DoorState.Closed)
                .Permit(DoorTriggers.Open, DoorState.Open);

            _door.Configure(DoorState.Open)
                .Permit(DoorTriggers.Close, DoorState.Closed);
        }

        public void Open()
        {
            _door.Fire(DoorTriggers.Open);

            // Check if lamp can be turn on. If not, the lamp is already on
            //if (_lamp.CanFire(LampTriggers.TurnOn))
            //{
            //    _lamp.Fire(LampTriggers.TurnOn);
            //}

            //if (_microwave.CanFire(MicrowaveTriggers.Pause))
            //{
            //    _microwave.Fire(MicrowaveTriggers.Pause);
            //}
        }


        public void Close()
        {
            _door.Fire(DoorTriggers.Close);
            //if (_lamp.CanFire(LampTriggers.TurnOff))
            //{
            //    _lamp.Fire(LampTriggers.TurnOff);
            //}

            //if (_microwave.CanFire(MicrowaveTriggers.Start) && _microwave.IsInState(MicrowaveState.Paused))
            //{
            //    _microwave.Fire(MicrowaveTriggers.Start);
            //}
        }
    }
}
