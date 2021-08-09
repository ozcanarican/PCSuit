using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using Brushes = System.Windows.Media.Brushes;
using LiveCharts;
using LiveCharts.WinForms;

namespace ISOSharp
{
    public partial class GameBar : Form
    {
        Form main;
        //AngularGauge angularGauge1;
        public enum Sizes { BIG, MEDIUM, SMALL, NOTIFY }
        public Sizes size = Sizes.BIG;
        public int tip = 0;
        private bool mouseDown;
        private System.Drawing.Point lastLocation;
        private static System.Timers.Timer timer;
        public Thread ping;
        public bool shouldRun = true;
        Color mainColor;
        IntPtr hIcon;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);

        private const String APP_ID = "Microsoft.Samples.DesktopToastsSample";
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public GameBar()
        {
            main = this;
            InitializeComponent();

           
        }

        void showMessage()
        {
            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                // optional - BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info,
                // optional - BalloonTipTitle = "My Title",
                BalloonTipText = "Internet geri geldi",
            };

            // Display for 5 seconds.
            notification.ShowBalloonTip(5000);

            // This will let the balloon close after it's 5 second timeout
            // for demonstration purposes. Comment this out to see what happens
            // when dispose is called while a balloon is still visible.
            Thread.Sleep(10000);

            // The notification should be disposed when you don't need it anymore,
            // but doing so will immediately close the balloon if it's visible.
            notification.Dispose();
        }

    public void PingHost()
        {
            while(shouldRun) { 
                try
                {
                    Ping myPing = new Ping();
                    PingReply reply = myPing.Send("google.com.tr", 1000);
                    if (reply != null)
                    {
                        Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                        if(reply.Status.ToString() == "Success")
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.label1.Text = reply.RoundtripTime.ToString();
                                if (Datalar.pingCount > 15)
                                {
                                    Thread th = new Thread(showMessage);
                                    th.Start();
                                }
                                
                                
                            });
                            Datalar.pingCount = 0;
                        } else
                        {
                            Datalar.pingCount = Datalar.pingCount + 1;
                            Console.WriteLine("ping count = " + Datalar.pingCount);
                            this.Invoke((MethodInvoker)delegate
                            {
                                this.label1.Text = "--";
                            });
                        }
                    }
                }
                catch
                {
                    Datalar.pingCount = Datalar.pingCount + 1;
                    Console.WriteLine("ping count = " + Datalar.pingCount);
                    Console.WriteLine("ERROR: You have Some TIMEOUT issue");
                }
                Thread.Sleep(2000);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            notifyIcon1.Visible = false;
        }

        public void kapat()
        {
            notifyIcon1.Visible = false;
        }

        public void changeSize(Sizes newSize)
        {
            this.Visible = true;
            size = newSize;
            Size s = new Size(120, 120);
            Size fs = new Size(128, 30);
            notifyIcon1.Visible = false;
            switch (newSize)
            {
                case Sizes.BIG:
                    s = new Size(120, 129);
                    tTitle.Font = new Font("Arial", 10, FontStyle.Bold);
                    label1.Font = new Font("Arial", 28, FontStyle.Bold);
                    break;
                case Sizes.MEDIUM:
                    s = new Size(80, 80);
                    tTitle.Font = new Font("Arial", 10, FontStyle.Bold);

                    label1.Font = new Font("Arial", 21, FontStyle.Bold);
                    break;
                case Sizes.SMALL:
                    fs = new Size(34, 5);
                    s = new Size(64, 44);
                    tTitle.Font = new Font("Arial", 8, FontStyle.Bold);
                    label1.Font = new Font("Arial", 12, FontStyle.Regular);
                    break;
                case Sizes.NOTIFY:
                    this.Visible = false;
                    notifyIcon1.Visible = true;
                    break;
            }
         
            this.Size = s;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 5, 5));
            Console.WriteLine(size + " " + tip);
            
           
          
        }

        public void setType(int i)
        {
            tip = i;
            
            switch (i)
            {
                case 0:
                    tTitle.Text = "CPU °";
                    this.Location = Properties.Settings.Default.PosHeatCpu;
                    notifyIcon1.Text = "CPU HEAT";
                    mainColor = Color.Red;
                    break;
                case 1:
                    tTitle.Text = "GPU °";
                    this.Location = Properties.Settings.Default.PostHeatGpu;
                    notifyIcon1.Text = "GPU HEAT";
                    mainColor = Color.Blue;
                    break;
                case 2:
                    tTitle.Text = "CPU %";
                    this.Location = Properties.Settings.Default.PosLoadCpu;
                    notifyIcon1.Text = "CPU LOAD";
                    mainColor = Color.DarkRed;
                    break;
                case 3:
                    tTitle.Text = "GPU %";
                    this.Location = Properties.Settings.Default.PosLoadGpu;
                    notifyIcon1.Text = "GPU LOAD";
                    mainColor = Color.Black;
                    break;
                case 4:
                    tTitle.Text = "DOWN";
                    this.Location = Properties.Settings.Default.PosDown;
                    notifyIcon1.Text = "DOWNLOAD (mbps)";
                    mainColor = Color.Purple;
                    break;
                case 5:
                    tTitle.Text = "PING";
                    this.Location = Properties.Settings.Default.PosPing;
                    ping = new Thread(PingHost);
                    ping.Start();
                    notifyIcon1.Text = "PING";
                    mainColor = Color.Purple;
                    break;

            }

           

        }

        public void setVal(String val)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                   
                    this.label1.Text = val;
                    if (size == Sizes.NOTIFY)
                    {
                        CreateTextIcon(val);
                    }
                    //lVal.Text = val;
                });
            }
            catch (Exception e) { }
        }

        public void CreateTextIcon(string str)
        {
            double kac = double.Parse(str);
            int ikac = Convert.ToInt32((kac / 125));
            if (size == Sizes.NOTIFY && tip == 4)
            {
                str = ikac.ToString();
            }
            try
            {
                Font fontToUse = new Font("Microsoft Sans Serif", 16, FontStyle.Regular, GraphicsUnit.Pixel);
                Brush brushToUse = new SolidBrush(Color.White);
                Bitmap bitmapText = new Bitmap(16, 16);
                Graphics g = System.Drawing.Graphics.FromImage(bitmapText);


                g.Clear(mainColor);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
                if(kac > 9)
                {
                    g.DrawString(str, fontToUse, brushToUse, -4, -2);
                }
                else
                {
                    g.DrawString(str, fontToUse, brushToUse, 0, -2);
                }
                if (hIcon != null)
                {
                    DestroyIcon(hIcon);
                }
                hIcon = (bitmapText.GetHicon());
                notifyIcon1.Icon = System.Drawing.Icon.FromHandle(hIcon);
            }
            catch (Exception e) {
                System.Diagnostics.Debug.Write("Icon hatası: " + e.ToString());
            }
            
            //DestroyIcon(hIcon.ToInt32);
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
            /*switch(type)
            {
                case 0:
                    Properties.Settings.Default.PosHeatCpu = this.Location;
                    break;
                case 1:
                    Properties.Settings.Default.PostHeatGpu = this.Location;
                    break;
                case 2:
                    Properties.Settings.Default.PosLoadCpu = this.Location;
                    break;
                case 3:
                    Properties.Settings.Default.PosLoadGpu = this.Location;
                    break;
                case 4:
                    Properties.Settings.Default.PosDown = this.Location;
                    break;
                case 5:
                    Properties.Settings.Default.PosPing = this.Location;
                    break;
            }*/
            
        }

        private void GameBar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tip == 5)
            {
                Console.WriteLine("closing");
                shouldRun = false;
            }
        }

        private void GameBar_Shown(object sender, EventArgs e)
        {   

            Sizes newSize = size;
            Size s = new Size(128, 128);
            Size fs = new Size(128, 30);
            changeSize(newSize);

            

            /*switch (newSize)
             {
                 case Sizes.BIG:
                     s = new Size(128, 128);
                     label1.Font = new Font("Arial", 21, FontStyle.Bold);
                     break;
                 case Sizes.MEDIUM:
                     fs = new Size(34, 20);
                     s = new Size(64, 64);
                     label1.Font = new Font("Arial", 10, FontStyle.Regular);
                     break;
                 case Sizes.SMALL:
                     s = new Size(28, 32);
                     fs = new Size(28, 32);
                     label1.Font = new Font("Arial", 7, FontStyle.Regular);
                     break;
             }
             label1.Size = fs;
             this.Size = s;*/
        }
    }
}
