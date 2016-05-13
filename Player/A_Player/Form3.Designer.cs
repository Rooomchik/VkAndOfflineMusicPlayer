namespace A_Player
{
    partial class VKMusicList
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.VKList = new System.Windows.Forms.ListBox();
            this.PausePlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // VKList
            // 
            this.VKList.FormattingEnabled = true;
            this.VKList.Location = new System.Drawing.Point(1, -1);
            this.VKList.Name = "VKList";
            this.VKList.Size = new System.Drawing.Size(287, 212);
            this.VKList.TabIndex = 0;
            this.VKList.SelectedIndexChanged += new System.EventHandler(this.VKList_SelectedIndexChanged);
            // 
            // PausePlay
            // 
            this.PausePlay.Location = new System.Drawing.Point(66, 217);
            this.PausePlay.Name = "PausePlay";
            this.PausePlay.Size = new System.Drawing.Size(133, 33);
            this.PausePlay.TabIndex = 1;
            this.PausePlay.Text = "PausePlay";
            this.PausePlay.UseVisualStyleBackColor = true;
            this.PausePlay.Click += new System.EventHandler(this.PausePlay_Click);
            // 
            // VKMusicList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.PausePlay);
            this.Controls.Add(this.VKList);
            this.Name = "VKMusicList";
            this.Text = "VKMusicList";
            this.Load += new System.EventHandler(this.VKMusicList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox VKList;
        private System.Windows.Forms.Button PausePlay;
    }
}