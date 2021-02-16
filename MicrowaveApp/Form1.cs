using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
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

        //public List<object> list;

        public void UpdateView(object sender = null, EventArgs e = null)
        {
            // Show state info in textbox and write to console
            String info = String.Format("Microwave: {0}\n\nLamp: {1}\n\nDoor: {2}\n\n", _stateManager._microwave.StateMachine.ToString(), _stateManager._lamp.StateMachine.ToString(), _stateManager._door.StateMachine.ToString());
            this.StateTextBox.Text = info;
            Console.Write(info);

            this.pictureBox1.Load("https://avatars.githubusercontent.com/u/13196280?s=64&v=4");

            // Verwijder alle buttons
            foreach (Button btn in this.Controls.OfType<Button>().ToList())
            {
                this.Controls.Remove(btn);
                btn.Dispose();
            }

            // Foreach permitted trigger for _microwave create new button, onclick runned de trigger
            foreach (var permittedTrigger in _stateManager._microwave.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(673, 12 + (23 * permittedTrigger.index)),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "Microwave: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += (object a, EventArgs b) => _stateManager._microwave.StateMachine.Fire(permittedTrigger.trigger);
                button.Click += new EventHandler(UpdateView);
                this.Controls.Add(button);
            }

            foreach (var permittedTrigger in _stateManager._door.StateMachine.GetPermittedTriggers().Select((trigger, index) => new { index, trigger }))
            {
                Button button = new Button
                {
                    Location = new Point(673, 100 + (23 * permittedTrigger.index)),
                    Name = permittedTrigger.trigger.ToString(),
                    Size = new Size(115, 23),
                    Text = "Door: " + permittedTrigger.trigger.ToString(),
                    UseVisualStyleBackColor = true,
                };
                button.Click += (object a, EventArgs b) => _stateManager._door.StateMachine.Fire(permittedTrigger.trigger);
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

        //public void RenderButton()
        //{
        //    list.ForEach(permittedTrigger =>
        //    {
        //        var test = permittedTrigger;
        //        Button button = new Button
        //        {
        //            Location = new Point(673, 12 + (23 * index)),
        //            Name = test.ToString(),
        //            Size = new Size(115, 23),
        //            Text = "Microwave: " + test.ToString(),
        //            UseVisualStyleBackColor = true,
        //        };
        //        button.Click += (object a, EventArgs b) => _stateManager._microwave.StateMachine.Fire(test);
        //        button.Click += new EventHandler(UpdateView);
        //        this.Controls.Add(button);
        //    }
        //    );
        //    //Button button = new Button
        //    //{
        //    //    Location = new Point(673, 12 + (23 * permittedTrigger.i)),
        //    //    Name = permittedTrigger.value.ToString(),
        //    //    Size = new Size(115, 23),
        //    //    Text = "Microwave: " + permittedTrigger.value.ToString(),
        //    //    UseVisualStyleBackColor = true,
        //    //};
        //    //button.Click += (object a, EventArgs b) => _stateManager._microwave.StateMachine.Fire(permittedTrigger.value);
        //    //button.Click += new EventHandler(UpdateView);
        //    //this.Controls.Add(button);
        //}

    }
}
