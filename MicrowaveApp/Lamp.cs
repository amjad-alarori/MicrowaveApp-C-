using Stateless;
using System.Windows.Forms;

namespace MicrowaveApp
{
    /// <summary>
    /// Define all states a lamp can be in
    /// </summary>
    public enum LampStates
    {
        On,
        Off
    }

    /// <summary>
    /// Define all triggers that can be used to change state (later configured)
    /// </summary>
    public enum LampTriggers
    {
        TurnOn,
        TurnOff
    }

    /// <summary>
    /// Lamp class. The door has a internal statemachine that is linked to different elements of the microwave in the StateManager
    /// </summary>
    /// <see cref="StateManager"/>
    internal class Lamp
    {
        // Construct new StateMachine with LampStates and LampTriggers. Also sets the StateMachine default state to LampStates.Off (Off)
        private readonly StateMachine<LampStates, LampTriggers> _stateMachine = new StateMachine<LampStates, LampTriggers>(LampStates.Off);
        
        public Lamp()
        {
            /*
             * Configure StateMachine, when the state is in LampStates.Off, that the only trigger allowed to run is LampTriggers.TurnOn.
             * This trigger is also configured when called to set state to LampStates.On
             */
            _stateMachine.Configure(LampStates.Off)
                .Permit(LampTriggers.TurnOn, LampStates.On);

            /*
             * Configure StateMachine, when the state is in LampStates.On, that the only trigger allowed to run is LampTriggers.TurnOff.
             * This trigger is also configured when called to set state to LampStates.Off
             */
            _stateMachine.Configure(LampStates.On)
                .Permit(LampTriggers.TurnOff, LampStates.Off);
        }

        /// <summary>
        /// When run and State change is allowed, changes state to Lamp.On and changes image
        /// </summary>
        public void TurnOn()
        {
            if (!_stateMachine.CanFire(LampTriggers.TurnOn)) return;

            _stateMachine.Fire(LampTriggers.TurnOn);
            
            // Find PictureBox pictureBoxLamp inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
            pictureBoxLamp.ImageLocation = "images/LampOn.png";
        }

        /// <summary>
        /// When run and State change is allowed, changes state to Lamp.Off and changes image
        /// </summary>
        public void TurnOff()
        {
            if (!_stateMachine.CanFire(LampTriggers.TurnOff)) return;

            _stateMachine.Fire(LampTriggers.TurnOff);
            
            // Find PictureBox pictureBoxLamp inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
            pictureBoxLamp.ImageLocation = "images/LampOff.png";
        }
    }
}