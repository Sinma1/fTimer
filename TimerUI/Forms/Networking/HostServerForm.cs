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
    public partial class HostServerForm : Form
    {
        private MainForm parentForm;

        public HostServerForm(MainForm parent)
        {
            InitializeComponent();

            parentForm = parent;
        }

        private void hostButton_Click(object sender, EventArgs e)
        {
            parentForm.StartServer((int)portValue.Value);
            Dispose();
        }
    }
}
