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
    public class Lamp
    {
        // Construct new StateMachine with LampStates and LampTriggers. Also sets the StateMachine default state to LampStates.Off (Off)
        public readonly StateMachine<LampStates, LampTriggers> StateMachine = new StateMachine<LampStates, LampTriggers>(LampStates.Off);
        
        public Lamp()
        {
            /*
             * Configure StateMachine, when the state is in LampStates.Off, that the only trigger allowed to run is LampTriggers.TurnOn.
             * This trigger is also configured when called to set state to LampStates.On
             */
            StateMachine.Configure(LampStates.Off)
                .Permit(LampTriggers.TurnOn, LampStates.On);

            /*
             * Configure StateMachine, when the state is in LampStates.On, that the only trigger allowed to run is LampTriggers.TurnOff.
             * This trigger is also configured when called to set state to LampStates.Off
             */
            StateMachine.Configure(LampStates.On)
                .Permit(LampTriggers.TurnOff, LampStates.Off);
        }

        /// <summary>
        /// When run and State change is allowed, changes state to Lamp.On and changes image
        /// </summary>
        public void TurnOn()
        {
            if (!StateMachine.CanFire(LampTriggers.TurnOn)) return;

            StateMachine.Fire(LampTriggers.TurnOn);
            
            // Find PictureBox pictureBoxLamp inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
            pictureBoxLamp.ImageLocation = "images/LampOn.png";
        }

        /// <summary>
        /// When run and State change is allowed, changes state to Lamp.Off and changes image
        /// </summary>
        public void TurnOff()
        {
            if (!StateMachine.CanFire(LampTriggers.TurnOff)) return;

            StateMachine.Fire(LampTriggers.TurnOff);
            
            // Find PictureBox pictureBoxLamp inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
            pictureBoxLamp.ImageLocation = "images/LampOff.png";
        }
    }
}