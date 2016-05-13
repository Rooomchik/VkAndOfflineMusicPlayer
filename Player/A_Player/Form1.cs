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
    public partial class Form1 : Form
    {
        WindowsMediaPlayer wmp;
        bool pausePlay;
        bool mousePressed = false;
        Point mouseDownPos;

        List<Sound> sounds = new List<Sound>();
        List<Sound> faind = new List<Sound>();

        public Form1()
        {
            InitializeComponent();

            wmp = new WindowsMediaPlayer();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.FileName != string.Empty))
            {
                wmp.controls.stop();
                trackBar1.Value = 0;
                trackBar2.Value = 10;
                trackBar3.Value = 5;
                label1.Text = "";
                label11.Text = "";
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";

                wmp.URL = ofd.FileName;
                wmp.controls.play();
                timer1.Interval = 1000;
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
                trackBar3.Enabled = true;
                timer1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                label1.Text = "Playing:";

                Sound sound = new Sound { Name = Path.GetFileName(ofd.FileName), Dir = Path.GetDirectoryName(ofd.FileName) };
                sounds.Add(sound);
                List.Items.Add(Path.GetDirectoryName(ofd.FileName) + "\\" + Path.GetFileName(ofd.FileName));
            }
        }

        private void button2_Click(object sender, EventArgs e)
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
                label1.Text = "Playing:";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            wmp.controls.stop();
            trackBar1.Value = 0;
            trackBar2.Value = 10;
            trackBar3.Value = 5;
            label1.Text = "";
            label11.Text = "";
            label3.Text = "0:00:00";
            label2.Text = "0:00:00";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp.controls.currentPosition = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            if (trackBar2.Value == 10)
                wmp.settings.volume = 100;
            if (trackBar2.Value == 9)
                wmp.settings.volume = 90;
            if (trackBar2.Value == 8)
                wmp.settings.volume = 80;
            if (trackBar2.Value == 7)
                wmp.settings.volume = 70;
            if (trackBar2.Value == 6)
                wmp.settings.volume = 60;
            if (trackBar2.Value == 5)
                wmp.settings.volume = 50;
            if (trackBar2.Value == 4)
                wmp.settings.volume = 40;
            if (trackBar2.Value == 3)
                wmp.settings.volume = 30;
            if (trackBar2.Value == 2)
                wmp.settings.volume = 20;
            if (trackBar2.Value == 1)
                wmp.settings.volume = 10;
            if (trackBar2.Value == 0)
                wmp.settings.volume = 0;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            if (trackBar3.Value == 10)
                wmp.settings.balance = -100;
            if (trackBar3.Value == 9)
                wmp.settings.balance = -70;
            if (trackBar3.Value == 8)
                wmp.settings.balance = -50;
            if (trackBar3.Value == 7)
                wmp.settings.balance = -30;
            if (trackBar3.Value == 6)
                wmp.settings.balance = -10;
            if (trackBar3.Value == 5)
                wmp.settings.balance = 0;
            if (trackBar3.Value == 4)
                wmp.settings.balance = 10;
            if (trackBar3.Value == 3)
                wmp.settings.balance = 30;
            if (trackBar3.Value == 2)
                wmp.settings.balance = 50;
            if (trackBar3.Value == 1)
                wmp.settings.balance = 70;
            if (trackBar3.Value == 0)
                wmp.settings.balance = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Maximum = Convert.ToInt32(wmp.currentMedia.duration);
            trackBar1.Value = Convert.ToInt32(wmp.controls.currentPosition);

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

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Focus();
            mousePressed = true;
            mouseDownPos = new Point(f1.Location.X + e.Location.X, f1.Location.Y + e.Location.Y + SystemInformation.CaptionHeight);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
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

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousePressed = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = 0;
            trackBar2.Value = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            wmp.settings.volume = 100;
            trackBar2.Value = 10;
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
            if (List.SelectedItem != null)
            {
                string curItem = List.SelectedItem.ToString();
                wmp.controls.stop();
                trackBar1.Value = 0;
                trackBar2.Value = 10;
                trackBar3.Value = 5;
                label1.Text = "";
                label11.Text = "";
                label3.Text = "0:00:00";
                label2.Text = "0:00:00";

                wmp.URL = curItem;
                wmp.controls.play();
                timer1.Interval = 1000;
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
                trackBar3.Enabled = true;
                timer1.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                label1.Text = "Playing:";
            }
        } 

        private void button6_Click(object sender, EventArgs e)
        {
            var ofd = new FolderBrowserDialog();
            if ((ofd.ShowDialog() == DialogResult.OK) && (ofd.SelectedPath != string.Empty))
            {
                Regex file = new Regex(@".*\.mp3$");
                DirectoryInfo dr = new DirectoryInfo(ofd.SelectedPath);
                Search(dr, file);
                sounds.ForEach(delegate (Sound sound) {
                    List.Items.Add(sound.Dir + "\\" + sound.Name);
                });
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sounds.Clear();
            List.Items.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SaveFileDialog xmlSaveFile = new SaveFileDialog();
            xmlSaveFile.Filter = "XML files (*.xml)|*.xml";
            if ((xmlSaveFile.ShowDialog() == DialogResult.OK) && (xmlSaveFile.FileName != string.Empty))
            {
                SoundXml.WriteXmlSound(sounds, xmlSaveFile.FileName);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var xmlOpenFile = new OpenFileDialog();
            xmlOpenFile.Filter = "XML files (*.xml)|*.xml";
            if ((xmlOpenFile.ShowDialog() == DialogResult.OK) && (xmlOpenFile.FileName != string.Empty))
            {

                SoundXml.ReadXmlSound(sounds, xmlOpenFile.FileName);

                List.Items.Clear();
                sounds.ForEach(delegate (Sound sound)
                {
                    List.Items.Add(sound.Dir + "\\" + sound.Name);
                });
            }
        }

        private void Form1_QueryAccessibilityHelp(object sender, QueryAccessibilityHelpEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            new Form3().Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string file = List.SelectedItem.ToString();
            List.Items.RemoveAt(List.SelectedIndex);
            sounds.Remove(new Sound { Name = Path.GetFileName(file), Dir = Path.GetDirectoryName(file) });
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List.Items.Clear();
            faind = sounds.FindAll(x => x.Name.Contains(textBox1.Text));
            faind.ForEach(delegate (Sound sound)
            {
                List.Items.Add(sound.Dir + "\\" + sound.Name);
            });
        }
    }
}
