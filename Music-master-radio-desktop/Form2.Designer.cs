﻿namespace Music_master_radio_desktop
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            radio_Name_Label = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(455, 25);
            label1.TabIndex = 0;
            label1.Text = "Sellect a Radio staton or put in your own URL and name";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(12, 103);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(103, 29);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "100%NL";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(12, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(108, 29);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Radio 10";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(12, 173);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(116, 29);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Sky Radio";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(12, 208);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(149, 29);
            radioButton4.TabIndex = 4;
            radioButton4.TabStop = true;
            radioButton4.Text = "RTV Rijnmond";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(12, 241);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(154, 29);
            radioButton5.TabIndex = 5;
            radioButton5.TabStop = true;
            radioButton5.Text = "Custom Radio:";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButtons_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 273);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 6;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 298);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 7;
            label3.Text = "URL: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(81, 270);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(360, 31);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(81, 307);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(360, 31);
            textBox2.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(12, 351);
            button1.Name = "button1";
            button1.Size = new Size(450, 44);
            button1.TabIndex = 10;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 401);
            button2.Name = "button2";
            button2.Size = new Size(450, 44);
            button2.TabIndex = 11;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 43);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 12;
            label4.Text = "Selected Radio:";
            // 
            // radio_Name_Label
            // 
            radio_Name_Label.AutoSize = true;
            radio_Name_Label.Location = new Point(155, 43);
            radio_Name_Label.Name = "radio_Name_Label";
            radio_Name_Label.Size = new Size(87, 25);
            radio_Name_Label.TabIndex = 13;
            radio_Name_Label.Text = "No Radio";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 450);
            Controls.Add(radio_Name_Label);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(radioButton5);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(496, 506);
            MinimizeBox = false;
            MinimumSize = new Size(496, 506);
            Name = "Form2";
            Text = "Radio Decider - MusicMaster Radio";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label4;
        private Label radio_Name_Label;
    }
}