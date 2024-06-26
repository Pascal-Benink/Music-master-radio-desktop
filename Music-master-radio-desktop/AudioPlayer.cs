using System.Data;
using System.Diagnostics;
using WMPLib;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net;
using System.Timers;

using TagLib;

namespace Music_master_radio_desktop
{
    class AudioPlayer
    {
        private WindowsMediaPlayer player = new WindowsMediaPlayer();
        private bool start = false;
        private bool playing = false;
        private string RadioUrl = "";

        public void Play(string url) {
            if (url == "")
            {
                MessageBox.Show("There is no URL. Please try again by reselecting your radio");
            }
            else
            {
                RadioUrl = url;
                playing = true;
                if (start)
                {
                    player.controls.play();
                }
                else
                {
                    player.URL = url;
                    player.controls.play();
                    start = true;
                }
            }
            
        }

        public void Stop()
        {
            player.controls.stop();
            start = false;
            playing = false;
        }

        public void ChangeVolume(int newVolume) { 
            player.settings.volume = newVolume;
        }

        public void Pause()
        {
            player.controls.pause();
            playing = false;
        }
    }
}
