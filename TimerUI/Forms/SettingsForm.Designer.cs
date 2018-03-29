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
            this.positionYValue = new System.Windows.Forms.NumericUpDown();
            this.positionYLabel = new System.Windows.Forms.Label();
            this.positionXValue = new System.Windows.Forms.NumericUpDown();
            this.positionXLabel = new System.Windows.Forms.Label();
            this.fontPositionLabel = new System.Windows.Forms.Label();
            this.fontValue = new System.Windows.Forms.TextBox();
            this.fontButton = new System.Windows.Forms.Button();
            this.fontColorValue = new System.Windows.Forms.TextBox();
            this.fontColorButton = new System.Windows.Forms.Button();
            this.fontColorLabel = new System.Windows.Forms.Label();
            this.fontLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.supportSecondSpellValue = new System.Windows.Forms.TextBox();
            this.supportSecondSpellLabel = new System.Windows.Forms.Label();
            this.adcSecondSpellValue = new System.Windows.Forms.TextBox();
            this.supportFirstSpellValue = new System.Windows.Forms.TextBox();
            this.adcSecondSpellLabel = new System.Windows.Forms.Label();
            this.supportFirstSpellLabel = new System.Windows.Forms.Label();
            this.adcFirstSpellValue = new System.Windows.Forms.TextBox();
            this.adcFirstSpellLabel = new System.Windows.Forms.Label();
            this.midSecondSpellValue = new System.Windows.Forms.TextBox();
            this.midSecondSpellLabel = new System.Windows.Forms.Label();
            this.midFirstSpellValue = new System.Windows.Forms.TextBox();
            this.midFirstSpellLabel = new System.Windows.Forms.Label();
            this.jungleSecondSpellValue = new System.Windows.Forms.TextBox();
            this.jungleSecondSpellLabel = new System.Windows.Forms.Label();
            this.jungleFirstSpellValue = new System.Windows.Forms.TextBox();
            this.jungleFirstSpellLabel = new System.Windows.Forms.Label();
            this.topSecondSpellValue = new System.Windows.Forms.TextBox();
            this.topSecondSpellLabel = new System.Windows.Forms.Label();
            this.topFirstSpellValue = new System.Windows.Forms.TextBox();
            this.topFirstSpellLabel = new System.Windows.Forms.Label();
            this.fontColorDialog = new System.Windows.Forms.ColorDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.settingsTabs.SuspendLayout();
            this.overlayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionYValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXValue)).BeginInit();
            this.tabPage2.SuspendLayout();
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
            this.settingsTabs.Size = new System.Drawing.Size(331, 390);
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
            this.overlayTab.Size = new System.Drawing.Size(323, 364);
            this.overlayTab.TabIndex = 0;
            this.overlayTab.Text = "Overlay";
            this.overlayTab.UseVisualStyleBackColor = true;
            this.overlayTab.Click += new System.EventHandler(this.StopFocus);
            // 
            // positionYValue
            // 
            this.positionYValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.positionYValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionYValue.Location = new System.Drawing.Point(167, 154);
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
            this.positionYLabel.Location = new System.Drawing.Point(145, 155);
            this.positionYLabel.Name = "positionYLabel";
            this.positionYLabel.Size = new System.Drawing.Size(27, 18);
            this.positionYLabel.TabIndex = 10;
            this.positionYLabel.Text = "y=";
            // 
            // positionXValue
            // 
            this.positionXValue.Font = new System.Drawing.Font("Tahoma", 9F);
            this.positionXValue.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.positionXValue.Location = new System.Drawing.Point(167, 126);
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
            // positionXLabel
            // 
            this.positionXLabel.AutoSize = true;
            this.positionXLabel.Font = new System.Drawing.Font("Tahoma", 11F);
            this.positionXLabel.Location = new System.Drawing.Point(145, 127);
            this.positionXLabel.Name = "positionXLabel";
            this.positionXLabel.Size = new System.Drawing.Size(27, 18);
            this.positionXLabel.TabIndex = 8;
            this.positionXLabel.Text = "x=";
            // 
            // fontPositionLabel
            // 
            this.fontPositionLabel.AutoSize = true;
            this.fontPositionLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.fontPositionLabel.Location = new System.Drawing.Point(6, 138);
            this.fontPositionLabel.Name = "fontPositionLabel";
            this.fontPositionLabel.Size = new System.Drawing.Size(132, 24);
            this.fontPositionLabel.TabIndex = 7;
            this.fontPositionLabel.Text = "Font Position:";
            // 
            // fontValue
            // 
            this.fontValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.fontValue.Location = new System.Drawing.Point(120, 26);
            this.fontValue.Name = "fontValue";
            this.fontValue.ReadOnly = true;
            this.fontValue.Size = new System.Drawing.Size(88, 20);
            this.fontValue.TabIndex = 6;
            // 
            // fontButton
            // 
            this.fontButton.Font = new System.Drawing.Font("Tahoma", 8F);
            this.fontButton.Location = new System.Drawing.Point(214, 26);
            this.fontButton.Name = "fontButton";
            this.fontButton.Size = new System.Drawing.Size(96, 20);
            this.fontButton.TabIndex = 5;
            this.fontButton.Text = "Select Font";
            this.fontButton.UseVisualStyleBackColor = true;
            this.fontButton.Click += new System.EventHandler(this.fontButton_Click);
            // 
            // fontColorValue
            // 
            this.fontColorValue.Location = new System.Drawing.Point(120, 81);
            this.fontColorValue.Multiline = true;
            this.fontColorValue.Name = "fontColorValue";
            this.fontColorValue.ReadOnly = true;
            this.fontColorValue.Size = new System.Drawing.Size(88, 20);
            this.fontColorValue.TabIndex = 4;
            // 
            // fontColorButton
            // 
            this.fontColorButton.Font = new System.Drawing.Font("Tahoma", 8F);
            this.fontColorButton.Location = new System.Drawing.Point(214, 81);
            this.fontColorButton.Name = "fontColorButton";
            this.fontColorButton.Size = new System.Drawing.Size(96, 20);
            this.fontColorButton.TabIndex = 3;
            this.fontColorButton.Text = "Select Color";
            this.fontColorButton.UseVisualStyleBackColor = true;
            this.fontColorButton.Click += new System.EventHandler(this.fontColorButton_Click);
            // 
            // fontColorLabel
            // 
            this.fontColorLabel.AutoSize = true;
            this.fontColorLabel.Font = new System.Drawing.Font("Tahoma", 15F);
            this.fontColorLabel.Location = new System.Drawing.Point(6, 77);
            this.fontColorLabel.Name = "fontColorLabel";
            this.fontColorLabel.Size = new System.Drawing.Size(108, 24);
            this.fontColorLabel.TabIndex = 2;
            this.fontColorLabel.Text = "Font Color:";
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
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.supportSecondSpellValue);
            this.tabPage2.Controls.Add(this.supportSecondSpellLabel);
            this.tabPage2.Controls.Add(this.adcSecondSpellValue);
            this.tabPage2.Controls.Add(this.supportFirstSpellValue);
            this.tabPage2.Controls.Add(this.adcSecondSpellLabel);
            this.tabPage2.Controls.Add(this.supportFirstSpellLabel);
            this.tabPage2.Controls.Add(this.adcFirstSpellValue);
            this.tabPage2.Controls.Add(this.adcFirstSpellLabel);
            this.tabPage2.Controls.Add(this.midSecondSpellValue);
            this.tabPage2.Controls.Add(this.midSecondSpellLabel);
            this.tabPage2.Controls.Add(this.midFirstSpellValue);
            this.tabPage2.Controls.Add(this.midFirstSpellLabel);
            this.tabPage2.Controls.Add(this.jungleSecondSpellValue);
            this.tabPage2.Controls.Add(this.jungleSecondSpellLabel);
            this.tabPage2.Controls.Add(this.jungleFirstSpellValue);
            this.tabPage2.Controls.Add(this.jungleFirstSpellLabel);
            this.tabPage2.Controls.Add(this.topSecondSpellValue);
            this.tabPage2.Controls.Add(this.topSecondSpellLabel);
            this.tabPage2.Controls.Add(this.topFirstSpellValue);
            this.tabPage2.Controls.Add(this.topFirstSpellLabel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(323, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Hotkeys";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.StopFocus);
            // 
            // supportSecondSpellValue
            // 
            this.supportSecondSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.supportSecondSpellValue.Location = new System.Drawing.Point(178, 326);
            this.supportSecondSpellValue.Name = "supportSecondSpellValue";
            this.supportSecondSpellValue.ReadOnly = true;
            this.supportSecondSpellValue.Size = new System.Drawing.Size(112, 20);
            this.supportSecondSpellValue.TabIndex = 25;
            this.supportSecondSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // supportSecondSpellLabel
            // 
            this.supportSecondSpellLabel.AutoSize = true;
            this.supportSecondSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.supportSecondSpellLabel.Location = new System.Drawing.Point(6, 327);
            this.supportSecondSpellLabel.Name = "supportSecondSpellLabel";
            this.supportSecondSpellLabel.Size = new System.Drawing.Size(139, 17);
            this.supportSecondSpellLabel.TabIndex = 24;
            this.supportSecondSpellLabel.Text = "Support Second Spell";
            // 
            // adcSecondSpellValue
            // 
            this.adcSecondSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.adcSecondSpellValue.Location = new System.Drawing.Point(178, 254);
            this.adcSecondSpellValue.Name = "adcSecondSpellValue";
            this.adcSecondSpellValue.ReadOnly = true;
            this.adcSecondSpellValue.Size = new System.Drawing.Size(112, 20);
            this.adcSecondSpellValue.TabIndex = 21;
            this.adcSecondSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // supportFirstSpellValue
            // 
            this.supportFirstSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.supportFirstSpellValue.Location = new System.Drawing.Point(178, 300);
            this.supportFirstSpellValue.Name = "supportFirstSpellValue";
            this.supportFirstSpellValue.ReadOnly = true;
            this.supportFirstSpellValue.Size = new System.Drawing.Size(112, 20);
            this.supportFirstSpellValue.TabIndex = 23;
            this.supportFirstSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // adcSecondSpellLabel
            // 
            this.adcSecondSpellLabel.AutoSize = true;
            this.adcSecondSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.adcSecondSpellLabel.Location = new System.Drawing.Point(6, 255);
            this.adcSecondSpellLabel.Name = "adcSecondSpellLabel";
            this.adcSecondSpellLabel.Size = new System.Drawing.Size(112, 17);
            this.adcSecondSpellLabel.TabIndex = 20;
            this.adcSecondSpellLabel.Text = "Adc Second Spell";
            // 
            // supportFirstSpellLabel
            // 
            this.supportFirstSpellLabel.AutoSize = true;
            this.supportFirstSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.supportFirstSpellLabel.Location = new System.Drawing.Point(6, 301);
            this.supportFirstSpellLabel.Name = "supportFirstSpellLabel";
            this.supportFirstSpellLabel.Size = new System.Drawing.Size(118, 17);
            this.supportFirstSpellLabel.TabIndex = 22;
            this.supportFirstSpellLabel.Text = "Support First Spell";
            // 
            // adcFirstSpellValue
            // 
            this.adcFirstSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.adcFirstSpellValue.Location = new System.Drawing.Point(178, 228);
            this.adcFirstSpellValue.Name = "adcFirstSpellValue";
            this.adcFirstSpellValue.ReadOnly = true;
            this.adcFirstSpellValue.Size = new System.Drawing.Size(112, 20);
            this.adcFirstSpellValue.TabIndex = 19;
            this.adcFirstSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // adcFirstSpellLabel
            // 
            this.adcFirstSpellLabel.AutoSize = true;
            this.adcFirstSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.adcFirstSpellLabel.Location = new System.Drawing.Point(6, 229);
            this.adcFirstSpellLabel.Name = "adcFirstSpellLabel";
            this.adcFirstSpellLabel.Size = new System.Drawing.Size(91, 17);
            this.adcFirstSpellLabel.TabIndex = 18;
            this.adcFirstSpellLabel.Text = "Adc First Spell";
            // 
            // midSecondSpellValue
            // 
            this.midSecondSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.midSecondSpellValue.Location = new System.Drawing.Point(178, 184);
            this.midSecondSpellValue.Name = "midSecondSpellValue";
            this.midSecondSpellValue.ReadOnly = true;
            this.midSecondSpellValue.Size = new System.Drawing.Size(112, 20);
            this.midSecondSpellValue.TabIndex = 17;
            this.midSecondSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // midSecondSpellLabel
            // 
            this.midSecondSpellLabel.AutoSize = true;
            this.midSecondSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.midSecondSpellLabel.Location = new System.Drawing.Point(6, 185);
            this.midSecondSpellLabel.Name = "midSecondSpellLabel";
            this.midSecondSpellLabel.Size = new System.Drawing.Size(109, 17);
            this.midSecondSpellLabel.TabIndex = 16;
            this.midSecondSpellLabel.Text = "Mid Second Spell";
            // 
            // midFirstSpellValue
            // 
            this.midFirstSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.midFirstSpellValue.Location = new System.Drawing.Point(178, 158);
            this.midFirstSpellValue.Name = "midFirstSpellValue";
            this.midFirstSpellValue.ReadOnly = true;
            this.midFirstSpellValue.Size = new System.Drawing.Size(112, 20);
            this.midFirstSpellValue.TabIndex = 15;
            this.midFirstSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // midFirstSpellLabel
            // 
            this.midFirstSpellLabel.AutoSize = true;
            this.midFirstSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.midFirstSpellLabel.Location = new System.Drawing.Point(6, 159);
            this.midFirstSpellLabel.Name = "midFirstSpellLabel";
            this.midFirstSpellLabel.Size = new System.Drawing.Size(88, 17);
            this.midFirstSpellLabel.TabIndex = 14;
            this.midFirstSpellLabel.Text = "Mid First Spell";
            // 
            // jungleSecondSpellValue
            // 
            this.jungleSecondSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.jungleSecondSpellValue.Location = new System.Drawing.Point(178, 114);
            this.jungleSecondSpellValue.Name = "jungleSecondSpellValue";
            this.jungleSecondSpellValue.ReadOnly = true;
            this.jungleSecondSpellValue.Size = new System.Drawing.Size(112, 20);
            this.jungleSecondSpellValue.TabIndex = 13;
            this.jungleSecondSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // jungleSecondSpellLabel
            // 
            this.jungleSecondSpellLabel.AutoSize = true;
            this.jungleSecondSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.jungleSecondSpellLabel.Location = new System.Drawing.Point(6, 115);
            this.jungleSecondSpellLabel.Name = "jungleSecondSpellLabel";
            this.jungleSecondSpellLabel.Size = new System.Drawing.Size(128, 17);
            this.jungleSecondSpellLabel.TabIndex = 12;
            this.jungleSecondSpellLabel.Text = "Jungle Second Spell";
            // 
            // jungleFirstSpellValue
            // 
            this.jungleFirstSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.jungleFirstSpellValue.Location = new System.Drawing.Point(178, 88);
            this.jungleFirstSpellValue.Name = "jungleFirstSpellValue";
            this.jungleFirstSpellValue.ReadOnly = true;
            this.jungleFirstSpellValue.Size = new System.Drawing.Size(112, 20);
            this.jungleFirstSpellValue.TabIndex = 11;
            this.jungleFirstSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // jungleFirstSpellLabel
            // 
            this.jungleFirstSpellLabel.AutoSize = true;
            this.jungleFirstSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.jungleFirstSpellLabel.Location = new System.Drawing.Point(6, 89);
            this.jungleFirstSpellLabel.Name = "jungleFirstSpellLabel";
            this.jungleFirstSpellLabel.Size = new System.Drawing.Size(107, 17);
            this.jungleFirstSpellLabel.TabIndex = 10;
            this.jungleFirstSpellLabel.Text = "Jungle First Spell";
            // 
            // topSecondSpellValue
            // 
            this.topSecondSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.topSecondSpellValue.Location = new System.Drawing.Point(178, 44);
            this.topSecondSpellValue.Name = "topSecondSpellValue";
            this.topSecondSpellValue.ReadOnly = true;
            this.topSecondSpellValue.Size = new System.Drawing.Size(112, 20);
            this.topSecondSpellValue.TabIndex = 9;
            this.topSecondSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // topSecondSpellLabel
            // 
            this.topSecondSpellLabel.AutoSize = true;
            this.topSecondSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.topSecondSpellLabel.Location = new System.Drawing.Point(6, 45);
            this.topSecondSpellLabel.Name = "topSecondSpellLabel";
            this.topSecondSpellLabel.Size = new System.Drawing.Size(113, 17);
            this.topSecondSpellLabel.TabIndex = 8;
            this.topSecondSpellLabel.Text = "Top Second Spell";
            // 
            // topFirstSpellValue
            // 
            this.topFirstSpellValue.Font = new System.Drawing.Font("Tahoma", 8F);
            this.topFirstSpellValue.Location = new System.Drawing.Point(178, 18);
            this.topFirstSpellValue.Name = "topFirstSpellValue";
            this.topFirstSpellValue.ReadOnly = true;
            this.topFirstSpellValue.Size = new System.Drawing.Size(112, 20);
            this.topFirstSpellValue.TabIndex = 7;
            this.topFirstSpellValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptureHotkey);
            // 
            // topFirstSpellLabel
            // 
            this.topFirstSpellLabel.AutoSize = true;
            this.topFirstSpellLabel.Font = new System.Drawing.Font("Tahoma", 10F);
            this.topFirstSpellLabel.Location = new System.Drawing.Point(6, 19);
            this.topFirstSpellLabel.Name = "topFirstSpellLabel";
            this.topFirstSpellLabel.Size = new System.Drawing.Size(92, 17);
            this.topFirstSpellLabel.TabIndex = 1;
            this.topFirstSpellLabel.Text = "Top First Spell";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Location = new System.Drawing.Point(264, 408);
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
            this.cancelButton.Location = new System.Drawing.Point(183, 408);
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
            this.ClientSize = new System.Drawing.Size(355, 438);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.settingsTabs);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fTimer\'s Settings";
            this.Click += new System.EventHandler(this.StopFocus);
            this.settingsTabs.ResumeLayout(false);
            this.overlayTab.ResumeLayout(false);
            this.overlayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionYValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionXValue)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
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
        private System.Windows.Forms.TextBox topFirstSpellValue;
        private System.Windows.Forms.Label topFirstSpellLabel;
        private System.Windows.Forms.TextBox topSecondSpellValue;
        private System.Windows.Forms.Label topSecondSpellLabel;
        private System.Windows.Forms.TextBox supportSecondSpellValue;
        private System.Windows.Forms.Label supportSecondSpellLabel;
        private System.Windows.Forms.TextBox adcSecondSpellValue;
        private System.Windows.Forms.TextBox supportFirstSpellValue;
        private System.Windows.Forms.Label adcSecondSpellLabel;
        private System.Windows.Forms.Label supportFirstSpellLabel;
        private System.Windows.Forms.TextBox adcFirstSpellValue;
        private System.Windows.Forms.Label adcFirstSpellLabel;
        private System.Windows.Forms.TextBox midSecondSpellValue;
        private System.Windows.Forms.Label midSecondSpellLabel;
        private System.Windows.Forms.TextBox midFirstSpellValue;
        private System.Windows.Forms.Label midFirstSpellLabel;
        private System.Windows.Forms.TextBox jungleSecondSpellValue;
        private System.Windows.Forms.Label jungleSecondSpellLabel;
        private System.Windows.Forms.TextBox jungleFirstSpellValue;
        private System.Windows.Forms.Label jungleFirstSpellLabel;
    }
}