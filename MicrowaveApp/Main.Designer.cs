
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
            this.pictureBoxDoor = new System.Windows.Forms.PictureBox();
            this.pictureBoxFood = new System.Windows.Forms.PictureBox();
            this.pictureBoxLamp = new System.Windows.Forms.PictureBox();
            this.comboBoxMeals = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBoxMeal = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDoor
            // 
            this.pictureBoxDoor.ImageLocation = "images/Microwave.jpg";
            this.pictureBoxDoor.Location = new System.Drawing.Point(1, 1);
            this.pictureBoxDoor.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDoor.Name = "pictureBoxDoor";
            this.pictureBoxDoor.Size = new System.Drawing.Size(1, 1);
            this.pictureBoxDoor.TabIndex = 12;
            this.pictureBoxDoor.TabStop = false;
            this.pictureBoxDoor.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxDoor_Paint);
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.ImageLocation = "images/lamp_off.png";
            this.pictureBoxFood.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(1, 1);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 11;
            this.pictureBoxFood.TabStop = false;
            this.pictureBoxFood.Click += new System.EventHandler(this.pictureBoxFood_Click);
            this.pictureBoxFood.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxFood_Paint);
            // 
            // pictureBoxLamp
            // 
            this.pictureBoxLamp.ImageLocation = "images/lamp_off.png";
            this.pictureBoxLamp.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxLamp.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLamp.Name = "pictureBoxLamp";
            this.pictureBoxLamp.Size = new System.Drawing.Size(1, 1);
            this.pictureBoxLamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLamp.TabIndex = 2;
            this.pictureBoxLamp.TabStop = false;
            this.pictureBoxLamp.Click += new System.EventHandler(this.pictureBoxLamp_Click);
            this.pictureBoxLamp.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLamp_Paint);
            // 
            // comboBoxMeals
            // 
            this.comboBoxMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMeals.Enabled = false;
            this.comboBoxMeals.FormattingEnabled = true;
            this.comboBoxMeals.Items.AddRange(new object[] {
            "Burger",
            "Noodles",
            "Spaghetti"});
            this.comboBoxMeals.Location = new System.Drawing.Point(23, 46);
            this.comboBoxMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMeals.Name = "comboBoxMeals";
            this.comboBoxMeals.Size = new System.Drawing.Size(144, 24);
            this.comboBoxMeals.TabIndex = 0;
            this.comboBoxMeals.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meal Status:";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Location = new System.Drawing.Point(734, 14);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBoxMeal
            // 
            this.textBoxMeal.Location = new System.Drawing.Point(23, 102);
            this.textBoxMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMeal.Name = "textBoxMeal";
            this.textBoxMeal.ReadOnly = true;
            this.textBoxMeal.Size = new System.Drawing.Size(144, 22);
            this.textBoxMeal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(15, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(667, 615);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num1.Location = new System.Drawing.Point(711, 74);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(40, 34);
            this.num1.TabIndex = 10;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num2.Location = new System.Drawing.Point(761, 74);
            this.num2.Margin = new System.Windows.Forms.Padding(4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(40, 34);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num3.Location = new System.Drawing.Point(809, 74);
            this.num3.Margin = new System.Windows.Forms.Padding(4);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(40, 34);
            this.num3.TabIndex = 12;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num4.Location = new System.Drawing.Point(711, 116);
            this.num4.Margin = new System.Windows.Forms.Padding(4);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(40, 34);
            this.num4.TabIndex = 13;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num5.Location = new System.Drawing.Point(761, 116);
            this.num5.Margin = new System.Windows.Forms.Padding(4);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(40, 34);
            this.num5.TabIndex = 14;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num6.Location = new System.Drawing.Point(809, 116);
            this.num6.Margin = new System.Windows.Forms.Padding(4);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(40, 34);
            this.num6.TabIndex = 15;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num7.Location = new System.Drawing.Point(711, 158);
            this.num7.Margin = new System.Windows.Forms.Padding(4);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(40, 34);
            this.num7.TabIndex = 16;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num8.Location = new System.Drawing.Point(761, 158);
            this.num8.Margin = new System.Windows.Forms.Padding(4);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(40, 34);
            this.num8.TabIndex = 17;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num9.Location = new System.Drawing.Point(809, 158);
            this.num9.Margin = new System.Windows.Forms.Padding(4);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(40, 34);
            this.num9.TabIndex = 18;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(253)))), ((int)(((byte)(252)))));
            this.num0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.num0.Location = new System.Drawing.Point(711, 200);
            this.num0.Margin = new System.Windows.Forms.Padding(4);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(90, 37);
            this.num0.TabIndex = 19;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // Clear
            // 
            this.Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(97)))), ((int)(((byte)(45)))));
            this.Clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(173)))));
            this.Clear.Location = new System.Drawing.Point(809, 200);
            this.Clear.Margin = new System.Windows.Forms.Padding(4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(40, 37);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "<--";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxMeals);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMeal);
            this.groupBox1.Location = new System.Drawing.Point(688, 266);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 134);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Meal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1500, 724);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxDoor);
            this.Controls.Add(this.pictureBoxFood);
            this.Controls.Add(this.pictureBoxLamp);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDoor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button Clear;

        #endregion


        private System.Windows.Forms.ComboBox comboBoxMeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBoxMeal;

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxLamp;
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxDoor;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

