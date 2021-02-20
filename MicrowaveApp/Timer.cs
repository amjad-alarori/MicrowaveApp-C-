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
            _timerElement.Enabled = false;
            _timerElement.Stop();
        }

        public void Tick(Meal selectedMeal)
        {
            ModifyTime(-1);
            selectedMeal.Tick();
        }

        public void ModifyTime(int offset)
        {
            _duration += offset;

            if (_duration < 0)
            {
                _duration = 0;
                Stop();
            }

            _timerTextBoxElement.Text = _duration.ToString();
        }
    }
}