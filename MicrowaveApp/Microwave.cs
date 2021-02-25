using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;
using System.Media;

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
        SoundPlayer music = new SoundPlayer();

        public Microwave()
        {
            StateMachine = new StateMachine<microwave_State, microwave_Triggers>(microwave_State.Stopped);
        }

        public void Start()
        {
            StateMachine.Fire(microwave_Triggers.Start);

            music.SoundLocation = "sounds/MicrowaveCookingSound.wav";
            music.Play();
            music.SoundLocation = "sounds/MicrowaveRunningLoop.wav";
            music.PlayLooping();

        }

        public void Stop()
        {
            if (StateMachine.CanFire(microwave_Triggers.Stop))
            {
                StateMachine.Fire(microwave_Triggers.Stop);
                music.Stop();
            }
        }

        public void Pause()
        {
            if (StateMachine.CanFire(microwave_Triggers.Pause))
            {
                StateMachine.Fire(microwave_Triggers.Pause);
                music.Stop();
            }
        }

    }

}