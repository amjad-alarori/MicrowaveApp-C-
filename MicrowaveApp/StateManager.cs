using System;

namespace MicrowaveApp
{
    /// <summary>
    /// StateManager. This is where the magic happens.
    /// The StateManager links all microwave components together with the correct StateMachines, states and triggers.
    /// Also links the timer with the correct states. When microwave runs also start timer
    /// </summary>
    public class StateManager
    {
        public readonly Door Door = new Door();
        public readonly Microwave Microwave = new Microwave();
        private readonly Lamp _lamp = new Lamp();

        /// <param name="timerWrapper">TimerWrapper class used to keep track of time</param>
        public StateManager(TimerWrapper timerWrapper)
        {
            /*
            * Configure Microwave.StateMachine, when the state is in MicrowaveStates.Running, that the only triggers allowed to run are:
            * MicrowaveTriggers.Stop and MicrowaveTriggers.Pause.
            * When the Microwave.StateMachine changes to MicrowaveStates.Running state, OnEntry is called internally, we use this to turn the lamp on and
            * start the timer
            */
            Microwave.StateMachine.Configure(MicrowaveStates.Running)
                .OnEntry(() =>
                {
                    _lamp.TurnOn();
                    timerWrapper.Start();
                })
                .Permit(MicrowaveTriggers.Stop, MicrowaveStates.Stopped)
                .Permit(MicrowaveTriggers.Pause, MicrowaveStates.Paused);

            /*
            * Configure Microwave.StateMachine, when the state is in MicrowaveStates.Paused, that the only triggers allowed to run are:
            * MicrowaveTriggers.Start (if DoorStates.Closed) and MicrowaveTriggers.Stop.
            * When the Microwave.StateMachine changes to MicrowaveStates.Paused state, OnEntry is called internally, we use this to turn the lamp off and
            * stop the timer
            */
            Microwave.StateMachine.Configure(MicrowaveStates.Paused)
                .OnEntry(() =>
                {
                    _lamp.TurnOff();
                    timerWrapper.Stop(false);
                })
                .PermitIf(MicrowaveTriggers.Start, MicrowaveStates.Running,
                    () => Door.StateMachine.IsInState(DoorStates.Closed))
                .Permit(MicrowaveTriggers.Stop, MicrowaveStates.Stopped);

            /*
            * Configure Microwave.StateMachine, when the state is in MicrowaveStates.Stopped, that the only trigger allowed to run is
            * MicrowaveTriggers.Start (if DoorStates.Closed).
            * When the Microwave.StateMachine changes to MicrowaveStates.Stopped state, OnEntry is called internally, we use this to turn the lamp off and
            * stop the timer
            */
            Microwave.StateMachine.Configure(MicrowaveStates.Stopped)
                .OnEntry(() =>
                {
                    timerWrapper.Stop(false);
                    _lamp.TurnOff();
                })
                .PermitIf(MicrowaveTriggers.Start, MicrowaveStates.Running,
                    () => Door.StateMachine.IsInState(DoorStates.Closed));

            /*
            * Configure Door.StateMachine, when the state is in DoorStates.Open.
            * When the Door.StateMachine changes to DoorStates.Open state, OnEntry is called internally, we use this to turn the lamp on and
            * pause the microwave (if MicrowaveStates.Running)
            */
            Door.StateMachine.Configure(DoorStates.Open)
                .OnEntry(() =>
                {
                    if (Microwave.StateMachine.IsInState(MicrowaveStates.Running))
                    {
                        Microwave.Pause();
                    }

                    _lamp.TurnOn();
                });

            /*
            * Configure Door.StateMachine, when the state is in DoorStates.Closed.
            * When the Door.StateMachine changes to DoorStates.Closed state, OnEntry is called internally, we use this to turn the lamp off and
            * start the microwave (if MicrowaveStates.Paused)
            */
            Door.StateMachine.Configure(DoorStates.Closed)
                .OnEntry(() =>
                {
                    _lamp.TurnOff();
                    if (Microwave.StateMachine.IsInState(MicrowaveStates.Paused))
                    {
                        Microwave.Start();
                    }
                });
        }
    }
}