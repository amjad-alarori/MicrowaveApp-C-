using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MicrowaveApp.Food;

namespace MicrowaveApp
{
    public partial class Main : Form
    {
        // variable Chicken, Dat is een nieuwe chicken
        Chicken Chicken = new Chicken();
        Meat Meat = new Meat();
        Doner Doner = new Doner();
        Meal SelectedMeal;
        StateManager _stateManager;
        private TimerWrapper _timerWrapper;

        public Main()
        {
            InitializeComponent();
            _timerWrapper = new TimerWrapper(timer1, textBox1);
            _stateManager = new StateManager(_timerWrapper);
            SelectedMeal = Chicken;
            UpdateView();

        }

        public void UpdateView(object sender = null, EventArgs e = null)
        {
            // Show state info in textbox and write to console
            String info = String.Format("Microwave: {0}\n\nLamp: {1}\n\nDoor: {2}\n\n", _stateManager._microwave.StateMachine.ToString(), _stateManager._lamp.StateMachine.ToString(), _stateManager._door.StateMachine.ToString());
            this.StateTextBox.Text = info;
            Console.Write(info);

            // Verwijder alle buttons
            foreach (Button btn in this.Controls.OfType<Button>().ToList())
            {
                if (btn.Text.ToString().Contains("~"))
                {
                    this.Controls.Remove(btn);
                    btn.Dispose();
                }
            }

            // Foreach permitted trigger for _microwave create new button, onclick runned de trigger
            foreach (var permittedTrigger in _stateManager._microwave.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(1000, 12 + (23 * permittedTrigger.index)),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "~Microwave: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClickMicrowave);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }

            foreach (var permittedTrigger in _stateManager._door.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(1000, 100 + (23 * permittedTrigger.index)),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "~Door: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClickDoor);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }

            //foreach (var permittedTrigger in _stateManager._lamp.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            //{
            //    Button button = new Button
            //    {
            //        Location = new Point(673, 200 + (23 * permittedTrigger.index)),
            //        Name = permittedTrigger.trigger.ToString(),
            //        Size = new Size(115, 23),
            //        Text = "Lamp: " + permittedTrigger.trigger.ToString(),
            //        UseVisualStyleBackColor = true,
            //    };
            //    button.Click += (object a, EventArgs b) => _stateManager._lamp.StateMachine.Fire(permittedTrigger.trigger);
            //    button.Click += new EventHandler(UpdateView);
            //    this.Controls.Add(button);
            //}
        }

        public void HandleClickMicrowave(object sender, EventArgs e)
        {
            MethodInfo mi = _stateManager._microwave.GetType().GetMethod((sender as Button).Name);
            mi.Invoke(_stateManager._microwave, null);
        }

        public void HandleClickDoor(object sender, EventArgs e)
        {
            MethodInfo mi = _stateManager._door.GetType().GetMethod((sender as Button).Name);
            mi.Invoke(_stateManager._door, null);
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMeals.SelectedIndex)
            {
                case 0:
                {
                    SelectedMeal = Chicken;
                    break;
                }
                case 1:
                {
                    SelectedMeal = Meat;
                    break;
                }
                case 2:
                {
                    SelectedMeal = Doner;
                    break;
                }
            }

            pictureBoxFood.ImageLocation = SelectedMeal.ImagePath;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerWrapper.Tick(SelectedMeal);
            textBoxMeal.Text = SelectedMeal.StateMachine.State.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            _timerWrapper.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _timerWrapper.Stop();
        }

        // Button that adds 10 seconds to the timer
        private void button3_Click_1(object sender, EventArgs e)
        {
            _timerWrapper.ModifyTime(10);
        }

        // Button that removes 10 seconds from the timer
        private void button4_Click(object sender, EventArgs e)
        {
            _timerWrapper.ModifyTime(-10);
        }

        private void pictureBoxFood_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxLamp_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}