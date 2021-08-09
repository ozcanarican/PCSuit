using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOSharp
{
    public partial class GameWindow : Form
    {
        private bool mouseDown;
        private System.Drawing.Point lastLocation;

        public GameWindow()
        {
            InitializeComponent();
            Screen rightmost = Screen.AllScreens[0];
            this.Left = (rightmost.WorkingArea.Right / 2) - (this.Width / 2);
            this.Top = 0;
        }

        public void setDown(String s)
        {
            labDown.Text = s;
        }

        public void setGpu(String s)
        {
            labGpu.Text = s;
        }
        public void setCpu(String s)
        {
            labCpu.Text = s;
        }

        public void setLoadGpu(String s)
        {
            labLoadGpu.Text = s;
        }
        public void setLoadCpu(String s)
        {
            labLoadCpu.Text = s;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new System.Drawing.Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


    }
}
