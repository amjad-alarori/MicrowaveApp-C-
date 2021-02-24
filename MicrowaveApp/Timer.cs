using System;
using System.Linq;
using System.Windows.Forms;

namespace MicrowaveApp
{
    // Todo:: Rename to better class name.
    public class TimerWrapper
    {
        private int _duration = 0;
        
        private Timer _timerElement;
        private TextBox _timerTextBoxElement;

        public TimerWrapper(Timer timer, TextBox textBox)
        {
            _timerElement = timer;
            _timerTextBoxElement = textBox;
        }

        public void Start()
        {
            _timerElement.Enabled = true;
            _timerElement.Start();
        }

        public void Stop()
        {
            // Todo:: Check if setting enabled false is required / needed.
            //if the timerElement.Enabled is true run _timerElement.Stop()
            // If click stop while timer is enabled (running) stop timer and disable timer
            if (_timerElement.Enabled)
            {
                _timerElement.Enabled = false;
                _timerElement.Stop();
            }
            //else if timer was(is?) enabled reset the int _duration to 0
            // else if timer is stopped and click stop again. reset time and reenable timer
            else
            {
                
                _timerElement.Enabled = true;
                _duration = 0;
            }
        }

        public void Tick(Meal selectedMeal)
        {
            
            ModifyTime(_duration -1);
            selectedMeal.Tick();
        }

        public void ModifyTime(int duration)
        {
            _duration = duration;
            

            if (_duration < 0)
            {
                _duration = 0;
                Stop();
            }

            _timerTextBoxElement.Text = _duration.ToString();
        }

        // need to make a new function to make numpad numpad function properly
        public void ButtonInput()
        {

        }
    }
}