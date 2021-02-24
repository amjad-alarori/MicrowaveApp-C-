
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
            this.StateTextBox = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxFood
            // 
            this.pictureBoxFood.Location = new System.Drawing.Point(960, 302);
            this.pictureBoxFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxFood.Name = "pictureBoxFood";
            this.pictureBoxFood.Size = new System.Drawing.Size(248, 255);
            this.pictureBoxFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFood.TabIndex = 1;
            this.pictureBoxFood.TabStop = false;
            this.pictureBoxFood.Click += new System.EventHandler(this.pictureBoxFood_Click);
            // 
            // pictureBoxLamp
            // 
            this.pictureBoxLamp.Location = new System.Drawing.Point(960, 2);
            this.pictureBoxLamp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLamp.Name = "pictureBoxLamp";
            this.pictureBoxLamp.Size = new System.Drawing.Size(248, 294);
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
            this.comboBoxMeals.Location = new System.Drawing.Point(754, 475);
            this.comboBoxMeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMeals.Name = "comboBoxMeals";
            this.comboBoxMeals.Size = new System.Drawing.Size(155, 24);
            this.comboBoxMeals.TabIndex = 0;
            this.comboBoxMeals.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(654, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(661, 511);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meal Status:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(203, 2);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(94, 22);
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
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(303, 370);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "+10";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(403, 370);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "-10";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBoxMeal
            // 
            this.textBoxMeal.Location = new System.Drawing.Point(754, 508);
            this.textBoxMeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMeal.Name = "textBoxMeal";
            this.textBoxMeal.ReadOnly = true;
            this.textBoxMeal.Size = new System.Drawing.Size(100, 22);
            this.textBoxMeal.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(338, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // num1
            // 
            this.num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num1.Location = new System.Drawing.Point(104, 96);
            this.num1.Margin = new System.Windows.Forms.Padding(4);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(92, 84);
            this.num1.TabIndex = 10;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = true;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num2.Location = new System.Drawing.Point(204, 96);
            this.num2.Margin = new System.Windows.Forms.Padding(4);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(92, 84);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = true;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num3
            // 
            this.num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num3.Location = new System.Drawing.Point(304, 96);
            this.num3.Margin = new System.Windows.Forms.Padding(4);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(92, 84);
            this.num3.TabIndex = 12;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = true;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num4
            // 
            this.num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num4.Location = new System.Drawing.Point(104, 188);
            this.num4.Margin = new System.Windows.Forms.Padding(4);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(92, 84);
            this.num4.TabIndex = 13;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = true;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num5
            // 
            this.num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num5.Location = new System.Drawing.Point(204, 188);
            this.num5.Margin = new System.Windows.Forms.Padding(4);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(92, 84);
            this.num5.TabIndex = 14;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = true;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num6
            // 
            this.num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num6.Location = new System.Drawing.Point(304, 188);
            this.num6.Margin = new System.Windows.Forms.Padding(4);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(92, 84);
            this.num6.TabIndex = 15;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = true;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num7
            // 
            this.num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num7.Location = new System.Drawing.Point(104, 280);
            this.num7.Margin = new System.Windows.Forms.Padding(4);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(92, 84);
            this.num7.TabIndex = 16;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = true;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num8
            // 
            this.num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num8.Location = new System.Drawing.Point(204, 280);
            this.num8.Margin = new System.Windows.Forms.Padding(4);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(92, 84);
            this.num8.TabIndex = 17;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = true;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // num9
            // 
            this.num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num9.Location = new System.Drawing.Point(304, 280);
            this.num9.Margin = new System.Windows.Forms.Padding(4);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(92, 84);
            this.num9.TabIndex = 18;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = true;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // num0
            // 
            this.num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num0.Location = new System.Drawing.Point(204, 372);
            this.num0.Margin = new System.Windows.Forms.Padding(4);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(92, 85);
            this.num0.TabIndex = 19;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = true;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // StateTextBox
            // 
            this.StateTextBox.Location = new System.Drawing.Point(12, 351);
            this.StateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.StateTextBox.Name = "StateTextBox";
            this.StateTextBox.Size = new System.Drawing.Size(274, 112);
            this.StateTextBox.TabIndex = 0;
            this.StateTextBox.Text = "";
            this.StateTextBox.TextChanged += new System.EventHandler(this.StateTextBox_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.num1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.num2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.num3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.num0, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button4, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.num4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button3, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.num9, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.num5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num8, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num6, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.num7, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(450, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 461);
            this.tableLayoutPanel1.TabIndex = 20;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 560);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.StateTextBox);
            this.Controls.Add(this.textBoxMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMeals);
            this.Controls.Add(this.pictureBoxLamp);
            this.Controls.Add(this.pictureBoxFood);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBoxFood;
        private System.Windows.Forms.PictureBox pictureBoxLamp;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.RichTextBox StateTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

