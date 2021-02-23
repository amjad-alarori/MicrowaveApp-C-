using System.Drawing;
using Stateless;
using System.Windows.Forms;
using System;

namespace MicrowaveApp
{

    public enum lamp_State
    {
        On,
        Off
    }

    public enum lamp_Triggers
    {
        TurnOn,
        TurnOff
    }

    class Lamp
    { 

        public StateMachine<lamp_State, lamp_Triggers> StateMachine;

        public Lamp()
        {
            StateMachine = new StateMachine<lamp_State, lamp_Triggers>(lamp_State.Off);

            StateMachine.Configure(lamp_State.Off)
                .Permit(lamp_Triggers.TurnOn, lamp_State.On);

            StateMachine.Configure(lamp_State.On)
                .Permit(lamp_Triggers.TurnOff, lamp_State.Off);
        }

        public void TurnOn()
        {
            if (StateMachine.CanFire(lamp_Triggers.TurnOn))
            {
                StateMachine.Fire(lamp_Triggers.TurnOn);
                PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
                pictureBoxLamp.ImageLocation = "images/lamp_on.png";
            }
        }

        public void TurnOff()
        {
            if (StateMachine.CanFire(lamp_Triggers.TurnOff))
            {
                StateMachine.Fire(lamp_Triggers.TurnOff);

                PictureBox pictureBoxLamp = Application.OpenForms["Main"].Controls["pictureBoxLamp"] as PictureBox;
                pictureBoxLamp.ImageLocation = "images/lamp_off.png";
            }
        }

    }
}
