using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A_Player
{
    public partial class VkAuthorization : Form
    {
        public VkAuthorization()
        {
            InitializeComponent();
        }

        private void VkAuthorization_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=5458856&display=popup&redirect_uri=https://oauth.vk.com/blank.html&scope=audio,offline&response_type=token&v=5.52");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            toolStripStatusLabel1.Text = "Loading";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            toolStripStatusLabel1.Text = "Loaded";

            try
            {
                string url = webBrowser1.Url.ToString();
                string l = url.Split('#')[1];
                if (l[0] == 'a')
                {
                    Settings1.Default.token = l.Split('&')[0].Split('=')[1];
                    Settings1.Default.id = l.Split('=')[3];
                    Settings1.Default.authorization = true;
                    MessageBox.Show(Settings1.Default.token + " " + Settings1.Default.id);
                    this.Close();
                }
            }
            catch { }
        }
    }
}
