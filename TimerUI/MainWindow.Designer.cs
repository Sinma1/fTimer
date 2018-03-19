using TimerUI.Partials;

namespace TimerUI
{
    partial class MainWindow
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overlaySetting = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportSummoner = new TimerUI.Partials.SummonerPartial();
            this.adcSummoner = new TimerUI.Partials.SummonerPartial();
            this.midSummoner = new TimerUI.Partials.SummonerPartial();
            this.jungleSummoner = new TimerUI.Partials.SummonerPartial();
            this.topSummoner = new TimerUI.Partials.SummonerPartial();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 659);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1264, 22);
            this.statusBar.TabIndex = 0;
            this.statusBar.Text = "statusStrip1";
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
            this.menuBar.TabIndex = 1;
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
            this.overlaySetting.Size = new System.Drawing.Size(180, 22);
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
            // supportSummoner
            // 
            this.supportSummoner.Location = new System.Drawing.Point(24, 535);
            this.supportSummoner.Name = "supportSummoner";
            this.supportSummoner.RoleName = "TOP";
            this.supportSummoner.Size = new System.Drawing.Size(1124, 110);
            this.supportSummoner.TabIndex = 6;
            // 
            // adcSummoner
            // 
            this.adcSummoner.Location = new System.Drawing.Point(24, 409);
            this.adcSummoner.Name = "adcSummoner";
            this.adcSummoner.RoleName = "TOP";
            this.adcSummoner.Size = new System.Drawing.Size(1124, 110);
            this.adcSummoner.TabIndex = 5;
            // 
            // midSummoner
            // 
            this.midSummoner.Location = new System.Drawing.Point(24, 286);
            this.midSummoner.Name = "midSummoner";
            this.midSummoner.RoleName = "TOP";
            this.midSummoner.Size = new System.Drawing.Size(1124, 110);
            this.midSummoner.TabIndex = 4;
            // 
            // jungleSummoner
            // 
            this.jungleSummoner.Location = new System.Drawing.Point(24, 166);
            this.jungleSummoner.Name = "jungleSummoner";
            this.jungleSummoner.RoleName = "TOP";
            this.jungleSummoner.Size = new System.Drawing.Size(1124, 110);
            this.jungleSummoner.TabIndex = 3;
            // 
            // topSummoner
            // 
            this.topSummoner.Location = new System.Drawing.Point(24, 45);
            this.topSummoner.Name = "topSummoner";
            this.topSummoner.RoleName = "TOP";
            this.topSummoner.Size = new System.Drawing.Size(1124, 110);
            this.topSummoner.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.supportSummoner);
            this.Controls.Add(this.adcSummoner);
            this.Controls.Add(this.midSummoner);
            this.Controls.Add(this.jungleSummoner);
            this.Controls.Add(this.topSummoner);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Summoners Spells Timer";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem overlaySetting;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private SummonerPartial topSummoner;
        private SummonerPartial jungleSummoner;
        private SummonerPartial midSummoner;
        private SummonerPartial adcSummoner;
        private SummonerPartial supportSummoner;
    }
}

