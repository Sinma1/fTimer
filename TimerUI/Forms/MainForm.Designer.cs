namespace TimerUI.Forms
{
    partial class MainForm
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlaySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.topSummoner = new TimerUI.Forms.Partials.SummonerUserControl();
            this.jungleSummoner = new TimerUI.Forms.Partials.SummonerUserControl();
            this.midSummoner = new TimerUI.Forms.Partials.SummonerUserControl();
            this.adcSummoner = new TimerUI.Forms.Partials.SummonerUserControl();
            this.supportSummoner = new TimerUI.Forms.Partials.SummonerUserControl();
            this.networkThread = new System.ComponentModel.BackgroundWorker();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.White;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1264, 24);
            this.menuBar.TabIndex = 2;
            this.menuBar.Text = "menuBar";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overlaySetting});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "Settings";
            // 
            // overlaySetting
            // 
            this.overlaySetting.CheckOnClick = true;
            this.overlaySetting.Name = "overlaySetting";
            this.overlaySetting.Size = new System.Drawing.Size(114, 22);
            this.overlaySetting.Text = "Overlay";
            this.overlaySetting.Click += new System.EventHandler(this.overlaySetting_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Enabled = false;
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 659);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1264, 22);
            this.statusBar.TabIndex = 3;
            this.statusBar.Text = "statusStrip1";
            // 
            // topSummoner
            // 
            this.topSummoner.Location = new System.Drawing.Point(80, 60);
            this.topSummoner.Name = "topSummoner";
            this.topSummoner.Size = new System.Drawing.Size(1100, 110);
            this.topSummoner.Summoner = null;
            this.topSummoner.TabIndex = 4;
            // 
            // jungleSummoner
            // 
            this.jungleSummoner.Location = new System.Drawing.Point(80, 176);
            this.jungleSummoner.Name = "jungleSummoner";
            this.jungleSummoner.Size = new System.Drawing.Size(1100, 110);
            this.jungleSummoner.Summoner = null;
            this.jungleSummoner.TabIndex = 5;
            // 
            // midSummoner
            // 
            this.midSummoner.Location = new System.Drawing.Point(80, 292);
            this.midSummoner.Name = "midSummoner";
            this.midSummoner.Size = new System.Drawing.Size(1100, 110);
            this.midSummoner.Summoner = null;
            this.midSummoner.TabIndex = 6;
            // 
            // adcSummoner
            // 
            this.adcSummoner.Location = new System.Drawing.Point(80, 408);
            this.adcSummoner.Name = "adcSummoner";
            this.adcSummoner.Size = new System.Drawing.Size(1100, 110);
            this.adcSummoner.Summoner = null;
            this.adcSummoner.TabIndex = 7;
            // 
            // supportSummoner
            // 
            this.supportSummoner.Location = new System.Drawing.Point(80, 524);
            this.supportSummoner.Name = "supportSummoner";
            this.supportSummoner.Size = new System.Drawing.Size(1100, 110);
            this.supportSummoner.Summoner = null;
            this.supportSummoner.TabIndex = 8;
            // 
            // networkThread
            // 
            this.networkThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.networkThread_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.supportSummoner);
            this.Controls.Add(this.adcSummoner);
            this.Controls.Add(this.midSummoner);
            this.Controls.Add(this.jungleSummoner);
            this.Controls.Add(this.topSummoner);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTimer";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlaySetting;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.BindingSource bindingSource1;
        private Partials.SummonerUserControl topSummoner;
        private Partials.SummonerUserControl jungleSummoner;
        private Partials.SummonerUserControl midSummoner;
        private Partials.SummonerUserControl adcSummoner;
        private Partials.SummonerUserControl supportSummoner;
        private System.ComponentModel.BackgroundWorker networkThread;
    }
}