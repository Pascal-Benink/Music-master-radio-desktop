namespace Music_master_radio_desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            radio_name_label = new Label();
            radio_change = new Button();
            RadioImage = new PictureBox();
            Play = new Button();
            RadioImage2 = new PictureBox();
            Stop = new Button();
            Volume = new NumericUpDown();
            label2 = new Label();
            nowplaying = new Label();
            label4 = new Label();
            Muted = new Label();
            Mute = new Button();
            Unmute = new Button();
            music = new Label();
            label5 = new Label();
            resetlicense = new Button();
            button3 = new Button();
            notinuse = new Button();
            versionlabel = new Label();
            label6 = new Label();
            NewVersion = new Button();
            IgnoreUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)RadioImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RadioImage2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Volume).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(331, 321);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 2;
            label1.Text = "Current Radio:";
            // 
            // radio_name_label
            // 
            radio_name_label.AutoSize = true;
            radio_name_label.Location = new Point(462, 321);
            radio_name_label.Name = "radio_name_label";
            radio_name_label.Size = new Size(82, 25);
            radio_name_label.TabIndex = 3;
            radio_name_label.Text = "NoRadio";
            // 
            // radio_change
            // 
            radio_change.Location = new Point(-1, 325);
            radio_change.Name = "radio_change";
            radio_change.Size = new Size(328, 51);
            radio_change.TabIndex = 4;
            radio_change.Text = "Change Radio";
            radio_change.UseVisualStyleBackColor = true;
            radio_change.Click += radio_change_Click;
            // 
            // RadioImage
            // 
            RadioImage.Location = new Point(2, 2);
            RadioImage.Name = "RadioImage";
            RadioImage.Size = new Size(152, 69);
            RadioImage.TabIndex = 5;
            RadioImage.TabStop = false;
            // 
            // Play
            // 
            Play.Location = new Point(2, 119);
            Play.Name = "Play";
            Play.Size = new Size(325, 58);
            Play.TabIndex = 6;
            Play.Text = "Play";
            Play.UseVisualStyleBackColor = true;
            Play.Click += Play_Click;
            // 
            // RadioImage2
            // 
            RadioImage2.Location = new Point(2, 2);
            RadioImage2.Name = "RadioImage2";
            RadioImage2.Size = new Size(69, 69);
            RadioImage2.TabIndex = 7;
            RadioImage2.TabStop = false;
            // 
            // Stop
            // 
            Stop.Location = new Point(2, 183);
            Stop.Name = "Stop";
            Stop.Size = new Size(325, 58);
            Stop.TabIndex = 8;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Volume
            // 
            Volume.Location = new Point(528, 80);
            Volume.Name = "Volume";
            Volume.Size = new Size(127, 31);
            Volume.TabIndex = 9;
            Volume.Value = new decimal(new int[] { 100, 0, 0, 0 });
            Volume.ValueChanged += Volume_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 80);
            label2.Name = "label2";
            label2.Size = new Size(166, 25);
            label2.TabIndex = 10;
            label2.Text = "Now Playing Radio:";
            // 
            // nowplaying
            // 
            nowplaying.AutoSize = true;
            nowplaying.Location = new Point(173, 80);
            nowplaying.Name = "nowplaying";
            nowplaying.Size = new Size(44, 25);
            nowplaying.TabIndex = 11;
            nowplaying.Text = "N/A";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 86);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 12;
            label4.Text = "Volume:";
            // 
            // Muted
            // 
            Muted.AutoSize = true;
            Muted.Location = new Point(568, 52);
            Muted.Name = "Muted";
            Muted.Size = new Size(86, 25);
            Muted.TabIndex = 13;
            Muted.Text = "Unmuted";
            // 
            // Mute
            // 
            Mute.Location = new Point(334, 119);
            Mute.Name = "Mute";
            Mute.Size = new Size(325, 58);
            Mute.TabIndex = 14;
            Mute.Text = "Mute";
            Mute.UseVisualStyleBackColor = true;
            Mute.Click += Mute_Click;
            // 
            // Unmute
            // 
            Unmute.Location = new Point(334, 183);
            Unmute.Name = "Unmute";
            Unmute.Size = new Size(325, 58);
            Unmute.TabIndex = 15;
            Unmute.Text = "Unmute";
            Unmute.UseVisualStyleBackColor = true;
            Unmute.Click += Unmute_Click;
            // 
            // music
            // 
            music.AutoSize = true;
            music.Location = new Point(270, 2);
            music.Name = "music";
            music.Size = new Size(44, 25);
            music.TabIndex = 18;
            music.Text = "N/A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 2);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 17;
            label5.Text = "Now Playing:";
            // 
            // resetlicense
            // 
            resetlicense.Location = new Point(2, 386);
            resetlicense.Name = "resetlicense";
            resetlicense.Size = new Size(131, 40);
            resetlicense.TabIndex = 19;
            resetlicense.Text = "Reset License\r\n";
            resetlicense.UseVisualStyleBackColor = true;
            resetlicense.Click += resetlicense_Click;
            // 
            // button3
            // 
            button3.Location = new Point(2, 247);
            button3.Name = "button3";
            button3.Size = new Size(325, 72);
            button3.TabIndex = 20;
            button3.Text = "Update now playing";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // notinuse
            // 
            notinuse.Enabled = false;
            notinuse.Location = new Point(334, 247);
            notinuse.Name = "notinuse";
            notinuse.Size = new Size(325, 72);
            notinuse.TabIndex = 21;
            notinuse.UseVisualStyleBackColor = true;
            notinuse.Click += notinuse_Click;
            // 
            // versionlabel
            // 
            versionlabel.AutoSize = true;
            versionlabel.Location = new Point(337, 350);
            versionlabel.Name = "versionlabel";
            versionlabel.Size = new Size(146, 25);
            versionlabel.TabIndex = 22;
            versionlabel.Text = "Version: [version]";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 91);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 23;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // NewVersion
            // 
            NewVersion.Location = new Point(55, 146);
            NewVersion.Name = "NewVersion";
            NewVersion.Size = new Size(564, 68);
            NewVersion.TabIndex = 24;
            NewVersion.Text = "Version {tagName} of MusicMaster Is Out Click Here To Download\" +\r\n$\" You Rurrent version is {currentgithubversion}\r\n\r\n";
            NewVersion.UseVisualStyleBackColor = true;
            NewVersion.Visible = false;
            NewVersion.Click += NewVersion_Click;
            // 
            // IgnoreUpdate
            // 
            IgnoreUpdate.Location = new Point(250, 220);
            IgnoreUpdate.Name = "IgnoreUpdate";
            IgnoreUpdate.Size = new Size(164, 39);
            IgnoreUpdate.TabIndex = 25;
            IgnoreUpdate.Text = "Keep Old Version";
            IgnoreUpdate.UseVisualStyleBackColor = true;
            IgnoreUpdate.Visible = false;
            IgnoreUpdate.Click += IgnoreUpdate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 380);
            Controls.Add(IgnoreUpdate);
            Controls.Add(NewVersion);
            Controls.Add(label6);
            Controls.Add(versionlabel);
            Controls.Add(notinuse);
            Controls.Add(button3);
            Controls.Add(resetlicense);
            Controls.Add(music);
            Controls.Add(label5);
            Controls.Add(Unmute);
            Controls.Add(Mute);
            Controls.Add(Muted);
            Controls.Add(label4);
            Controls.Add(nowplaying);
            Controls.Add(label2);
            Controls.Add(Volume);
            Controls.Add(Stop);
            Controls.Add(RadioImage2);
            Controls.Add(Play);
            Controls.Add(RadioImage);
            Controls.Add(radio_change);
            Controls.Add(radio_name_label);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(684, 487);
            MinimumSize = new Size(684, 436);
            Name = "Form1";
            Text = "MusicMaster Radio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RadioImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)RadioImage2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Volume).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label radio_name_label;
        private Button radio_change;
        private PictureBox RadioImage;
        private Button Play;
        private PictureBox RadioImage2;
        private Button Stop;
        private NumericUpDown Volume;
        private Label label2;
        private Label nowplaying;
        private Label label4;
        private Label Muted;
        private Button Mute;
        private Button Unmute;
        private Button NewVersion;
        private Label music;
        private Label label5;
        private Button resetlicense;
        private Button button3;
        private Button notinuse;
        private Label versionlabel;
        private Label label6;
        private Button IgnoreUpdate;
    }
}