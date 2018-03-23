namespace TimerUI.Forms
{
    partial class EditSpellForm
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
            this.spellNameTextBox = new System.Windows.Forms.TextBox();
            this.spellNameLabel = new System.Windows.Forms.Label();
            this.cooldownLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cooldownNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // spellNameTextBox
            // 
            this.spellNameTextBox.Location = new System.Drawing.Point(79, 6);
            this.spellNameTextBox.Name = "spellNameTextBox";
            this.spellNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.spellNameTextBox.TabIndex = 1;
            // 
            // spellNameLabel
            // 
            this.spellNameLabel.AutoSize = true;
            this.spellNameLabel.Location = new System.Drawing.Point(12, 9);
            this.spellNameLabel.Name = "spellNameLabel";
            this.spellNameLabel.Size = new System.Drawing.Size(61, 13);
            this.spellNameLabel.TabIndex = 1;
            this.spellNameLabel.Text = "Spell Name";
            // 
            // cooldownLabel
            // 
            this.cooldownLabel.AutoSize = true;
            this.cooldownLabel.Location = new System.Drawing.Point(12, 41);
            this.cooldownLabel.Name = "cooldownLabel";
            this.cooldownLabel.Size = new System.Drawing.Size(54, 13);
            this.cooldownLabel.TabIndex = 3;
            this.cooldownLabel.Text = "Cooldown";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(185, 12);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(77, 42);
            this.saveButton.TabIndex = 2;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cooldownNumericUpDown
            // 
            this.cooldownNumericUpDown.Location = new System.Drawing.Point(79, 38);
            this.cooldownNumericUpDown.Maximum = new decimal(new int[] {
            330,
            0,
            0,
            0});
            this.cooldownNumericUpDown.Name = "cooldownNumericUpDown";
            this.cooldownNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.cooldownNumericUpDown.TabIndex = 0;
            // 
            // EditSpellForm
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 70);
            this.Controls.Add(this.cooldownNumericUpDown);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cooldownLabel);
            this.Controls.Add(this.spellNameLabel);
            this.Controls.Add(this.spellNameTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSpellForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Spell";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditSpellWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cooldownNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox spellNameTextBox;
        private System.Windows.Forms.Label spellNameLabel;
        private System.Windows.Forms.Label cooldownLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown cooldownNumericUpDown;
    }
}