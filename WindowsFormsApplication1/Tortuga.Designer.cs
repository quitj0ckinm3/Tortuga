namespace Tortuga
{
    partial class Tortuga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tortuga));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.dirBtn = new System.Windows.Forms.Button();
            this.clearListBox = new System.Windows.Forms.Button();
            this.fullScreenBtn = new System.Windows.Forms.Button();
            this.prevChannelBtn = new System.Windows.Forms.Button();
            this.changeChannelBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.playBtn = new System.Windows.Forms.Button();
            this.dirTabCtrl = new System.Windows.Forms.TabControl();
            this.seqTab = new System.Windows.Forms.TabPage();
            this.seqListBox = new System.Windows.Forms.ListBox();
            this.chSurfTab = new System.Windows.Forms.TabPage();
            this.chSurfListBox = new System.Windows.Forms.ListBox();
            this.finishPlaybackTimer = new System.Windows.Forms.Timer(this.components);
            this.durationTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).BeginInit();
            this.dirTabCtrl.SuspendLayout();
            this.seqTab.SuspendLayout();
            this.chSurfTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.mediaPlayer);
            this.splitContainer1.Panel1.Controls.Add(this.dirBtn);
            this.splitContainer1.Panel1.Controls.Add(this.clearListBox);
            this.splitContainer1.Panel1.Controls.Add(this.fullScreenBtn);
            this.splitContainer1.Panel1.Controls.Add(this.prevChannelBtn);
            this.splitContainer1.Panel1.Controls.Add(this.changeChannelBtn);
            this.splitContainer1.Panel1.Controls.Add(this.stopBtn);
            this.splitContainer1.Panel1.Controls.Add(this.playBtn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dirTabCtrl);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 730);
            this.splitContainer1.SplitterDistance = 785;
            this.splitContainer1.TabIndex = 0;
            // 
            // mediaPlayer
            // 
            this.mediaPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mediaPlayer.Enabled = true;
            this.mediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.mediaPlayer.Name = "mediaPlayer";
            this.mediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mediaPlayer.OcxState")));
            this.mediaPlayer.Size = new System.Drawing.Size(777, 689);
            this.mediaPlayer.TabIndex = 8;
            // 
            // dirBtn
            // 
            this.dirBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dirBtn.AutoSize = true;
            this.dirBtn.Location = new System.Drawing.Point(592, 698);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(26, 23);
            this.dirBtn.TabIndex = 7;
            this.dirBtn.Text = "...";
            this.dirBtn.UseVisualStyleBackColor = true;
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // clearListBox
            // 
            this.clearListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearListBox.AutoSize = true;
            this.clearListBox.Location = new System.Drawing.Point(624, 698);
            this.clearListBox.Name = "clearListBox";
            this.clearListBox.Size = new System.Drawing.Size(75, 23);
            this.clearListBox.TabIndex = 6;
            this.clearListBox.Text = "Remove Dir";
            this.clearListBox.UseVisualStyleBackColor = true;
            this.clearListBox.Click += new System.EventHandler(this.clearListBox_Click);
            // 
            // fullScreenBtn
            // 
            this.fullScreenBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullScreenBtn.AutoSize = true;
            this.fullScreenBtn.Location = new System.Drawing.Point(705, 698);
            this.fullScreenBtn.Name = "fullScreenBtn";
            this.fullScreenBtn.Size = new System.Drawing.Size(75, 23);
            this.fullScreenBtn.TabIndex = 5;
            this.fullScreenBtn.Text = "Fullscreen";
            this.fullScreenBtn.UseVisualStyleBackColor = true;
            this.fullScreenBtn.Click += new System.EventHandler(this.fullScreenBtn_Click);
            // 
            // prevChannelBtn
            // 
            this.prevChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.prevChannelBtn.AutoSize = true;
            this.prevChannelBtn.Location = new System.Drawing.Point(267, 698);
            this.prevChannelBtn.Name = "prevChannelBtn";
            this.prevChannelBtn.Size = new System.Drawing.Size(100, 23);
            this.prevChannelBtn.TabIndex = 4;
            this.prevChannelBtn.Text = "Previous Channel";
            this.prevChannelBtn.UseVisualStyleBackColor = true;
            this.prevChannelBtn.Click += new System.EventHandler(this.prevChannelBtn_Click);
            // 
            // changeChannelBtn
            // 
            this.changeChannelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeChannelBtn.AutoSize = true;
            this.changeChannelBtn.Location = new System.Drawing.Point(165, 698);
            this.changeChannelBtn.Name = "changeChannelBtn";
            this.changeChannelBtn.Size = new System.Drawing.Size(96, 23);
            this.changeChannelBtn.TabIndex = 3;
            this.changeChannelBtn.Text = "Change Channel";
            this.changeChannelBtn.UseVisualStyleBackColor = true;
            this.changeChannelBtn.Click += new System.EventHandler(this.changeChannelBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopBtn.Location = new System.Drawing.Point(84, 698);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 2;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.playBtn.Location = new System.Drawing.Point(3, 698);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Start";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // dirTabCtrl
            // 
            this.dirTabCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dirTabCtrl.Controls.Add(this.seqTab);
            this.dirTabCtrl.Controls.Add(this.chSurfTab);
            this.dirTabCtrl.Location = new System.Drawing.Point(3, 3);
            this.dirTabCtrl.Name = "dirTabCtrl";
            this.dirTabCtrl.SelectedIndex = 0;
            this.dirTabCtrl.ShowToolTips = true;
            this.dirTabCtrl.Size = new System.Drawing.Size(211, 722);
            this.dirTabCtrl.TabIndex = 0;
            // 
            // seqTab
            // 
            this.seqTab.Controls.Add(this.seqListBox);
            this.seqTab.Location = new System.Drawing.Point(4, 22);
            this.seqTab.Name = "seqTab";
            this.seqTab.Padding = new System.Windows.Forms.Padding(3);
            this.seqTab.Size = new System.Drawing.Size(203, 696);
            this.seqTab.TabIndex = 0;
            this.seqTab.Text = "Sequential Videos";
            this.seqTab.ToolTipText = "Select which directory to play videos from.";
            this.seqTab.UseVisualStyleBackColor = true;
            // 
            // seqListBox
            // 
            this.seqListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.seqListBox.FormattingEnabled = true;
            this.seqListBox.HorizontalScrollbar = true;
            this.seqListBox.Location = new System.Drawing.Point(7, 7);
            this.seqListBox.Name = "seqListBox";
            this.seqListBox.Size = new System.Drawing.Size(190, 680);
            this.seqListBox.TabIndex = 0;
            // 
            // chSurfTab
            // 
            this.chSurfTab.Controls.Add(this.chSurfListBox);
            this.chSurfTab.Location = new System.Drawing.Point(4, 22);
            this.chSurfTab.Name = "chSurfTab";
            this.chSurfTab.Padding = new System.Windows.Forms.Padding(3);
            this.chSurfTab.Size = new System.Drawing.Size(203, 696);
            this.chSurfTab.TabIndex = 1;
            this.chSurfTab.Text = "Channel Surf Videos";
            this.chSurfTab.ToolTipText = "Select which directory to play videos from.";
            this.chSurfTab.UseVisualStyleBackColor = true;
            // 
            // chSurfListBox
            // 
            this.chSurfListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chSurfListBox.FormattingEnabled = true;
            this.chSurfListBox.HorizontalScrollbar = true;
            this.chSurfListBox.Location = new System.Drawing.Point(7, 7);
            this.chSurfListBox.Name = "chSurfListBox";
            this.chSurfListBox.Size = new System.Drawing.Size(190, 680);
            this.chSurfListBox.TabIndex = 0;
            // 
            // finishPlaybackTimer
            // 
            this.finishPlaybackTimer.Tick += new System.EventHandler(this.finishPlaybackTimer_Tick);
            // 
            // durationTimer
            // 
            this.durationTimer.Tick += new System.EventHandler(this.durationTimer_Tick);
            // 
            // Tortuga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 768);
            this.Name = "Tortuga";
            this.Text = "Tortuga";
            this.Load += new System.EventHandler(this.Tortuga_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mediaPlayer)).EndInit();
            this.dirTabCtrl.ResumeLayout(false);
            this.seqTab.ResumeLayout(false);
            this.chSurfTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl dirTabCtrl;
        private System.Windows.Forms.TabPage seqTab;
        private System.Windows.Forms.TabPage chSurfTab;
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button changeChannelBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button dirBtn;
        private System.Windows.Forms.Button clearListBox;
        private System.Windows.Forms.Button fullScreenBtn;
        private System.Windows.Forms.Button prevChannelBtn;
        private System.Windows.Forms.Timer finishPlaybackTimer;
        private System.Windows.Forms.Timer durationTimer;
        private System.Windows.Forms.ListBox seqListBox;
        private System.Windows.Forms.ListBox chSurfListBox;
        private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
    }
}

