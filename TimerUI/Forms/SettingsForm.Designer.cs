namespace TimerUI.Forms
{
    partial class SettingsForm
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
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.overlayTab = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.fontLabel = new System.Windows.Forms.Label();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.fontColorValue = new System.Windows.Forms.TextBox();
            this.fontValue = new System.Windows.Forms.TextBox();
            this.fontButton = new System.Windows.Forms.Button();
            this.fontPositionLabel = new System.Windows.Forms.Label();
            this.positionXLabel = new System.Windows.Forms.Label();
            this.positionXValue = new System.Windows.Forms.NumericUpDown();
            this.positionYValue = new System.Windows.Forms.NumericUpDown();
            this.positionYLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.settingsTabs.SuspendLayout();
            this.overlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionXValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYValue)).BeginInit();
            this.SuspendLayout();
            // 
            // settingsTabs
            // 
            this.settingsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabs.Controls.Add(this.overlayTab);
            this.settingsTabs.Controls.Add(this.tabPage2);
            this.settingsTabs.Location = new System.Drawing.Point(12, 12);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(371, 334);
            this.settingsTabs.TabIndex = 0;
            // 
            // overlayTab
            // 
            this.overlayTab.AutoScroll = true;
            this.overlayTab.Controls.Add(this.positionYValue);
            this.overlayTab.Controls.Add(this.positionYLabel);
            this.overlayTab.Controls.Add(this.positionXValue);
            this.overlayTab.Controls.Add(this.positionXLabel);
            this.overlayTab.Controls.Add(this.fontPositionLabel);
            this.overlayTab.Controls.Add(this.fontValue);
            this.overlayTab.Controls.Add(this.fontButton);
            this.overlayTab.Controls.Add(this.fontColorValue);
            this.overlayTab.Controls.Add(this.fontColorButton);
            this.overlayTab.Controls.Add(this.fontColorLabel);
            this.overlayTab.Controls.Add(this.fontLabel);
            this.overlayTab.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overlayTab.Location = new System.Drawing.Point(4, 22);
            this.overlayTab.Name = "overlayTab";
            this.overlayTab.Padding = new System.Windows.Forms.Padding(3);
            this.overlayTab.Size = new System.Drawing.Size(363, 308);
            this.overlayTab.TabIndex = 0;
            this.overlayTab.Text = "Overlay";
            this.overlayTab.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(363, 332);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // fontLabel
            // 
            this.fontLabel.AutoSize = true;
            this.fontLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.fontLabel.Location = new System.Drawing.Point(6, 20);
            this.fontLabel.Name = "fontLabel";
            this.fontLabel.Size = new System.Drawing.Size(56, 24);
            this.fontLabel.TabIndex = 0;
            this.fontLabel.Text = "Font:";
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.fontColorLabel.Location = new System.Drawing.Point(6, 65);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(108, 24);
            this.fontColorLabel.TabIndex = 2;
            this.fontColorLabel.Text = "Font Color:";
            // 
            // fontColorButton
            // 
            this.fontColorButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorButton.Location = new System.Drawing.Point(245, 65);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(96, 25);
            this.fontColorButton.TabIndex = 3;
            this.fontColorButton.Text = "Select Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontColorValue
            // 
            this.fontColorValue.Location = new System.Drawing.Point(130, 67);
            this.fontColorValue.Multiline = true;
            this.fontColorValue.Name = "fontColorValue";
            this.fontColorValue.ReadOnly = true;
            this.fontColorValue.Size = new System.Drawing.Size(99, 20);
            this.fontColorValue.TabIndex = 4;
            // 
            // fontValue
            // 
            this.fontValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.fontValue.Location = new System.Drawing.Point(130, 25);
            this.fontValue.Name = "fontValue";
            this.fontValue.ReadOnly = true;
            this.fontValue.Size = new System.Drawing.Size(99, 20);
            this.fontValue.TabIndex = 6;
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontButton.Location = new System.Drawing.Point(245, 23);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(96, 25);
            this.fontButton.TabIndex = 5;
            this.fontButton.Text = "Select Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // fontPositionLabel
            // 
            this.fontPositionLabel.AutoSize = true;
            this.fontPositionLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.fontPositionLabel.Location = new System.Drawing.Point(6, 114);
            this.fontPositionLabel.Name = "fontPositionLabel";
            this.fontPositionLabel.Size = new System.Drawing.Size(132, 24);
            this.fontPositionLabel.TabIndex = 7;
            this.fontPositionLabel.Text = "Font Position:";
            // 
            // positionXLabel
            // 
            this.positionXLabel.AutoSize = true;
            this.positionXLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.positionXLabel.Location = new System.Drawing.Point(145, 117);
            this.positionXLabel.Name = "positionXLabel";
            this.positionXLabel.Size = new System.Drawing.Size(27, 18);
            this.positionXLabel.TabIndex = 8;
            this.positionXLabel.Text = "x=";
            // 
            // positionXValue
            // 
            this.positionXValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.positionXValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionXValue.Location = new System.Drawing.Point(167, 116);
            this.positionXValue.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.positionXValue.Name = "positionXValue";
            this.positionXValue.Size = new System.Drawing.Size(62, 22);
            this.positionXValue.TabIndex = 9;
            this.positionXValue.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            // 
            // positionYValue
            // 
            this.positionYValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.positionYValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionYValue.Location = new System.Drawing.Point(269, 116);
            this.positionYValue.Maximum = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            this.positionYValue.Name = "positionYValue";
            this.positionYValue.Size = new System.Drawing.Size(62, 22);
            this.positionYValue.TabIndex = 11;
            this.positionYValue.Value = new decimal(new int[] {
            4096,
            0,
            0,
            0});
            // 
            // positionYLabel
            // 
            this.positionYLabel.AutoSize = true;
            this.positionYLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.positionYLabel.Location = new System.Drawing.Point(247, 117);
            this.positionYLabel.Name = "positionYLabel";
            this.positionYLabel.Size = new System.Drawing.Size(27, 18);
            this.positionYLabel.TabIndex = 10;
            this.positionYLabel.Text = "y=";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(304, 352);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(223, 352);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 382);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsTabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.Text = "fTimer\'s Settings";
            this.settingsTabs.ResumeLayout(false);
            this.overlayTab.ResumeLayout(false);
            this.overlayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionXValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionYValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage overlayTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label fontLabel;
        private System.Windows.Forms.Label fontColorLabel;
        private System.Windows.Forms.Button fontColorButton;
        private System.Windows.Forms.ColorDialog fontColorDialog;
        private System.Windows.Forms.TextBox fontColorValue;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.TextBox fontValue;
        private System.Windows.Forms.Button fontButton;
        private System.Windows.Forms.Label fontPositionLabel;
        private System.Windows.Forms.Label positionXLabel;
        private System.Windows.Forms.NumericUpDown positionXValue;
        private System.Windows.Forms.NumericUpDown positionYValue;
        private System.Windows.Forms.Label positionYLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}