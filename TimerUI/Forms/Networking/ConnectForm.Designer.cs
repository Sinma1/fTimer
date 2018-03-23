namespace TimerUI.Forms.Networking
{
    partial class ConnectForm
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipValue = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.portValue = new System.Windows.Forms.NumericUpDown();
            this.connectButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).BeginInit();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.ipLabel.Location = new System.Drawing.Point(12, 9);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(38, 24);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP:";
            // 
            // ipValue
            // 
            this.ipValue.Location = new System.Drawing.Point(86, 12);
            this.ipValue.Name = "ipValue";
            this.ipValue.Size = new System.Drawing.Size(100, 20);
            this.ipValue.TabIndex = 1;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portLabel.Location = new System.Drawing.Point(8, 33);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(72, 24);
            this.portLabel.TabIndex = 2;
            this.portLabel.Text = "PORT:";
            // 
            // portValue
            // 
            this.portValue.Location = new System.Drawing.Point(86, 37);
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
            this.portValue.TabIndex = 2;
            this.portValue.Value = new decimal(new int[] {
            12345,
            0,
            0,
            0});
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(42, 69);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(117, 32);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // ConnectForm
            // 
            this.AcceptButton = this.connectButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(200, 111);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portValue);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.ipValue);
            this.Controls.Add(this.ipLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Connect to server";
            ((System.ComponentModel.ISupportInitialize)(this.portValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox ipValue;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.NumericUpDown portValue;
        private System.Windows.Forms.Button connectButton;
    }
}