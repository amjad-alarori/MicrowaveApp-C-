using Stateless;
using System;

namespace MicrowaveApp
{

    class StateManager
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

        // Todo:: Check var name
        public StateMachine<MicrowaveState, MicrowaveTriggers> _microwave;
        public StateMachine<DoorState, DoorTriggers> _door;
        public StateMachine<LampState, LampTriggers> _lamp;

        public StateManager()
        {
            InitMicrowave();
            InitDoor();
            InitLamp();
        }

        void InitMicrowave()
        {
            _microwave = new StateMachine<MicrowaveState, MicrowaveTriggers>(MicrowaveState.Stopped);

            _microwave.Configure(MicrowaveState.Running)
                .Permit(MicrowaveTriggers.Stop, MicrowaveState.Stopped)
                .Permit(MicrowaveTriggers.Pause, MicrowaveState.Paused);

            _microwave.Configure(MicrowaveState.Paused)
                .PermitIf(MicrowaveTriggers.Start, MicrowaveState.Running, () => _door.IsInState(DoorState.Closed))
                .Permit(MicrowaveTriggers.Stop, MicrowaveState.Stopped);

            _microwave.Configure(MicrowaveState.Stopped)
                .PermitIf(MicrowaveTriggers.Start, MicrowaveState.Running, () => _door.IsInState(DoorState.Closed));
        }

        void InitDoor()
        {
            _door = new StateMachine<DoorState, DoorTriggers>(DoorState.Closed);

            _door.Configure(DoorState.Closed)
                .Permit(DoorTriggers.Open, DoorState.Open);

            _door.Configure(DoorState.Open)
                .Permit(DoorTriggers.Close, DoorState.Closed);
        }

        void InitLamp()
        {
            _lamp = new StateMachine<LampState, LampTriggers>(LampState.Off);

            _lamp.Configure(LampState.Off)
                .Permit(LampTriggers.TurnOn, LampState.On);

            _lamp.Configure(LampState.On)
                .Permit(LampTriggers.TurnOff, LampState.Off);
        }

        // Todo:: Check if these functions are needed to hook to fire functions

        // Start microwave
        //public void Start()
        //{
        //    _microwave.Fire(MicrowaveTriggers.Start);
        //    if (_lamp.CanFire(LampTriggers.TurnOn))
        //    {
        //        _lamp.Fire(LampTriggers.TurnOn);
        //    }
        //}


        //// Pause microwave
        //public void Pause()
        //{
        //    _microwave.Fire(MicrowaveTriggers.Pause);
        //}


        //// Stop microwave
        //public void Stop()
        //{
        //    _microwave.Fire(MicrowaveTriggers.Stop);
        //    if (_lamp.CanFire(LampTriggers.TurnOff))
        //    {
        //        _lamp.Fire(LampTriggers.TurnOff);
        //    }
        //}

        // Open door
        public void Open()
        {
            _door.Fire(DoorTriggers.Open);

            // Check if lamp can be turn on. If not, the lamp is already on
            if (_lamp.CanFire(LampTriggers.TurnOn))
            {
                _lamp.Fire(LampTriggers.TurnOn);
            }

            if (_microwave.CanFire(MicrowaveTriggers.Pause))
            {
                _microwave.Fire(MicrowaveTriggers.Pause);
            }
        }


        // Close door
        public void Close()
        {
            _door.Fire(DoorTriggers.Close);
            if (_lamp.CanFire(LampTriggers.TurnOff))
            {
                _lamp.Fire(LampTriggers.TurnOff);
            }

            if (_microwave.CanFire(MicrowaveTriggers.Start) && _microwave.IsInState(MicrowaveState.Paused))
            {
                _microwave.Fire(MicrowaveTriggers.Start);
            }
        }

        // Turn on lamp owo
        public void TurnOn()
        {
            _lamp.Fire(LampTriggers.TurnOn);
        }

        // Turn off lamp v~v
        public void TurnOff()
        {
            _lamp.Fire(LampTriggers.TurnOff);
        }

    }
}
