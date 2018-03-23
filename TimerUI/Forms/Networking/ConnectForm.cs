using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerUI.Forms.Networking
{
    public partial class ConnectForm : Form
    {
        private MainForm parentForm;

        public ConnectForm(MainForm parent)
        {
            InitializeComponent();

            parentForm = parent;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (ipValue.Text == "")
            {
                MessageBox.Show("IP Adress must be filled.");
                return;
            }

            parentForm.ConnectToServer(ipValue.Text, (int)portValue.Value);
            Dispose();
        }
    }
}
