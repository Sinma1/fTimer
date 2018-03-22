using System;
using System.Drawing;
using System.Windows.Forms;

namespace TimerUI.UserControls
{
    public partial class GroupBoxTest : Form
    {
        private void GroupBoxTest_Load(object sender, EventArgs e)
        {
            var myGroupBox = new MyGroupBox
            {
                Text = @"GroupBox1",
                BorderColor = Color.Red
            };
            this.Controls.Add(myGroupBox);
        }
    }
    public class MyGroupBox : GroupBox
    {
        public Color BorderColor { get; set; }

        public MyGroupBox()
        {
            this.BorderColor = Color.Black;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var tSize = TextRenderer.MeasureText(this.Text, this.Font);

            var borderRect = e.ClipRectangle;
            borderRect.Y += tSize.Height / 2;
            borderRect.Height -= tSize.Height / 2;
            ControlPaint.DrawBorder(e.Graphics, borderRect, this.BorderColor, ButtonBorderStyle.Solid);      
            var textRect = e.ClipRectangle;
            textRect.X += 6;
            textRect.Width = tSize.Width;
            textRect.Height = tSize.Height;
            e.Graphics.FillRectangle(new SolidBrush(this.BackColor), textRect);
            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), textRect);
        }
    }
}
