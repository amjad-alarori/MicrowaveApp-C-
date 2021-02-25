﻿using System;
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

        }

        public void UpdateView(object sender = null, EventArgs e = null)
        {
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

        // Button that adds 10 seconds to the timer
        private void button3_Click_1(object sender, EventArgs e)
        {
            _timerWrapper.ModifyTime(1);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void StateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void num5_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "5";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
        }
        
        private void num1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text += "1";
            if (int.TryParse(textBox1.Text, out var result))
            {
                _timerWrapper.ModifyTime(result);
            }
            
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}