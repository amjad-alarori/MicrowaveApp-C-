using System.Windows.Forms;
using Stateless;
using System.Media;

namespace MicrowaveApp
{
    /// <summary>
    /// Define all states a door can be in
    /// </summary>
    public enum DoorStates
    {
        Open,
        Closed
    }

    /// <summary>
    /// Define all triggers that can be used to change state (later configured)
    /// </summary>
    public enum DoorTriggers
    {
        Open,
        Close
    }

    /// <summary>
    /// Door class. The door has a internal statemachine that is linked to different elements of the microwave in the StateManager
    /// </summary>
    /// <see cref="StateManager"/>
    internal class Door
    {
        // Construct new StateMachine with DoorStates and DoorTriggers. Also sets the StateMachine default state to DoorState.Closed (Closed)
        public readonly StateMachine<DoorStates, DoorTriggers> StateMachine = new StateMachine<DoorStates, DoorTriggers>(DoorStates.Closed);
        private readonly SoundPlayer _soundPlayer = new SoundPlayer();

        public Door()
        {
            /*
             * Configure StateMachine, when the state is in DoorState.Closed, that the only trigger allowed to run is DoorTriggers.Open.
             * This trigger is also configured when called to set state to DoorState.Open
             */
            StateMachine.Configure(DoorStates.Closed)
                .Permit(DoorTriggers.Open, DoorStates.Open);

            /*
             * Configure StateMachine, when the state is in DoorState.Open, that the only trigger allowed to run is DoorTriggers.Close.
             * This trigger is also configured when called to set state to DoorState.Closed
             */
            StateMachine.Configure(DoorStates.Open)
                .Permit(DoorTriggers.Close, DoorStates.Closed);
        }

        /// <summary>
        /// When run. Changes state to DoorStates.Open, Enable meals dropdown, Changes image and plays DoorOpen.wav sound
        /// </summary>
        public void Open()
        {
            StateMachine.Fire(DoorTriggers.Open);
            
            // Find ComboBox comboBoxMeals inside Main form to enable or disable the element later in the code to select a food (since that is allowed when the door is a specific state)
            ComboBox comboBox = Application.OpenForms["Main"]?.Controls["comboBoxMeals"] as ComboBox;
            comboBox.Enabled = true;

            // Find PictureBox pictureBoxDoor inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxDoor = Application.OpenForms["Main"]?.Controls["pictureBoxDoor"] as PictureBox;
            pictureBoxDoor.ImageLocation = "images/MicrowaveOpen.jpg";

            _soundPlayer.SoundLocation = "sounds/DoorOpen.wav";
            _soundPlayer.Play();
        }

        /// <summary>
        /// When run. Changes state to DoorStates.Closed, Disable meals dropdown, Changes image and plays DoorClose.wav sound
        /// </summary>
        public void Close()
        {
            StateMachine.Fire(DoorTriggers.Close);
            
            ComboBox comboBox = Application.OpenForms["Main"]?.Controls["comboBoxMeals"] as ComboBox;
            comboBox.Enabled = false;

            // Find PictureBox pictureBoxDoor inside Main form to change ImageLocation to a Open image. ImageGenerator handles the rest
            PictureBox pictureBoxDoor = Application.OpenForms["Main"]?.Controls["pictureBoxDoor"] as PictureBox;
            pictureBoxDoor.ImageLocation = "images/Microwave.jpg";

            _soundPlayer.SoundLocation = "sounds/DoorClose.wav";
            _soundPlayer.Play();
        }
    }
}