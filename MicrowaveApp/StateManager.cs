﻿using Stateless;
using System;

namespace MicrowaveApp
{

    class StateManager
    {

        public Door _door = new Door();
        public Microwave _microwave = new Microwave();
        public Lamp _lamp = new Lamp();
        private TimerWrapper _timerWrapper;


        public StateManager(TimerWrapper timerWrapper)
        {

            _timerWrapper = timerWrapper;
            
            _microwave.StateMachine.Configure(microwave_State.Running)
                .OnEntry(() =>
                {
                    _lamp.TurnOn();
                    _timerWrapper.Start();
                })
                .Permit(microwave_Triggers.Stop, microwave_State.Stopped)
                .Permit(microwave_Triggers.Pause, microwave_State.Paused);

            _microwave.StateMachine.Configure(microwave_State.Paused)
                .OnEntry(() =>
                {
                    _lamp.TurnOff();
                    _timerWrapper.Stop(false);
                })
                .PermitIf(microwave_Triggers.Start, microwave_State.Running, () => _door.StateMachine.IsInState(door_State.Closed))
                .Permit(microwave_Triggers.Stop, microwave_State.Stopped);

            _microwave.StateMachine.Configure(microwave_State.Stopped)
                .OnEntry(() =>
                {
                    // Stop timer without event
                    _timerWrapper.Stop(false);
                    _lamp.TurnOff();
                })
                .PermitIf(microwave_Triggers.Start, microwave_State.Running, () => _door.StateMachine.IsInState(door_State.Closed));

            _door.StateMachine.Configure(door_State.Open)
                .OnEntry(() =>
                {
                    if (_microwave.StateMachine.IsInState(microwave_State.Running))
                    {
                        _microwave.Pause();
                    }
                    _lamp.TurnOn();
                });

            _door.StateMachine.Configure(door_State.Closed)
                .OnEntry(() =>
                {
                    if (_microwave.StateMachine.IsInState(microwave_State.Paused))
                    {
                        _microwave.Start();
                  
                    }
                    _lamp.TurnOff();
                });
        }

    }
}
