using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Web;
using WMPLib;
using System.Windows.Forms;

namespace A_Player
{
    public partial class Form3 : Form 
    {
         WindowsMediaPlayer wmp;

        public List<Audio> audioList;
        

        public Form3()
        {
            InitializeComponent();

            wmp = new WindowsMediaPlayer();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            backgroundWorker1.RunWorkerAsync();
        }

        public class Audio
        {
            public int aid { get; set; }
            public int owner_id { get; set; }
            public string artist { get; set; }
            public string title { get; set; }
            public int duration { get; set; }
            public string url { get; set; }
            public string lurics_id { get; set; }
            public int genre { get; set; }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!Settings1.Default.authorization) {Thread.Sleep(500);}
            WebRequest request =
                WebRequest.Create("https://api.vk.com/method/audio.get?owner id= " + Settings1.Default.id + "&need_user=0&access_token=" + Settings1.Default.token);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            responseFromServer = HttpUtility.HtmlDecode(responseFromServer);
        JToken token = JToken.Parse(responseFromServer);

        audioList = Enumerable.Skip(token["response"].Children(), 1).Select(c => c.ToObject<Audio>()).ToList();﻿

            this.Invoke((MethodInvoker)delegate
            {
            for (int i = 0; i < audioList.Count(); i++)
            {
                listBox2.Items.Add(audioList[i].artist + " - " + audioList[i].title);
                
               
            }

            });
            }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) 
        {
            int curItem = listBox2.SelectedIndex;

                wmp.URL = audioList[curItem].url;
                wmp.settings.volume = 100;
                wmp.controls.stop();
                wmp.controls.play();
        }

        }

    }

