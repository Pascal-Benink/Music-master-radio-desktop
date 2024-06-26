

using MusicMaster2._0;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection;
using System.Security.Policy;
using System.Text.RegularExpressions;
using Timer = System.Windows.Forms.Timer;

namespace Music_master_radio_desktop
{
    public partial class Form1 : Form
    {
        private AudioPlayer audioPlayer = new AudioPlayer();

        public string Radio = "No Radio";

        public string Url = "";

        private string seleniumUrl = "";

        public string Radioimg = "RadioIcons/other.png";

        private Timer _timer;

        private bool IsTimerActive = false;
        public Form1()
        {
            InitializeComponent();
            SetVersion();
            GetLatestRelease();
            RadioImage.Visible = false;
            RadioImage2.Visible = true;
            System.Drawing.Image image = System.Drawing.Image.FromFile(Radioimg);
            RadioImage2.Image = image;
            RadioImage2.SizeMode = PictureBoxSizeMode.StretchImage;
            music.UseMnemonic = false;
        }

        private void SetVersion()
        {
            versionlabel.Text = "Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void radio_change_Click(object sender, EventArgs e)
        {
            if (IsTimerActive)
            {
                _timer.Stop();
            }
            string currentSelectedRadioStation = Radio;
            string currentSelectedRadioStationURL = Url;
            string currentSelectedRadioStationImg = Radioimg;
            string currentselectedRadioStationSelenuimURL = seleniumUrl;

            // Create an instance of the decision form and pass the current selected radio station
            Form2 decisionForm = new Form2(currentSelectedRadioStation, currentSelectedRadioStationURL, currentSelectedRadioStationImg, currentselectedRadioStationSelenuimURL);

            // Show the decision form as a dialog
            DialogResult result = decisionForm.ShowDialog();

            // Check the result from the decision form
            if (result == DialogResult.OK)
            {
                // Retrieve the newly selected radio station from the decision form
                string selectedRadioStation = decisionForm.SelectedRadioStation;
                string selectedRadioStationURL = decisionForm.SelectedRadioStationURL;
                string selectedRadioStationImg = decisionForm.SelectedRadioStationImg;
                string selectedRadioStationSelenuimURL = decisionForm.SelectedRadioStationSelenuimURL;

                // Do something with the selected radio station
                MessageBox.Show("Selected Radio Station: " + selectedRadioStation);

                if (!string.IsNullOrEmpty(selectedRadioStationURL) && !string.IsNullOrEmpty(selectedRadioStationURL))
                {
                    Radio = selectedRadioStation;
                    Url = selectedRadioStationURL;
                    radio_name_label.Text = Radio;
                    seleniumUrl = selectedRadioStationSelenuimURL;
                    System.Drawing.Image image = System.Drawing.Image.FromFile(selectedRadioStationImg);

                    if (image != null)
                    {
                        if (selectedRadioStationImg.Contains("other.png"))
                        {
                            RadioImage.Visible = false;
                            RadioImage2.Visible = true;
                            RadioImage2.Image = image;
                            RadioImage2.SizeMode = PictureBoxSizeMode.StretchImage;
                            label5.Visible = false;
                            music.Visible = false;
                        }
                        else
                        {
                            RadioImage.Visible = true;
                            RadioImage2.Visible = false;
                            RadioImage.Image = image;
                            RadioImage.SizeMode = PictureBoxSizeMode.StretchImage;
                            label5.Visible = true;
                            music.Visible = true;
                            OnStartApp();
                            InitializeTimer();
                        }

                    }
                    else
                    {
                        Debug.WriteLine("image is null");
                    }

                }
                else
                {
                    MessageBox.Show("You have not correctly chosen a radio, or there has been a error. Please try again");
                    Debug.WriteLine("radio: " + selectedRadioStation);
                    Debug.WriteLine("url: " + selectedRadioStationURL);
                    Debug.WriteLine("img" + selectedRadioStationURL);
                }
            }

            // Clean up resources
            decisionForm.Dispose();
        }
        // Play button
        private void Play_Click(object sender, EventArgs e)
        {
            audioPlayer.Play(Url);
            if (Url == "")
            {

            }
            else
            {
                radio_change.Enabled = false;
                nowplaying.Text = Radio;
            }
        }
        // Stop button
        private void Stop_Click(object sender, EventArgs e)
        {
            audioPlayer.Stop();
            radio_change.Enabled = true;
            nowplaying.Text = "N/A";
        }

        private void Mute_Click(object sender, EventArgs e)
        {
            SetMutedMute();
            audioPlayer.ChangeVolume(0);
        }

        private void Unmute_Click(object sender, EventArgs e)
        {
            decimal volume = Volume.Value;
            int volumeInt = Convert.ToInt32(volume);
            SetMutedUnmute();
            audioPlayer.ChangeVolume(volumeInt);
        }

        private void Volume_ValueChanged(object sender, EventArgs e)
        {
            decimal volume = Volume.Value;
            int volumeInt = Convert.ToInt32(volume);
            if (volumeInt == 0)
            {

                audioPlayer.ChangeVolume(volumeInt);
                SetMutedMute();
            }
            else
            {
                SetMutedUnmute();
                audioPlayer.ChangeVolume(volumeInt);
            }
        }

        private void SetMutedMute()
        {
            Muted.Text = "Muted";
        }

        private void SetMutedUnmute()
        {
            Muted.Text = "Unmuted";
        }

        // license
        private void Form1_Load(object sender, EventArgs e)
        {
            Debug.WriteLine(Settings.LicenseAccepted.ToString());
            if (!Settings.LicenseAccepted)
            {
                ShowLicenseForm();
            }
        }

        private void ShowLicenseForm()
        {
            LicenseForm licenseForm = new LicenseForm();
            licenseForm.ShowDialog(this);
            if (licenseForm.DialogResult == DialogResult.OK)
            {
                Settings.LicenseAccepted = true;
            }
            else
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings.Uninstall();
        }

        private void InitializeTimer()
        {
            _timer = new Timer();
            _timer.Interval = 30000; // 30 seconds
            _timer.Tick += new EventHandler(OnTimerTick);
            _timer.Start();
            IsTimerActive = true;
        }

        private async void OnTimerTick(object sender, EventArgs e)
        {
            Debug.WriteLine("go");
            string nowPlaying = await NowPlaying.GetRadioPlayingAsync(seleniumUrl);
            Debug.WriteLine($"{nowPlaying}");
            UpdateNowPlayingLabel(nowPlaying);
        }

        private async void OnStartApp()
        {
            string nowPlaying = await NowPlaying.GetRadioPlayingAsync(seleniumUrl);
            UpdateNowPlayingLabel(nowPlaying);
        }

        private void UpdateNowPlayingLabel(string nowPlaying)
        {
            Debug.WriteLine("updateing label");
            music.Text = nowPlaying;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string nowPlaying = await NowPlaying.GetRadioPlayingAsync(seleniumUrl);
            Debug.WriteLine($"{nowPlaying}");
            UpdateNowPlayingLabel(nowPlaying);
        }

        private void notinuse_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("i said not in use");
        }

        // version checker

        private async Task GetLatestRelease()
        {

            string apiUrl = "https://api.github.com/repos/Pascal-Benink/Music-master-radio-desktop/releases/latest";
            //apiUrl = "https://api.github.com/repos/Pascal-Benink/MusicMaster/releases/latest";
            string pastebinUrl = "https://pastebin.com/ZWcrq75N";
            string apiToken = "";

            using (var httpClient = new HttpClient())
            {
                try
                {
                    var response = await httpClient.GetAsync(pastebinUrl);
                    response.EnsureSuccessStatusCode(); // Ensure successful response

                    var htmlContent = await response.Content.ReadAsStringAsync();
                    apiToken = ExtractApiToken(htmlContent);
                    /*                    textBox1.Visible = true;
                                        textBox1.Text = apiToken;*/

                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Failed to retrieve text: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            using (HttpClient client = new HttpClient())
            {

                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiToken);
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (compatible; MSIE 11.0; Windows NT 10.0; WOW64; Trident/7.0)");

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string currentgithubversion = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                        Version currentgithubVersion;
                        Version tagNameVersion;

                        try
                        {
                            currentgithubVersion = new Version(currentgithubversion);
                        }
                        catch (Exception ex)
                        {
                            label6.Visible = true;
                            label6.Text = "An error occurred: " + ex.Message;
                            Debug.WriteLine("An error occurred at 315: " + ex.Message);
                            MessageBox.Show($"An error occurred at new Version(currentgithubversion) : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            currentgithubVersion = new Version();
                        }

                        string json = await response.Content.ReadAsStringAsync();
                        dynamic release = JsonConvert.DeserializeObject(json);
                        string tagName = release.tag_name;
                        Debug.WriteLine(tagName);
                        string versionString = tagName.StartsWith("v") ? tagName.Substring(1) : tagName;
                        versionString = "1.0.0.0";
                        try
                        {
                            tagNameVersion = new Version(versionString);
                        }
                        catch (Exception ex)
                        {
                            label6.Visible = true;
                            label6.Text = "An error occurred: " + ex.Message;
                            Debug.WriteLine("An error occurred at 334: " + ex.Message);
                            Debug.WriteLine($"An error occurred at new Version(tagName) : {ex.Message}");
                            MessageBox.Show($"An error occurred at new Version(tagName) : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            tagNameVersion = new Version();
                        }

                        var result = currentgithubVersion.CompareTo(tagNameVersion);

                        Debug.WriteLine(currentgithubVersion.ToString());
                        Debug.WriteLine(tagNameVersion.ToString());
                        Debug.WriteLine(result.ToString());

                        if (result < 0)
                        {
                            NewVersion.Visible = true;
                            NewVersion.Text = $"Version {tagName} of MusicMaster Is Out Click Here To Download" +
                                $" You Rurrent version is {currentgithubversion}";
                            IgnoreUpdate.Visible = true;
                        }
                        else if (result > 0)
                        {
                            MessageBox.Show("This version is not yet public if you do not have permission to have this version Please Delete it and report where you got the version from", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        /*label6.Visible = true;
                        label6.Text = tagName;
                        label6.Text = "Latest Release Tag: " + tagName;*//*
                        if (tagName == currentgithubversion)
                        {
                            // The current version is up to date
                        }
                        else
                        {
                            NewVersion.Visible = true;
                            NewVersion.Text = $"Version {tagName} of MusicMaster Is Out Click Here To Download" +
                                $" You Rurrent version is {currentgithubversion}";
                            IgnoreUpdate.Visible = true;
                        }*/
                    }
                    else if (response.StatusCode.ToString() == "NotFound")
                    {
                        MessageBox.Show("This version is not yet public if you do not have permission to have this version Please Delete it and report where you got the version from", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        label6.Visible = true;
                        label6.Text = "An error occurred: " + response.StatusCode.ToString();
                        Debug.WriteLine("An error occurred at 376: " + response.StatusCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    label6.Visible = true;
                    label6.Text = "An error occurred: " + ex.Message;
                    Debug.WriteLine("An error occurred at 383: " + ex.Message);
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static string ExtractApiToken(string htmlContent)
        {
            string pattern = @"<div class=""de1"">([^<]+)</div>";
            Match match = Regex.Match(htmlContent, pattern);
            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return null;
            }
        }

        private void NewVersion_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Pascal-Benink/MusicMaster/releases/latest/";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
            Application.Exit();
        }

        private void IgnoreUpdate_Click(object sender, EventArgs e)
        {
            NewVersion.Visible = false;
            IgnoreUpdate.Visible = false;
        }

        private void resetlicense_Click(object sender, EventArgs e)
        {
            Settings.Uninstall();
        }
    }
}