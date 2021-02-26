using Stateless;
using System.Media;

namespace MicrowaveApp
{
    /// <summary>
    /// Define all states a microwave can be in
    /// </summary>
    public enum MicrowaveStates
    {
        Running,
        Paused,
        Stopped
    }

    /// <summary>
    /// Define all triggers that can be used to change state (later configured)
    /// </summary>
    public enum MicrowaveTriggers
    {
        Start,
        Pause,
        Stop
    }

    /// <summary>
    /// Microwave class. The microwave has a internal statemachine that is linked to different elements of the microwave in the StateManager
    /// </summary>
    /// <see cref="StateManager"/>
    public class Microwave
    {
        // Construct new StateMachine with MicrowaveStates and MicrowaveTriggers. Also sets the StateMachine default state to MicrowaveStates.Stopped (Stopped)
        public readonly StateMachine<MicrowaveStates, MicrowaveTriggers> StateMachine = new StateMachine<MicrowaveStates, MicrowaveTriggers>(MicrowaveStates.Stopped);

        private readonly SoundPlayer _soundPlayer = new SoundPlayer();

        /// <summary>
        /// When run and State change is allowed, changes state to MicrowaveTriggers.Start and plays start and "mmmmmmmmmmm" sound
        /// </summary>
        public void Start()
        {
            StateMachine.Fire(MicrowaveTriggers.Start);

            _soundPlayer.SoundLocation = "sounds/MicrowaveStarting.wav";
            _soundPlayer.Play();

            _soundPlayer.SoundLocation = "sounds/MicrowaveRunning.wav";
            _soundPlayer.PlayLooping();
        }

        /// <summary>
        /// When run and State change is allowed, changes state to MicrowaveTriggers.Stop and stops "mmmmmmmmmmm" sound
        /// </summary>
        public void Stop()
        {
            if (!StateMachine.CanFire(MicrowaveTriggers.Stop)) return;

            StateMachine.Fire(MicrowaveTriggers.Stop);
            _soundPlayer.Stop();
        }

        /// <summary>
        /// When run and State change is allowed, changes state to MicrowaveTriggers.Pause and stops "mmmmmmmmmmm" sound
        /// </summary>
        public void Pause()
        {
            StateMachine.Fire(MicrowaveTriggers.Pause);
            _soundPlayer.Stop();
        }
    }
}