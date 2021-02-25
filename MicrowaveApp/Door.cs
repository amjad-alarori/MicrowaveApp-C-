using System;
using System.Drawing;
using System.Windows.Forms;

using Stateless;
using System.Media;

namespace MicrowaveApp
{

    

    public enum door_State
    {
        Open,
        Closed
    }

    public enum door_Triggers
    {
        Open,
        Close
    }

    class Door
    {

        public StateMachine<door_State, door_Triggers> StateMachine;

        SoundPlayer music = new SoundPlayer();
        

        public Door()
        {
            StateMachine = new StateMachine<door_State, door_Triggers>(door_State.Closed);

            StateMachine.Configure(door_State.Closed)
                .Permit(door_Triggers.Open, door_State.Open);

            StateMachine.Configure(door_State.Open)
                .Permit(door_Triggers.Close, door_State.Closed);
        }

        public void Open()
        {
            StateMachine.Fire(door_Triggers.Open);
            ComboBox combobox = Application.OpenForms["Main"].Controls["comboBoxMeals"] as ComboBox;
            combobox.Enabled = true;
            PictureBox t = Application.OpenForms["Main"].Controls["pictureBoxDoor"] as PictureBox;

            t.ImageLocation = "images/MicrowaveOpen.jpg";

            music.SoundLocation = "sounds/MicrowaveOpenSound.wav";
            music.Play();
        }

        


        public void Close()
        {
            StateMachine.Fire(door_Triggers.Close);
            ComboBox combobox = Application.OpenForms["Main"].Controls["comboBoxMeals"] as ComboBox;
            combobox.Enabled = false;
            PictureBox t = Application.OpenForms["Main"].Controls["pictureBoxDoor"] as PictureBox;
            t.ImageLocation = "images/Microwave.jpg";

            music.SoundLocation = "sounds/MicrowaveCloseSound_.wav";
            music.Play();
            
        }
    }
}
