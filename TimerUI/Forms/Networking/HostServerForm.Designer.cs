namespace TimerUI.Forms.Networking
{
    partial class HostServerForm
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
            this.hostButton = new System.Windows.Forms.Button();
            this.portValue = new System.Windows.Forms.NumericUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).BeginInit();
            this.SuspendLayout();
            // 
            // hostButton
            // 
            this.hostButton.Location = new System.Drawing.Point(46, 52);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(117, 32);
            this.hostButton.TabIndex = 7;
            this.hostButton.Text = "Host a server";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(90, 19);
            this.portValue.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.portValue.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.portValue.Name = "portValue";
            this.portValue.Size = new System.Drawing.Size(100, 20);
            this.portValue.TabIndex = 5;
            this.portValue.Value = new decimal(new int[] {
            12345,
            0,
            0,
            0});
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(12, 16);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(72, 24);
            this.portLabel.TabIndex = 6;
            this.portLabel.Text = "PORT:";
            // 
            // HostServerForm
            // 
            this.AcceptButton = this.hostButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(208, 95);
            this.Controls.Add(this.hostButton);
            this.Controls.Add(this.portValue);
            this.Controls.Add(this.portLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HostServerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Host a server";
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.NumericUpDown portValue;
        private System.Windows.Forms.Label portLabel;
    }
}