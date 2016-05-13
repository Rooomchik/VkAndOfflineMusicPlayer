namespace A_Player
{
    partial class AudioPlayer
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OpenTrack = new System.Windows.Forms.Button();
            this.PlayPause = new System.Windows.Forms.Button();
            this.Songcsroll = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Stop = new System.Windows.Forms.Button();
            this.Vloume = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.Minimum = new System.Windows.Forms.Button();
            this.Maximum = new System.Windows.Forms.Button();
            this.MusicList = new System.Windows.Forms.ListBox();
            this.OpenFolder = new System.Windows.Forms.Button();
            this.DeleteFolder = new System.Windows.Forms.Button();
            this.SavePlaylist = new System.Windows.Forms.Button();
            this.OpenPlaylist = new System.Windows.Forms.Button();
            this.VKPlayer = new System.Windows.Forms.Button();
            this.DeleteTrack = new System.Windows.Forms.Button();
            this.TextSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Songcsroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenTrack
            // 
            this.OpenTrack.BackColor = System.Drawing.SystemColors.Window;
            this.OpenTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.OpenTrack.Location = new System.Drawing.Point(118, 9);
            this.OpenTrack.Name = "OpenTrack";
            this.OpenTrack.Size = new System.Drawing.Size(87, 21);
            this.OpenTrack.TabIndex = 0;
            this.OpenTrack.Text = "OpenTrack";
            this.OpenTrack.UseVisualStyleBackColor = false;
            this.OpenTrack.Click += new System.EventHandler(this.OpenTrack_Click);
            // 
            // PlayPause
            // 
            this.PlayPause.Enabled = false;
            this.PlayPause.Location = new System.Drawing.Point(67, 150);
            this.PlayPause.Name = "PlayPause";
            this.PlayPause.Size = new System.Drawing.Size(87, 21);
            this.PlayPause.TabIndex = 1;
            this.PlayPause.Text = "Pause/Play";
            this.PlayPause.UseVisualStyleBackColor = true;
            this.PlayPause.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // Songcsroll
            // 
            this.Songcsroll.AutoSize = false;
            this.Songcsroll.Enabled = false;
            this.Songcsroll.Location = new System.Drawing.Point(1, 118);
            this.Songcsroll.Maximum = 0;
            this.Songcsroll.Name = "Songcsroll";
            this.Songcsroll.Size = new System.Drawing.Size(329, 29);
            this.Songcsroll.TabIndex = 2;
            this.Songcsroll.Scroll += new System.EventHandler(this.Songcsroll_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "0:00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "0:00:00";
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(160, 150);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(87, 21);
            this.Stop.TabIndex = 6;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Vloume
            // 
            this.Vloume.AutoSize = true;
            this.Vloume.Location = new System.Drawing.Point(62, 9);
            this.Vloume.Name = "Vloume";
            this.Vloume.Size = new System.Drawing.Size(50, 13);
            this.Vloume.TabIndex = 7;
            this.Vloume.Text = "Volume";
            // 
            // Volume
            // 
            this.Volume.Enabled = false;
            this.Volume.Location = new System.Drawing.Point(67, 25);
            this.Volume.Name = "Volume";
            this.Volume.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.Volume.Size = new System.Drawing.Size(45, 80);
            this.Volume.TabIndex = 9;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Volume.Value = 10;
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(266, 56);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 16;
            // 
            // Minimum
            // 
            this.Minimum.Location = new System.Drawing.Point(23, 82);
            this.Minimum.Name = "Minimum";
            this.Minimum.Size = new System.Drawing.Size(38, 23);
            this.Minimum.TabIndex = 17;
            this.Minimum.Text = "Min";
            this.Minimum.UseVisualStyleBackColor = true;
            this.Minimum.Click += new System.EventHandler(this.Minimum_Click);
            // 
            // Maximum
            // 
            this.Maximum.Location = new System.Drawing.Point(23, 25);
            this.Maximum.Name = "Maximum";
            this.Maximum.Size = new System.Drawing.Size(38, 23);
            this.Maximum.TabIndex = 18;
            this.Maximum.Text = "Max";
            this.Maximum.UseVisualStyleBackColor = true;
            this.Maximum.Click += new System.EventHandler(this.Maximum_Click);
            // 
            // MusicList
            // 
            this.MusicList.FormattingEnabled = true;
            this.MusicList.Location = new System.Drawing.Point(12, 205);
            this.MusicList.Margin = new System.Windows.Forms.Padding(0);
            this.MusicList.Name = "MusicList";
            this.MusicList.Size = new System.Drawing.Size(727, 212);
            this.MusicList.TabIndex = 19;
            this.MusicList.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // OpenFolder
            // 
            this.OpenFolder.Location = new System.Drawing.Point(118, 33);
            this.OpenFolder.Name = "OpenFolder";
            this.OpenFolder.Size = new System.Drawing.Size(87, 21);
            this.OpenFolder.TabIndex = 20;
            this.OpenFolder.Text = "OpenFolder";
            this.OpenFolder.UseVisualStyleBackColor = true;
            this.OpenFolder.Click += new System.EventHandler(this.OpenFolder_Click);
            // 
            // DeleteFolder
            // 
            this.DeleteFolder.Location = new System.Drawing.Point(118, 59);
            this.DeleteFolder.Name = "DeleteFolder";
            this.DeleteFolder.Size = new System.Drawing.Size(87, 20);
            this.DeleteFolder.TabIndex = 21;
            this.DeleteFolder.Text = "DeleteFolder";
            this.DeleteFolder.UseVisualStyleBackColor = true;
            this.DeleteFolder.Click += new System.EventHandler(this.DeleteFolder_Click);
            // 
            // SavePlaylist
            // 
            this.SavePlaylist.Location = new System.Drawing.Point(211, 32);
            this.SavePlaylist.Name = "SavePlaylist";
            this.SavePlaylist.Size = new System.Drawing.Size(87, 21);
            this.SavePlaylist.TabIndex = 22;
            this.SavePlaylist.Text = "SavePlaylist";
            this.SavePlaylist.UseVisualStyleBackColor = true;
            this.SavePlaylist.Click += new System.EventHandler(this.SavePlaylist_Click);
            // 
            // OpenPlaylist
            // 
            this.OpenPlaylist.Location = new System.Drawing.Point(211, 9);
            this.OpenPlaylist.Name = "OpenPlaylist";
            this.OpenPlaylist.Size = new System.Drawing.Size(87, 21);
            this.OpenPlaylist.TabIndex = 23;
            this.OpenPlaylist.Text = "OpenPlaylist";
            this.OpenPlaylist.UseVisualStyleBackColor = true;
            this.OpenPlaylist.Click += new System.EventHandler(this.OpenPlaylist_Click);
            // 
            // VKPlayer
            // 
            this.VKPlayer.Location = new System.Drawing.Point(211, 59);
            this.VKPlayer.Name = "VKPlayer";
            this.VKPlayer.Size = new System.Drawing.Size(88, 23);
            this.VKPlayer.TabIndex = 24;
            this.VKPlayer.Text = "VKPlayer";
            this.VKPlayer.UseVisualStyleBackColor = true;
            this.VKPlayer.Click += new System.EventHandler(this.VKPlayer_Click);
            // 
            // DeleteTrack
            // 
            this.DeleteTrack.Location = new System.Drawing.Point(118, 85);
            this.DeleteTrack.Name = "DeleteTrack";
            this.DeleteTrack.Size = new System.Drawing.Size(87, 20);
            this.DeleteTrack.TabIndex = 25;
            this.DeleteTrack.Text = "DeleteTrack";
            this.DeleteTrack.UseVisualStyleBackColor = true;
            this.DeleteTrack.Click += new System.EventHandler(this.DeleteTrack_Click);
            // 
            // TextSearch
            // 
            this.TextSearch.Location = new System.Drawing.Point(67, 181);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.Size = new System.Drawing.Size(350, 21);
            this.TextSearch.TabIndex = 26;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Search";
            // 
            // AudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextSearch);
            this.Controls.Add(this.DeleteTrack);
            this.Controls.Add(this.VKPlayer);
            this.Controls.Add(this.OpenPlaylist);
            this.Controls.Add(this.SavePlaylist);
            this.Controls.Add(this.DeleteFolder);
            this.Controls.Add(this.OpenFolder);
            this.Controls.Add(this.MusicList);
            this.Controls.Add(this.Maximum);
            this.Controls.Add(this.Minimum);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.Vloume);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Songcsroll);
            this.Controls.Add(this.PlayPause);
            this.Controls.Add(this.OpenTrack);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AudioPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(this.Form1_QueryAccessibilityHelp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AudioPlayer_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AudioPlayer_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AudioPlayer_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.Songcsroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenTrack;
        private System.Windows.Forms.Button PlayPause;
        private System.Windows.Forms.TrackBar Songcsroll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label Vloume;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button Minimum;
        private System.Windows.Forms.Button Maximum;
        private System.Windows.Forms.ListBox MusicList;
        private System.Windows.Forms.Button OpenFolder;
        private System.Windows.Forms.Button DeleteFolder;
        private System.Windows.Forms.Button SavePlaylist;
        private System.Windows.Forms.Button OpenPlaylist;
        private System.Windows.Forms.Button VKPlayer;
        private System.Windows.Forms.Button DeleteTrack;
        private System.Windows.Forms.TextBox TextSearch;
        private System.Windows.Forms.Label label4;
    }
}

