using System;
using System.Collections.Generic;
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
        Burger Burger = new Burger();
        Noodles Noodles = new Noodles();
        Spaghetti Spaghetti = new Spaghetti();
        Meal SelectedMeal;
        StateManager _stateManager;
        private TimerWrapper _timerWrapper;
        private ImageGenerator _imageGenerator;

        /// <summary>
        /// Dictionary waarin we via key (Keys) value (Button) de button kunnen vinden via de key
        /// </summary>
        private Dictionary<Keys, Button> numpadDictionary = new Dictionary<Keys, Button>();

        private List<Button> stateButtons = new List<Button>();

        public Main()
        {
            InitializeComponent();
            _timerWrapper = new TimerWrapper(timer1, textBox1);
            _stateManager = new StateManager(_timerWrapper);

            // Listen to stopEvent. When created stop microwave and update view
            _timerWrapper.StopEvent += () =>
            {
                //_stateManager._microwave.Pause();
                _stateManager._microwave.Stop();
                UpdateView();
            };

            _imageGenerator = new ImageGenerator(pictureBox1);
            SelectedMeal = Burger;
            UpdateView();
            buildNumpadDictionary();
        }
        public void buildNumpadDictionary()
        {
            // Add all keys to numpadDictionary with button that belongs to that key
            numpadDictionary.Add(Keys.D0, num0);
            numpadDictionary.Add(Keys.D1, num1);
            numpadDictionary.Add(Keys.D2, num2);
            numpadDictionary.Add(Keys.D3, num3);
            numpadDictionary.Add(Keys.D4, num4);
            numpadDictionary.Add(Keys.D5, num5);
            numpadDictionary.Add(Keys.D6, num6);
            numpadDictionary.Add(Keys.D7, num7);
            numpadDictionary.Add(Keys.D8, num8);
            numpadDictionary.Add(Keys.D9, num9);
            numpadDictionary.Add(Keys.NumPad0, num0);
            numpadDictionary.Add(Keys.NumPad1, num1);
            numpadDictionary.Add(Keys.NumPad2, num2);
            numpadDictionary.Add(Keys.NumPad3, num3);
            numpadDictionary.Add(Keys.NumPad4, num4);
            numpadDictionary.Add(Keys.NumPad5, num5);
            numpadDictionary.Add(Keys.NumPad6, num6);
            numpadDictionary.Add(Keys.NumPad7, num7);
            numpadDictionary.Add(Keys.NumPad8, num8);
            numpadDictionary.Add(Keys.NumPad9, num9);
        }

        public void UpdateView(object sender = null, EventArgs e = null)
        {
            // Verwijder alle buttons
            foreach (Button btn in stateButtons)
            {
                this.Controls.Remove(btn);
                btn.Dispose();
            }

            int ButtonX = 530;
            int ButtonY = 330;

            // Foreach permitted trigger for _microwave create new button, onclick runned de trigger
            foreach (var permittedTrigger in _stateManager._microwave.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(ButtonX, ButtonY),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23), 
                    Text = "Microwave: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClickMicrowave);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
                ButtonY += 27;
                stateButtons.Add(button);
            }

            foreach (var permittedTrigger in _stateManager._door.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(ButtonX, ButtonY),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "Door: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClickDoor);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
                ButtonY += 27;
                stateButtons.Add(button);
            }
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
                        SelectedMeal = Burger;
                        break;
                    }
                case 1:
                    {
                        SelectedMeal = Noodles;
                        break;
                    }
                case 2:
                    {
                        SelectedMeal = Spaghetti;
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

        private void pictureBoxDoor_Paint(object sender, PaintEventArgs e)
        {
            _imageGenerator.MicrowaveImage = pictureBoxDoor.ImageLocation;
        }

        private void pictureBoxFood_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(pictureBoxFood.ImageLocation);
            _imageGenerator.FoodImage = pictureBoxFood.ImageLocation;
        }

        private void pictureBoxLamp_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine(pictureBoxLamp.ImageLocation);
            _imageGenerator.LampImage = pictureBoxLamp.ImageLocation;

        }

        private void num5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        public void num1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }
        /// <summary>
        /// Processes a command key.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.processcmdkey?view=net-5.0
        /// </summary>
        /// todo look up msg
        /// <param name="msg">A Message, passed by reference, that represents the Win32 message to process.</param>
        /// <param name="keyData">This value represents the key that we pressed on the keyboard</param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // If key is in dictionary. Go inside if
            if (numpadDictionary.ContainsKey(keyData))
            {
                // Find button with the key. Then perform click on the button
                numpadDictionary[keyData].PerformClick();

            }

            // Handle default method behavior
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void num3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "3";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "4";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "6";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "2";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "7";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "8";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "9";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void num0_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "0";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Clear_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
        }
    }
}