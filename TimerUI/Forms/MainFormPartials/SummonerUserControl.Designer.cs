namespace TimerUI.Forms.Partials
{
    partial class SummonerUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.firstSpellControl = new TimerUI.Forms.Partials.SpellUserControl();
            this.secondSpellControl = new TimerUI.Forms.Partials.SpellUserControl();
            this.SuspendLayout();
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.Font = new System.Drawing.Font("Verdana", 26.75F, System.Drawing.FontStyle.Bold);
            this.roleNameLabel.Location = new System.Drawing.Point(2, 2);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(280, 107);
            this.roleNameLabel.TabIndex = 32;
            this.roleNameLabel.Text = "ROLE";
            this.roleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstSpellControl
            // 
            this.firstSpellControl.Location = new System.Drawing.Point(280, 2);
            this.firstSpellControl.Name = "firstSpellControl";
            this.firstSpellControl.Size = new System.Drawing.Size(820, 50);
            this.firstSpellControl.SummonerSpell = null;
            this.firstSpellControl.TabIndex = 33;
            // 
            // secondSpellControl
            // 
            this.secondSpellControl.Location = new System.Drawing.Point(280, 58);
            this.secondSpellControl.Name = "secondSpellControl";
            this.secondSpellControl.Size = new System.Drawing.Size(820, 50);
            this.secondSpellControl.SummonerSpell = null;
            this.secondSpellControl.TabIndex = 34;
            // 
            // SummonerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondSpellControl);
            this.Controls.Add(this.firstSpellControl);
            this.Controls.Add(this.roleNameLabel);
            this.Name = "SummonerUserControl";
            this.Size = new System.Drawing.Size(1100, 110);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label roleNameLabel;
        private SpellUserControl firstSpellControl;
        private SpellUserControl secondSpellControl;
    }
}
