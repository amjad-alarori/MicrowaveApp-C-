using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrowaveApp
{
    class MicrowaveLamp:Microwave
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

        public enum LampState
        {
            On,
            Off
        }

        public enum LampTriggers
        {
            TurnOn,
            TurnOff
        }
    }
}
