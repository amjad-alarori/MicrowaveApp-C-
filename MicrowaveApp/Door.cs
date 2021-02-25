using System;
using System.Drawing;
using System.Windows.Forms;

using Stateless;
using System.Media;

namespace MicrowaveApp
{

    

    public enum door_State
    {
        //Set 2 states (open & closed)
        Open,
        Closed
    }

    public enum door_Triggers
    {
        //Set 2 Triggers (open & closed)
        Open,
        Close
    }

    /// <summary>
    /// Door constructor
    /// </summary>
    class Door
    {

        public StateMachine<door_State, door_Triggers> StateMachine;
        //Make new sound object
        SoundPlayer music = new SoundPlayer();
        

        public Door()
        {
            //Set default state to closed
            StateMachine = new StateMachine<door_State, door_Triggers>(door_State.Closed);
            //When state is closed permit state open to be used when clicked
            StateMachine.Configure(door_State.Closed)
                .Permit(door_Triggers.Open, door_State.Open);
            //when state is open permit state closed to be used when clicked
            StateMachine.Configure(door_State.Open)
                .Permit(door_Triggers.Close, door_State.Closed);
        }

        public void Open()
        {
            StateMachine.Fire(door_Triggers.Open);
            ComboBox combobox = Application.OpenForms["Main"].Controls["comboBoxMeals"] as ComboBox;
            //Enable combobox so that the user can choose a dish when microwave is open
            combobox.Enabled = true;
            PictureBox t = Application.OpenForms["Main"].Controls["pictureBoxDoor"] as PictureBox;
            //Show microwave open picture in the image generated picture box
            t.ImageLocation = "images/MicrowaveOpen.jpg";

            music.SoundLocation = "sounds/MicrowaveOpenSound.wav";
            //Play door open sound
            music.Play();
        }

        


        public void Close()
        {
            StateMachine.Fire(door_Triggers.Close);
            ComboBox combobox = Application.OpenForms["Main"].Controls["comboBoxMeals"] as ComboBox;
            //Disable combobox so that the user can't choose a dish when microwave is closed
            combobox.Enabled = false;
            PictureBox t = Application.OpenForms["Main"].Controls["pictureBoxDoor"] as PictureBox;
            //Show microwave closed picture in the image generated picture box
            t.ImageLocation = "images/Microwave.jpg";

            music.SoundLocation = "sounds/MicrowaveCloseSound_.wav";
            //Play door close sound
            music.Play();
            
        }
    }
}
