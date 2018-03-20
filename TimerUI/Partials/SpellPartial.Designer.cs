namespace TimerUI.Partials
{
    partial class SpellPartial
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
            this.components = new System.ComponentModel.Container();
            this.editSpellButton = new System.Windows.Forms.Button();
            this.spellSubstract30Second = new System.Windows.Forms.Button();
            this.spellSubstract10Second = new System.Windows.Forms.Button();
            this.spellStartButton = new System.Windows.Forms.Button();
            this.spellCountdown = new System.Windows.Forms.Label();
            this.spellName = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // editSpellButton
            // 
            this.editSpellButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.editSpellButton.Location = new System.Drawing.Point(696, 12);
            this.editSpellButton.Name = "editSpellButton";
            this.editSpellButton.Size = new System.Drawing.Size(83, 25);
            this.editSpellButton.TabIndex = 29;
            this.editSpellButton.Text = "Edit Spell";
            this.editSpellButton.UseVisualStyleBackColor = true;
            this.editSpellButton.Click += new System.EventHandler(this.editSpellButton_Click);
            // 
            // spellSubstract30Second
            // 
            this.spellSubstract30Second.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellSubstract30Second.Location = new System.Drawing.Point(579, 12);
            this.spellSubstract30Second.Name = "spellSubstract30Second";
            this.spellSubstract30Second.Size = new System.Drawing.Size(83, 25);
            this.spellSubstract30Second.TabIndex = 28;
            this.spellSubstract30Second.Text = "-30s";
            this.spellSubstract30Second.UseVisualStyleBackColor = true;
            this.spellSubstract30Second.Click += new System.EventHandler(this.spellSubstract30_Click);
            // 
            // spellSubstract10Second
            // 
            this.spellSubstract10Second.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellSubstract10Second.Location = new System.Drawing.Point(490, 12);
            this.spellSubstract10Second.Name = "spellSubstract10Second";
            this.spellSubstract10Second.Size = new System.Drawing.Size(83, 25);
            this.spellSubstract10Second.TabIndex = 27;
            this.spellSubstract10Second.Text = "-10s";
            this.spellSubstract10Second.UseVisualStyleBackColor = true;
            this.spellSubstract10Second.Click += new System.EventHandler(this.spellSubstract10_Click);
            // 
            // spellStartButton
            // 
            this.spellStartButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellStartButton.Location = new System.Drawing.Point(266, 12);
            this.spellStartButton.Name = "spellStartButton";
            this.spellStartButton.Size = new System.Drawing.Size(108, 25);
            this.spellStartButton.TabIndex = 26;
            this.spellStartButton.Text = "Start Timing";
            this.spellStartButton.UseVisualStyleBackColor = true;
            this.spellStartButton.Click += new System.EventHandler(this.spellStartButton_Click);
            // 
            // spellCountdown
            // 
            this.spellCountdown.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCountdown.ForeColor = System.Drawing.Color.Lime;
            this.spellCountdown.Location = new System.Drawing.Point(113, 12);
            this.spellCountdown.Name = "spellCountdown";
            this.spellCountdown.Size = new System.Drawing.Size(147, 25);
            this.spellCountdown.TabIndex = 25;
            this.spellCountdown.Text = "Ready";
            this.spellCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spellName
            // 
            this.spellName.AutoSize = true;
            this.spellName.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellName.Location = new System.Drawing.Point(3, 12);
            this.spellName.Name = "spellName";
            this.spellName.Size = new System.Drawing.Size(67, 25);
            this.spellName.TabIndex = 24;
            this.spellName.Text = "Flash";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.resetButton.Location = new System.Drawing.Point(380, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 25);
            this.resetButton.TabIndex = 30;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(788, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // SpellPartial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.editSpellButton);
            this.Controls.Add(this.spellSubstract30Second);
            this.Controls.Add(this.spellSubstract10Second);
            this.Controls.Add(this.spellStartButton);
            this.Controls.Add(this.spellCountdown);
            this.Controls.Add(this.spellName);
            this.Name = "SpellPartial";
            this.Size = new System.Drawing.Size(820, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.Button editSpellButton;
        private System.Windows.Forms.Button spellSubstract30Second;
        private System.Windows.Forms.Button spellSubstract10Second;
        private System.Windows.Forms.Button spellStartButton;
        private System.Windows.Forms.Label spellCountdown;
        private System.Windows.Forms.Label spellName;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
