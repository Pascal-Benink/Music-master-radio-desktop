using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Music_master_radio_desktop
{
    public partial class Form2 : Form
    {
        // Property to store the selected radio station
        public string SelectedRadioStation { get; private set; }
        public string SelectedRadioStationURL { get; private set; }
        public string SelectedRadioStationImg { get; private set; }
        public string SelectedRadioStationSelenuimURL { get; private set; }
        public Form2(string currentSelectedRadioStation, string currentSelectedRadioStationURL, string currentSelectedRadioStationImg, string currentSelectedRadioStationSelenuimURL)
        {
            InitializeComponent();
            if (currentSelectedRadioStation == "100%NL")
            {
                radioButton1.Checked = true;
                SelectedRadioStationURL = currentSelectedRadioStationURL;
                SelectedRadioStationImg = currentSelectedRadioStationImg;
                SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
            }
            else if (currentSelectedRadioStation == "Radio 10")
            {
                radioButton2.Checked = true;
                SelectedRadioStationURL = currentSelectedRadioStationURL;
                SelectedRadioStationImg = currentSelectedRadioStationImg;
                SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
            }
            else if (currentSelectedRadioStation == "Sky Radio")
            {
                radioButton3.Checked = true;
                SelectedRadioStationURL = currentSelectedRadioStationURL;
                SelectedRadioStationImg = currentSelectedRadioStationImg;
                SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
            }
            else if (currentSelectedRadioStation == "RTV Rijnmond")
            {
                radioButton4.Checked = true;
                SelectedRadioStationURL = currentSelectedRadioStationURL;
                SelectedRadioStationImg = currentSelectedRadioStationImg;
                SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
            }
            else
            {
                radioButton5.Checked = true;
                SelectedRadioStationURL = currentSelectedRadioStationURL;
                SelectedRadioStationImg = currentSelectedRadioStationImg;
                SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
            }

            SelectedRadioStation = currentSelectedRadioStation;
            radio_Name_Label.Text = currentSelectedRadioStation;
            SelectedRadioStationURL = currentSelectedRadioStationURL;
            SelectedRadioStationImg = currentSelectedRadioStationImg;
            SelectedRadioStationSelenuimURL = currentSelectedRadioStationSelenuimURL;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // Set the selected radio station based on user choice
            if (radioButton1.Checked)
            {
                SelectedRadioStation = "100%NL";
                SelectedRadioStationURL = "https://stream.100p.nl/100pctnl.mp3";
                SelectedRadioStationImg = "RadioIcons/100pnl.png";
                SelectedRadioStationSelenuimURL = "http://100p.nl";
            }
            else if (radioButton2.Checked)
            {
                SelectedRadioStation = "Radio 10";
                SelectedRadioStationURL = "https://25333.live.streamtheworld.com/RADIO10.mp3";
                SelectedRadioStationImg = "RadioIcons/radio10.png";
                SelectedRadioStationSelenuimURL = "https://www.radio10.nl/";
            }
            else if (radioButton3.Checked)
            {
                SelectedRadioStation = "Sky Radio";
                SelectedRadioStationURL = "https://22723.live.streamtheworld.com/SKYRADIO.mp3";
                SelectedRadioStationImg = "RadioIcons/skyradio.png";
                SelectedRadioStationSelenuimURL = "https://www.skyradio.nl/";
            }
            else if (radioButton4.Checked)
            {
                SelectedRadioStation = "RTV Rijnmond";
                SelectedRadioStationURL = "http://d2e9xgjjdd9cr5.cloudfront.net/icecast/rijnmond/radio-mp3";
                SelectedRadioStationImg = "RadioIcons/rtvrijnmond.png";
                SelectedRadioStationSelenuimURL = "https://www.radio-nederland.nl/radio-rijnmond";
            }
            else if (radioButton5.Checked)
            {
                SelectedRadioStation = textBox1.Text;
                SelectedRadioStationURL = textBox2.Text;
                SelectedRadioStationImg = "RadioIcons/other.png";
                if (string.IsNullOrEmpty(SelectedRadioStationURL))
                {
                    MessageBox.Show("URL cannot be empty");
                    return;
                }
                if (string.IsNullOrEmpty(SelectedRadioStation))
                {
                    MessageBox.Show("Name cannot be empty");
                    return;
                }
            }

            // Set DialogResult to OK to indicate a successful selection
            DialogResult = DialogResult.OK;

            // Close the form
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Set DialogResult to Cancel to indicate cancellation
            DialogResult = DialogResult.Cancel;

            // Close the form
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radio_Name_Label.Text = "100%NL";
            }
            else if (radioButton2.Checked)
            {
                radio_Name_Label.Text = "Radio 10";
            }
            else if (radioButton3.Checked)
            {
                radio_Name_Label.Text = "Sky Radio";
            }
            else if (radioButton4.Checked)
            {
                radio_Name_Label.Text = "RTV Rijnmond";
            }
            else if (radioButton5.Checked)
            {
                radio_Name_Label.Text = textBox1.Text;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                radio_Name_Label.Text = textBox1.Text;
            }
        }
    }
}