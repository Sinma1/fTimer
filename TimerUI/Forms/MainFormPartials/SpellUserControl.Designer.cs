namespace TimerUI.Forms.Partials
{
    partial class SpellUserControl
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.editSpellButton = new System.Windows.Forms.Button();
            this.spellSubstract30Second = new System.Windows.Forms.Button();
            this.spellSubstract10Second = new System.Windows.Forms.Button();
            this.spellStartButton = new System.Windows.Forms.Button();
            this.spellCountdownLabel = new System.Windows.Forms.Label();
            this.spellNameLabel = new System.Windows.Forms.Label();
            this.CooldownTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(795, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.resetButton.Location = new System.Drawing.Point(387, 13);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 25);
            this.resetButton.TabIndex = 38;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // editSpellButton
            // 
            this.editSpellButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.editSpellButton.Location = new System.Drawing.Point(703, 13);
            this.editSpellButton.Name = "editSpellButton";
            this.editSpellButton.Size = new System.Drawing.Size(83, 25);
            this.editSpellButton.TabIndex = 37;
            this.editSpellButton.Text = "Edit Spell";
            this.editSpellButton.UseVisualStyleBackColor = true;
            this.editSpellButton.Click += new System.EventHandler(this.editSpellButton_Click);
            // 
            // spellSubstract30Second
            // 
            this.spellSubstract30Second.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellSubstract30Second.Location = new System.Drawing.Point(586, 13);
            this.spellSubstract30Second.Name = "spellSubstract30Second";
            this.spellSubstract30Second.Size = new System.Drawing.Size(83, 25);
            this.spellSubstract30Second.TabIndex = 36;
            this.spellSubstract30Second.Text = "-30s";
            this.spellSubstract30Second.UseVisualStyleBackColor = true;
            this.spellSubstract30Second.Click += new System.EventHandler(this.spellSubstract30Second_Click);
            // 
            // spellSubstract10Second
            // 
            this.spellSubstract10Second.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellSubstract10Second.Location = new System.Drawing.Point(497, 13);
            this.spellSubstract10Second.Name = "spellSubstract10Second";
            this.spellSubstract10Second.Size = new System.Drawing.Size(83, 25);
            this.spellSubstract10Second.TabIndex = 35;
            this.spellSubstract10Second.Text = "-10s";
            this.spellSubstract10Second.UseVisualStyleBackColor = true;
            this.spellSubstract10Second.Click += new System.EventHandler(this.spellSubstract10Second_Click);
            // 
            // spellStartButton
            // 
            this.spellStartButton.Font = new System.Drawing.Font("Verdana", 10F);
            this.spellStartButton.Location = new System.Drawing.Point(273, 13);
            this.spellStartButton.Name = "spellStartButton";
            this.spellStartButton.Size = new System.Drawing.Size(108, 25);
            this.spellStartButton.TabIndex = 34;
            this.spellStartButton.Text = "Start Timing";
            this.spellStartButton.UseVisualStyleBackColor = true;
            this.spellStartButton.Click += new System.EventHandler(this.spellStartButton_Click);
            // 
            // spellCountdownLabel
            // 
            this.spellCountdownLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellCountdownLabel.ForeColor = System.Drawing.Color.Lime;
            this.spellCountdownLabel.Location = new System.Drawing.Point(120, 13);
            this.spellCountdownLabel.Name = "spellCountdownLabel";
            this.spellCountdownLabel.Size = new System.Drawing.Size(147, 25);
            this.spellCountdownLabel.TabIndex = 33;
            this.spellCountdownLabel.Text = "Ready";
            this.spellCountdownLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spellNameLabel
            // 
            this.spellNameLabel.AutoSize = true;
            this.spellNameLabel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spellNameLabel.Location = new System.Drawing.Point(3, 13);
            this.spellNameLabel.Name = "spellNameLabel";
            this.spellNameLabel.Size = new System.Drawing.Size(126, 25);
            this.spellNameLabel.TabIndex = 32;
            this.spellNameLabel.Text = "SpellName";
            // 
            // CooldownTimer
            // 
            this.CooldownTimer.Interval = 400;
            this.CooldownTimer.Tick += new System.EventHandler(this.CooldownTimer_Tick);
            // 
            // SpellUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.editSpellButton);
            this.Controls.Add(this.spellSubstract30Second);
            this.Controls.Add(this.spellSubstract10Second);
            this.Controls.Add(this.spellStartButton);
            this.Controls.Add(this.spellCountdownLabel);
            this.Controls.Add(this.spellNameLabel);
            this.Name = "SpellUserControl";
            this.Size = new System.Drawing.Size(820, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button editSpellButton;
        private System.Windows.Forms.Button spellSubstract30Second;
        private System.Windows.Forms.Button spellSubstract10Second;
        private System.Windows.Forms.Button spellStartButton;
        private System.Windows.Forms.Label spellCountdownLabel;
        private System.Windows.Forms.Label spellNameLabel;
        private System.Windows.Forms.Timer CooldownTimer;
    }
}
