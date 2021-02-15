using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MicrowaveApp
{
    public partial class Form1 : Form
    {

        StateManager _stateManager;

        public Form1()
        {
            _stateManager = new StateManager();
            InitializeComponent();
            UpdateView();
        }

        public void UpdateView(object sender = null, EventArgs e = null)
        {
            // Show state info in textbox and write to console
            String info = String.Format("Microwave: {0}\n\nLamp: {1}\n\nDoor: {2}", _stateManager._microwave.ToString(), _stateManager._door.ToString(), _stateManager._lamp.ToString());
            this.StateTextBox.Text = info;
            Console.Write(info);


            // Verwijder alle buttons
            foreach (Button btn in this.Controls.OfType<Button>().ToList())
            {
                this.Controls.Remove(btn);
                btn.Dispose();
            }

            // Foreach permitted trigger for _microwave create new button, onclick runned de trigger
            foreach (var permittedTrigger in _stateManager._microwave.GetPermittedTriggers().Select((value, i) => new { i, value }))
            {
                Button button = new Button
                {
                    Location = new Point(673, 12 + (23 * permittedTrigger.i)),
                    Name = permittedTrigger.value.ToString(),
                    Size = new Size(115, 23),
                    Text = "Microwave: " + permittedTrigger.value.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClick);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }

            foreach (var permittedTrigger in _stateManager._door.GetPermittedTriggers().Select((value, i) => new { i, value }))
            {
                Button button = new Button
                {
                    Location = new Point(673, 100 + (23 * permittedTrigger.i)),
                    Name = permittedTrigger.value.ToString(),
                    Size = new Size(115, 23),
                    Text = "Door: " + permittedTrigger.value.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClick);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }

            foreach (var permittedTrigger in _stateManager._lamp.GetPermittedTriggers().Select((value, i) => new { i, value }))
            {
                Button button = new Button
                {
                    Location = new Point(673, 200 + (23 * permittedTrigger.i)),
                    Name = permittedTrigger.value.ToString(),
                    Size = new Size(115, 23),
                    Text = "Lamp: " + permittedTrigger.value.ToString(),
                    // Lamp is an internal element that can't and shouldn't be interacted with by the end user
                    Enabled = false,
                    UseVisualStyleBackColor = true,
                };
                button.Click += new EventHandler(HandleClick);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }
        }

        public void HandleClick(object sender, EventArgs e)
        {
            // 1. pak statemanager
            // 2. Zoekt hij de function via de button name
            // 3. Invoke, Run de function
            MethodInfo mi = _stateManager.GetType().GetMethod((sender as Button).Name);
            mi.Invoke(_stateManager, null);
        }
    }
}
