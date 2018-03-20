namespace TimerUI.Partials
{
    partial class SummonerPartial
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
            this.roleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // roleName
            // 
            this.roleName.Font = new System.Drawing.Font("Verdana", 26.75F, System.Drawing.FontStyle.Bold);
            this.roleName.Location = new System.Drawing.Point(3, 3);
            this.roleName.Name = "roleName";
            this.roleName.Size = new System.Drawing.Size(331, 107);
            this.roleName.TabIndex = 29;
            this.roleName.Text = "TOP";
            this.roleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondSpell
            // 
            this.secondSpell.AutoSize = true;
            this.secondSpell.Location = new System.Drawing.Point(341, 56);
            this.secondSpell.Name = "secondSpell";
            this.secondSpell.Size = new System.Drawing.Size(759, 51);
            this.secondSpell.SpellCooldownLeft = "245";
            this.secondSpell.SpellName = "Flash";
            //this.secondSpell.ThisSpell.SpellUsedTime = null;
            this.secondSpell.TabIndex = 31;
            // 
            // firstSpell
            // 
            this.firstSpell.AutoSize = true;
            this.firstSpell.Location = new System.Drawing.Point(341, 3);
            this.firstSpell.Name = "firstSpell";
            this.firstSpell.Size = new System.Drawing.Size(759, 51);
            this.firstSpell.SpellCooldownLeft = "245";
            this.firstSpell.SpellName = "Flash";
            //this.firstSpell.ThisSpell.SpellUsedTime = null;
            this.firstSpell.TabIndex = 30;
            // 
            // DisplaySummoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondSpell);
            this.Controls.Add(this.firstSpell);
            this.Controls.Add(this.roleName);
            this.Name = "DisplaySummoner";
            this.Size = new System.Drawing.Size(1100, 110);
            this.Load += new System.EventHandler(this.DisplaySummoner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label roleName;
        private SpellPartial firstSpell;
        private SpellPartial secondSpell;
    }
}
