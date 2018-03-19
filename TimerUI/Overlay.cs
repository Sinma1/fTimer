using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TimerUI
{

    public partial class Overlay : Form
    {
        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        private MainWindow parentWindow;

        public Overlay(MainWindow parentWindow)
        {
            InitializeComponent();

            ShowIcon = false;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;

            var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | 0x80000 | 0x20);

            this.parentWindow = parentWindow;

            Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            foreach (var summoner in parentWindow.SummonersList)
            {
                string name = summoner.Name;
            }
        }
    }
}
