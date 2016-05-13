using System;
using WMPLib;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace A_Player
{
    public partial class AudioPlayer : Form
    {
        WindowsMediaPlayer wmp;
        bool pausePlay;
        bool mousePressed = false;
        Point mouseDownPos;

        List<Sound> sounds = new List<Sound>();
        List<Sound> find = new List<Sound>();

        public AudioPlayer()
        {
            InitializeComponent();
            wmp = new WindowsMediaPlayer();
        }

        private void OpenTrack_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.FileName != string.Empty))
            {
                wmp.controls.stop();
                Songcsroll.Value = 0;
                Volume.Value = 10;
                
                label1.Text = "";
                label11.Text = "";
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";

                wmp.URL = ofd.FileName;
                wmp.controls.play();
                timer1.Interval = 1000;
                Songcsroll.Enabled = true;
                Volume.Enabled = true;
                
                timer1.Enabled = true;
                PlayPause.Enabled = true;
                Stop.Enabled = true;

                Sound sound = new Sound { Name = Path.GetFileName(ofd.FileName), Dir = Path.GetDirectoryName(ofd.FileName) };
                sounds.Add(sound);
                MusicList.Items.Add(Path.GetDirectoryName(ofd.FileName) + "\\" + Path.GetFileName(ofd.FileName));
            }
        }

        private void PlayPause_Click(object sender, EventArgs e)
        {
            pausePlay = !pausePlay;
            if (pausePlay)
            {
                wmp.controls.pause();
                label1.Text = "Paused:";
            }
            if (!pausePlay)
            {
                wmp.controls.play();
            }
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            Songcsroll.Value = 0;
            Volume.Value = 10;
           
            label1.Text = "";
            label11.Text = "";
            label3.Text = "0:00:00";
            label2.Text = "0:00:00";
        }

        private void Songcsroll_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = Songcsroll.Value;
        }

        private void Volume_Scroll(object sender, EventArgs e)
        {
            if (Volume.Value == 10)
                wmp.settings.volume = 100;
            if (Volume.Value == 9)
                wmp.settings.volume = 90;
            if (Volume.Value == 8)
                wmp.settings.volume = 80;
            if (Volume.Value == 7)
                wmp.settings.volume = 70;
            if (Volume.Value == 6)
                wmp.settings.volume = 60;
            if (Volume.Value == 5)
                wmp.settings.volume = 50;
            if (Volume.Value == 4)
                wmp.settings.volume = 40;
            if (Volume.Value == 3)
                wmp.settings.volume = 30;
            if (Volume.Value == 2)
                wmp.settings.volume = 20;
            if (Volume.Value == 1)
                wmp.settings.volume = 10;
            if (Volume.Value == 0)
                wmp.settings.volume = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Songcsroll.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
            Songcsroll.Value = Convert.ToInt32(wmp.controls.currentPosition);

            if (wmp != null)
            {
                int s = (int)wmp.currentMedia.duration;
                int h = s / 3600;
                int m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                label3.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
                s = (int)wmp.controls.currentPosition;
                h = s / 3600;
                m = (s - (h * 3600)) / 60;
                s = s - (h * 3600 + m * 60);
                label2.Text = String.Format("{0:D}:{1:D2}:{2:D2}", h, m, s);
            }
            else
            {
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";
            }
        }

        private void AudioPlayer_MouseDown(object sender, MouseEventArgs e)
        {
            AudioPlayer f1 = new AudioPlayer();
            f1.Focus();
            mousePressed = true;
            mouseDownPos = new Point(f1.Location.X + e.Location.X, f1.Location.Y + e.Location.Y + SystemInformation.CaptionHeight);
        }

        private void AudioPlayer_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (FormBorderStyle == FormBorderStyle.None)
                    {
                        Left = Cursor.Position.X - mouseDownPos.X;
                        Top = Cursor.Position.Y - mouseDownPos.Y + 22;
                    }
                    else
                    {
                        Left = Cursor.Position.X - mouseDownPos.X - 3;
                        Top = Cursor.Position.Y - mouseDownPos.Y - 3;
                    }
                }
            }
        }

        private void AudioPlayer_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void Minimum_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = 0;
            Volume.Value = 0;
        }

        private void Maximum_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = 100;
            Volume.Value = 10;
        }
        private void Search(DirectoryInfo dr, Regex file)
        {
            FileInfo[] fi = dr.GetFiles();
            foreach (FileInfo info in fi)
            {
                if (file.IsMatch(info.Name))
                {
                    Sound sound = new Sound { Name = info.Name, Dir = info.Directory.FullName };
                    sounds.Add(sound);
                }
            }
            DirectoryInfo[] dirs = dr.GetDirectories();
            foreach (DirectoryInfo directoryInfo in dirs)
            {
                Search(directoryInfo, file);
            }
        }

        private void list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MusicList.SelectedItem != null)
            {
                string curItem = MusicList.SelectedItem.ToString();
                wmp.controls.stop();
                Songcsroll.Value = 0;
                Volume.Value = 10;
               
                label1.Text = "";
                label11.Text = "";
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";

                wmp.URL = curItem;
                wmp.controls.play();
                timer1.Interval = 1000;
                Songcsroll.Enabled = true;
                Volume.Enabled = true;
                
                timer1.Enabled = true;
                OpenTrack.Enabled = false;
                PlayPause.Enabled = true;
                Stop.Enabled = true;
            }
        }

        private void OpenFolder_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.SelectedPath != string.Empty))
            {
                Regex file = new Regex(@".*\.mp3$");
                DirectoryInfo dr = new DirectoryInfo(ofd.SelectedPath);
                Search(dr, file);
                sounds.ForEach(delegate (Sound sound) {
                    MusicList.Items.Add(sound.Dir + "\\" + sound.Name);
                }
                );
            }
        }

        private void DeleteList_Click(object sender, EventArgs e)
        {
            sounds.Clear();
            MusicList.Items.Clear();
        }

        private void SavePlaylist_Click(object sender, EventArgs e)
        {
            SaveFileDialog xmlSaveFile = new SaveFileDialog();
            xmlSaveFile.Filter = "XML files (*.xml)|*.xml";
            if ((xmlSaveFile.ShowDialog() == DialogResult.OK) && (xmlSaveFile.FileName != string.Empty))
            {
                SoundXml.WriteXmlSound(sounds, xmlSaveFile.FileName);
            }
        }

        private void OpenPlaylist_Click(object sender, EventArgs e)
        {
            var xmlOpenFile = new OpenFileDialog();
            xmlOpenFile.Filter = "XML files (*.xml)|*.xml";
            if ((xmlOpenFile.ShowDialog() == DialogResult.OK) && (xmlOpenFile.FileName != string.Empty))
            {

                SoundXml.ReadXmlSound(sounds, xmlOpenFile.FileName);

                MusicList.Items.Clear();
                sounds.ForEach(delegate (Sound sound)
                {
                    MusicList.Items.Add(sound.Dir + "\\" + sound.Name);
                }
                );
            }
        }

        private void VKPlayer_Click(object sender, EventArgs e)
        {
            new VkAuthorization().Show();
            new VKMusicList().Show();
        }

        private void DeleteTrack_Click(object sender, EventArgs e)
        {
            string file = MusicList.SelectedItem.ToString();
            MusicList.Items.RemoveAt(MusicList.SelectedIndex);
            sounds.Remove(new Sound { Name = Path.GetFileName(file), Dir = Path.GetDirectoryName(file) });
        }

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            MusicList.Items.Clear();
            find = sounds.FindAll(x => x.Name.Contains(TextSearch.Text));
            find.ForEach(delegate (Sound sound)
            {
                MusicList.Items.Add(sound.Dir + "\\" + sound.Name);
            }
            );
        }
    }
}
