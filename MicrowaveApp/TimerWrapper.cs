using System;
using System.Windows.Forms;
using System.Media;

namespace MicrowaveApp
{
    public class TimerWrapper
    {
        private int _duration;
        private readonly Timer _timerElement;
        private readonly TextBox _timerTextBoxElement;
        private readonly SoundPlayer _soundPlayer = new SoundPlayer("sounds/Ping.wav");

        /// <summary>
        /// Create event to listen when event is Invoked
        /// </summary>
        public event Action StopEvent;

        public TimerWrapper(Timer timer, TextBox textBox)
        {
            _timerElement = timer;
            _timerTextBoxElement = textBox;
        }

        /// <summary>
        /// Enable timer and start counting down
        /// </summary>
        public void Start()
        {
            _timerElement.Enabled = true;
            _timerElement.Start();
        }

        /// <summary>
        /// Stop all timer activities
        /// </summary>
        /// <param name="triggerEvent">Trigger StopEvent based on bool value</param>
        public void Stop(bool triggerEvent = true)
        {
            // If clicked stop while timer is enabled (running) stop timer and disable timer
            if (_timerElement.Enabled)
            {
                _timerElement.Enabled = false;
                _timerElement.Stop();
            }
            // else if timer is stopped and clicked stop again. reset time and reenable timer
            else
            {
                _timerElement.Enabled = true;
                _duration = 0;
            }

            if (triggerEvent)
            {
                StopEvent?.Invoke();
            }
        }

        /// <summary>
        /// Tick function is ran every second when the timer is counting down (Enabled | Active)
        /// </summary>
        /// <param name="selectedMeal">Selected meal class to modify internal _cookingTime</param>
        public void Tick(Meal selectedMeal)
        {
            ModifyTime((_duration -= 1).ToString());
            selectedMeal.Tick();
        }

        /// <summary>
        /// Modifies the internal time and validates current time
        /// </summary>
        /// <param name="duration">Sets internal duration with passed input</param>
        public void ModifyTime(string duration)
        {
            if (!int.TryParse(duration, out var result)) return;
            _duration = result;

            // If duration is than 0, stop microwave / timer and play done sound
            if (_duration < 0)
            {
                _duration = 0;
                Stop();
                _soundPlayer.Play();
            }

            _timerTextBoxElement.Text = _duration.ToString();
        }
    }
}