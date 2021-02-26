using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MicrowaveApp.FoodElements;

namespace MicrowaveApp
{
    public partial class Main : Form
    {
        private readonly Burger _burger = new Burger();
        private readonly Noodles _noodles = new Noodles();
        private readonly Spaghetti _spaghetti = new Spaghetti();

        private Meal _selectedMeal;
        private readonly StateManager _stateManager;

        private readonly TimerWrapper _timerWrapper;
        private readonly ImageGenerator _imageGenerator;

        /// <summary>
        /// Dictionary to store Keyboard Keys as key and Button as value to use on keyboard click
        /// </summary>
        private readonly Dictionary<Keys, Button> _numpadDictionary = new Dictionary<Keys, Button>();

        private readonly List<Button> _stateButtons = new List<Button>();

        public Main()
        {
            InitializeComponent();
            _timerWrapper = new TimerWrapper(timer1, textBox1);
            _stateManager = new StateManager(_timerWrapper);

            // Listen to stopEvent. When created stop microwave and update view
            _timerWrapper.StopEvent += () =>
            {
                _stateManager.Microwave.Stop();
                UpdateView();
            };

            _imageGenerator = new ImageGenerator(pictureBox1);

            _selectedMeal = _burger;

            UpdateView();
            BuildNumpadDictionary();
        }

        private void BuildNumpadDictionary()
        {
            // Add all keys to numpadDictionary with button that belongs to that key
            _numpadDictionary.Add(Keys.D0, num0);
            _numpadDictionary.Add(Keys.D1, num1);
            _numpadDictionary.Add(Keys.D2, num2);
            _numpadDictionary.Add(Keys.D3, num3);
            _numpadDictionary.Add(Keys.D4, num4);
            _numpadDictionary.Add(Keys.D5, num5);
            _numpadDictionary.Add(Keys.D6, num6);
            _numpadDictionary.Add(Keys.D7, num7);
            _numpadDictionary.Add(Keys.D8, num8);
            _numpadDictionary.Add(Keys.D9, num9);
            _numpadDictionary.Add(Keys.NumPad0, num0);
            _numpadDictionary.Add(Keys.NumPad1, num1);
            _numpadDictionary.Add(Keys.NumPad2, num2);
            _numpadDictionary.Add(Keys.NumPad3, num3);
            _numpadDictionary.Add(Keys.NumPad4, num4);
            _numpadDictionary.Add(Keys.NumPad5, num5);
            _numpadDictionary.Add(Keys.NumPad6, num6);
            _numpadDictionary.Add(Keys.NumPad7, num7);
            _numpadDictionary.Add(Keys.NumPad8, num8);
            _numpadDictionary.Add(Keys.NumPad9, num9);
        }

        /// <summary>
        /// This method is used to show and handle the main state buttons.
        /// It creates buttons with triggers that are allowed to run
        /// </summary>
        private void UpdateView(object sender = null, EventArgs e = null)
        {
            // Delete all old buttons that are used to change state
            _stateButtons.ForEach(button => {
                Controls.Remove(button);
                button.Dispose();
            });

            // Keep track of Button Y position to place buttons under each other
            int buttonY = 330;
            
            // Foreach permitted trigger for _microwave, create new button and add 2 onclicks. One to re fire this UpdateView method and one the handle the
            // code that should run
            foreach (var permittedTrigger in _stateManager.Microwave.StateMachine.GetPermittedTriggers()
                .Select((trigger, index) => new {index, trigger}))
            {
                Button button = new Button
                {
                    Location = new Point(530, buttonY),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "Microwave: " + permittedTrigger.trigger
                };
                button.Click += HandleClickMicrowaveButton;
                button.Click += UpdateView;
                Controls.Add(button);
                _stateButtons.Add(button);
                buttonY += 27;
            }

            foreach (var permittedTrigger in _stateManager.Door.StateMachine.GetPermittedTriggers()
                .Select((trigger, index) => new {index, trigger}))
            {
                Button button = new Button
                {
                    Location = new Point(530, buttonY),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "Door: " + permittedTrigger.trigger
                };
                button.Click += HandleClickDoorButton;
                button.Click += UpdateView;
                Controls.Add(button);
                _stateButtons.Add(button);
                buttonY += 27;
            }
        }

        // Onclick method used on microwavebuttons
        private void HandleClickMicrowaveButton(object sender, EventArgs e)
        {
            MethodInfo methodInfo = _stateManager.Microwave.GetType().GetMethod((sender as Button).Name);
            methodInfo.Invoke(_stateManager.Microwave, null);
        }

        // Onclick method used on doorbuttons
        private void HandleClickDoorButton(object sender, EventArgs e)
        {
            MethodInfo methodInfo = _stateManager.Door.GetType().GetMethod((sender as Button).Name);
            methodInfo.Invoke(_stateManager.Door, null);
        }

        // On meal dropdown change. Change _selectedMeal and update image
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxMeals.SelectedIndex)
            {
                case 0:
                    _selectedMeal = _burger;
                    break;
                case 1:
                    _selectedMeal = _noodles;
                    break;
                case 2:
                    _selectedMeal = _spaghetti;
                    break;
            }

            pictureBoxFood.ImageLocation = _selectedMeal.ImagePath;
        }

        /// On internal timer tick, Tick the TimerWrapper and update meal state info
        private void timer1_Tick(object sender, EventArgs e)
        {
            _timerWrapper.Tick(_selectedMeal);
            textBoxMeal.Text = _selectedMeal.GetStateWithEmoji();
        }

        // On image change update _imageGenerator value to re gen new image
        private void pictureBoxDoor_Paint(object sender, PaintEventArgs e)
        {
            _imageGenerator.MicrowaveImage = pictureBoxDoor.ImageLocation;
        }

        // On image change update _imageGenerator value to re gen new image
        private void pictureBoxFood_Paint(object sender, PaintEventArgs e)
        {
            _imageGenerator.FoodImage = pictureBoxFood.ImageLocation;
        }

        // On image change update _imageGenerator value to re gen new image
        private void pictureBoxLamp_Paint(object sender, PaintEventArgs e)
        {
            _imageGenerator.LampImage = pictureBoxLamp.ImageLocation;
        }

        /// <summary>
        /// Processes a command key.
        /// https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.form.processcmdkey?view=net-5.0
        /// </summary>
        /// <param name="msg">A Message, passed by reference, that represents the Win32 message to process.</param>
        /// <param name="keyData">This value represents the key that we pressed on the keyboard</param>
        /// <returns>bool</returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // If key is in dictionary. Go inside if
            if (_numpadDictionary.ContainsKey(keyData))
            {
                // Find button with the key. Then perform click on the button
                _numpadDictionary[keyData].PerformClick();
            }

            // Handle default method behavior
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // On number button click. Add number to timer text and change internal timer _duration
        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On number button click. Add number to timer text and change internal timer _duration
        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
            _timerWrapper.ModifyTime(textBox1.Text);
        }
        
        // On clear button click. Clear timer input
        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            _timerWrapper.ModifyTime("0");
        }
    }
}