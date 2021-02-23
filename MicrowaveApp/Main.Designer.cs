
namespace MicrowaveApp
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.StateTextBox = new System.Windows.Forms.RichTextBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.pictureBoxLamp = new System.Windows.Forms.PictureBox();
            this.comboBoxMeals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBoxMeal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(-172, 2);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(888, 457);
            this.StateTextBox.TabIndex = 0;
            this.StateTextBox.Text = "";
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(720, 245);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(186, 207);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 1;
            this.pictureBoxFood.TabStop = false;
            this.pictureBoxFood.Click += new System.EventHandler(this.pictureBoxFood_Click);
            // 
            // pictureBoxLamp
            // 
            this.pictureBoxLamp.Location = new System.Drawing.Point(720, 2);
            this.pictureBoxLamp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBoxLamp.Name = "pictureBoxLamp";
            this.pictureBoxLamp.Size = new System.Drawing.Size(186, 239);
            this.pictureBoxLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLamp.TabIndex = 2;
            this.pictureBoxLamp.TabStop = false;
            this.pictureBoxLamp.Click += new System.EventHandler(this.pictureBoxLamp_Click);
            // 
            // comboBoxMeals
            // 
            this.comboBoxMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeals.FormattingEnabled = true;
            this.comboBoxMeals.Items.AddRange(new object[] {
            "Chicken",
            "Meat",
            "Döner"});
            this.comboBoxMeals.Location = new System.Drawing.Point(524, 245);
            this.comboBoxMeals.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxMeals.Name = "comboBoxMeals";
            this.comboBoxMeals.Size = new System.Drawing.Size(117, 21);
            this.comboBoxMeals.TabIndex = 0;
            this.comboBoxMeals.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 245);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 296);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meal Status:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(524, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 96);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 5;
            this.button3.Text = "+10";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(574, 96);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 19);
            this.button4.TabIndex = 6;
            this.button4.Text = "-10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxMeal
            // 
            this.textBoxMeal.Location = new System.Drawing.Point(524, 293);
            this.textBoxMeal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxMeal.Name = "textBoxMeal";
            this.textBoxMeal.ReadOnly = true;
            this.textBoxMeal.Size = new System.Drawing.Size(76, 20);
            this.textBoxMeal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 455);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxMeal);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMeals);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBoxLamp);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.StateTextBox);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;


        #endregion


        private System.Windows.Forms.ComboBox comboBoxMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMeal;
        
        private System.Windows.Forms.RichTextBox StateTextBox;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxLamp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

