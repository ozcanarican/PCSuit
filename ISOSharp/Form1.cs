using System;
using System.Windows;
using System.Windows.Forms;
using LiveCharts.Wpf;
using Brushes = System.Windows.Media.Brushes;
using System.Windows.Media;
using Application = System.Windows.Forms.Application;
using System.Collections.Generic;
using System.Management;
using System.Linq;
using System.Runtime.InteropServices;
using LiveCharts;
using SpeedTest.Net;

namespace ISOSharp
{
    

    public partial class Form1 : Form
    {
        private GameBar barHeatCpu, barHeatGpu, barLoadCpu, barLoadGpu, barDownload, barPing;
        private bool mouseDown;
        private System.Drawing.Point lastLocation;
        public int maxCpu, maxGpu = 0;
        Network network;
        System.Drawing.Color grey, white,bg;
        Monitor monitor;
        List<GameBar> bars = new List<GameBar>();
        GameBar.Sizes currentSize = GameBar.Sizes.BIG;
        SeriesCollection networkSeries = new SeriesCollection();
        LineSeries downData = new LineSeries();
        LineSeries upData = new LineSeries();
        public ChartValues<double> downs = new ChartValues<double> { };
        public ChartValues<double> ups = new ChartValues<double> { };

        //GameWindow gw;

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

        async System.Threading.Tasks.Task speedTestAsync()
        {
            button1.Visible = false;
            lTest.Text = "Test has started...";
            var speed = await FastClient.GetDownloadSpeed();
            button1.Visible = true;
            lTest.Text = "Speed Result: " + String.Format("{0:0.##}", (speed.Speed / 100)) + " mbps";
            Console.WriteLine(speed);
        }   

        public Form1()
        {
            downData.Title = "Download";
            upData.Title = "Upload";
            downData.PointGeometry = DefaultGeometries.Circle;
            downData.PointGeometrySize = 10;
            upData.PointGeometry = DefaultGeometries.Diamond;
            upData.PointGeometrySize = 10;
            networkSeries.Add(downData);
            networkSeries.Add(upData);
            downData.Values = downs;
            upData.Values = ups;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 1050, 500, 20, 20));
            grey = System.Drawing.Color.Gray;
            white = System.Drawing.Color.FromArgb(110, 26, 248);
            bg = System.Drawing.Color.Black;
            InitializeComponent();
            cartesianChart1.Series = networkSeries;



            Panel[] elements ={ panel5, panel6, panel4, panel10, panel11, panel12, panel9 };

            foreach(Panel element in elements) {
                element.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, element.Width, element.Height, 20, 20));

            }
            

            int last = Properties.Settings.Default.LastSize;
            comboBox1.SelectedIndex = last;

            if(Properties.Settings.Default.openHeatCpu)
            {
                checkBox1.Checked = true;
            }
            if (Properties.Settings.Default.openHeatGpu)
            {
                checkBox2.Checked = true;
            }
            if (Properties.Settings.Default.openLoadCpu)
            {
                checkBox3.Checked = true;
            }
            if (Properties.Settings.Default.openLoadGpu)
            {
                checkBox4.Checked = true;
            }
            if (Properties.Settings.Default.openDown)
            {
                checkBox5.Checked = true;
            }
            if (Properties.Settings.Default.openPing)
            {
                checkBox6.Checked = true;
            }

           

            angularGauge1.Value = 100;
            angularGauge1.FromValue = 0;
            angularGauge1.ToValue = 100;
            angularGauge1.TicksForeground = Brushes.White;
            angularGauge1.Foreground = Brushes.White;
            angularGauge1.FontWeight = FontWeights.Bold;
            angularGauge1.FontSize = 15;
            angularGauge1.SectionsInnerRadius = 0.7;

            angularGauge2.Value = 100;
            angularGauge2.FromValue = 0;
            angularGauge2.ToValue = 100;
            angularGauge2.TicksForeground = Brushes.White;
            angularGauge2.Foreground = Brushes.White;
            angularGauge2.FontWeight = FontWeights.Bold;
            angularGauge2.FontSize = 15;
            angularGauge2.SectionsInnerRadius = 0.7;


           gauge3.Foreground = Brushes.White;
            gauge1.Foreground = Brushes.White;
            gauge2.Foreground = Brushes.White;






            gauge1.From = 0;
            gauge1.To = 100;
            gauge1.Value = 0;

            gauge2.From = 0;
            gauge2.To = 100;
            gauge2.Value = 0;

            gauge3.From = 0;
            gauge3.To = 100;
            gauge3.Value = 0;



            

           
        }

        public void cpuLoad(int i)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    gauge1.Value = i;
                //gw.setLoadCpu("LC: %" + i.ToString());
                Datalar.loadCpu = i.ToString();
                    if (barLoadCpu != null) { barLoadCpu.setVal(i.ToString()); }
                });
            }
            catch { }
        }

        public void currentDown(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
                lDown.Text = i.ToString() + "kb";
                Datalar.download = i.ToString();
                if (barDownload != null) { barDownload.setVal(i.ToString()); }
            });
            }
            catch { }

        }

        public void maxDown(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
            });
            }
            catch { }
        }

        public void currentUp(int i)
        {
            try {
            this.Invoke((MethodInvoker)delegate
            {
                lUp.Text = i.ToString() + "kb";
       
            });
            }
            catch { }
        }

        public void maxUp(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
            });
            }
            catch { }
        }

        public void gpuLoad(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
                gauge2.Value = i;
                //gw.setLoadGpu("LG: %" + i.ToString());
                Datalar.loadGpu = i.ToString();
                if (barLoadGpu != null) { barLoadGpu.setVal(i.ToString()); }
            });
            }
            catch { }
        }

        public void memLoad(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
                gauge3.Value = i;
            });
            }
            catch { }
        }

        public void mainCpu(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
                if (i > maxCpu)
                {
                    maxCpu = i;
                    labMaxCpu.Text = "M: " + i.ToString() + " ℃";
                }
                    
                angularGauge1.Value = i;
                labCurrentCpu.Text = "C: " + i.ToString() + " ℃";
                //gw.setCpu("C:"+ i.ToString());
                Datalar.heatCpu = i.ToString();
                if (barHeatCpu != null) { barHeatCpu.setVal(i.ToString()); }

            });
            }
            catch { }
        }

        public void mainGpu(int i)
        {
            try { 
            this.Invoke((MethodInvoker)delegate
            {
                if (i > maxGpu)
                {
                    maxGpu = i;
                    labMaxGpu.Text = "M: " + i.ToString() + " ℃";
                }
                angularGauge2.Value = i;
                labCurentGpu.Text = "C: " + i.ToString() + " ℃";
                //gw.setGpu("G:" + i.ToString());
                Datalar.heatGpu = i.ToString();
                if (barHeatGpu != null) { barHeatGpu.setVal(i.ToString()); }

            });
            }
            catch { }
        }

        public void clearCpu()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    listView1.Items.Clear();
                });
            }
            catch (Exception e) { }
            
        }

        public void addCpuItem(ListViewItem item)
        {
            try { 
            this.Invoke((MethodInvoker)delegate {
                listView1.Items.Add(item);
            });
            }
            catch { }
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

        

        

        private void label15_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.BringToFront();
            this.Show();
            this.Activate();
            this.Focus();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            lTitle.Text = "SYSTEM TEMPERATURE";
            panelBars.Visible = false;
            panelTemp.Visible = true;
            panelLoad.Visible = false;
            panelNetwork.Visible = false;
            degis(bHeat);
        }
        
        public bool isPanelNetwork()
        {
            return panelNetwork.Visible;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                barHeatGpu = new GameBar();
                barHeatGpu.setType(1);
                barHeatGpu.Show();
                barHeatGpu.changeSize(currentSize);
                bars.Add(barHeatGpu);
                Properties.Settings.Default.openHeatGpu = true;
            }
            else
            {
                if (barHeatGpu != null)
                {
                    barHeatGpu.Hide();
                    barHeatGpu.Close();
                    bars.Remove(barHeatGpu);
                    barHeatGpu = null;
                    Properties.Settings.Default.openHeatGpu = false;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                barLoadCpu = new GameBar();
                barLoadCpu.setType(2);
                barLoadCpu.changeSize(currentSize);
                barLoadCpu.Show();
                bars.Add(barLoadCpu);
                Properties.Settings.Default.openLoadCpu = true;
            }
            else
            {
                if (barLoadCpu != null)
                {
                    barLoadCpu.Hide();
                    barLoadCpu.Close();
                    bars.Remove(barLoadCpu);
                    barLoadCpu = null;
                    Properties.Settings.Default.openLoadCpu = false;
                }
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                barLoadGpu = new GameBar();
                barLoadGpu.setType(3);
                barLoadGpu.changeSize(currentSize);
                barLoadGpu.Show();
                bars.Add(barLoadGpu);
                Properties.Settings.Default.openLoadGpu = true;
            }
            else
            {
                if (barLoadGpu != null)
                {
                    barLoadGpu.Hide();
                    barLoadGpu.Close();
                    bars.Remove(barLoadGpu);
                    barLoadGpu = null;
                    Properties.Settings.Default.openLoadGpu = false;
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                barDownload = new GameBar();
                barDownload.setType(4);
                barDownload.changeSize(currentSize);
                barDownload.Show();
                bars.Add(barDownload);
                Properties.Settings.Default.openDown = true;
            }
            else
            {
                if (barDownload != null)
                {
                    barDownload.Hide();
                    barDownload.Close();
                    bars.Remove(barDownload);
                    barDownload = null;
                    Properties.Settings.Default.openDown = false;
                }
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                barPing = new GameBar();
                barPing.setType(5);
                barPing.changeSize(currentSize);
                barPing.Show();
                bars.Add(barPing);
                Properties.Settings.Default.openPing = true;
            }
            else
            {
                if (barPing != null)
                {
                    barPing.Hide();
                    barPing.Close();
                    bars.Remove(barPing);
                    barPing.shouldRun = false;
                    barPing = null;
                    Properties.Settings.Default.openPing = false;

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("calısti");
            GameBar.Sizes newsize = GameBar.Sizes.BIG;
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    newsize = GameBar.Sizes.BIG;
                    break;
                case 1:
                    newsize = GameBar.Sizes.MEDIUM;
                    break;
                case 2:
                    newsize = GameBar.Sizes.SMALL;
                    break;
                case 3:
                    newsize = GameBar.Sizes.NOTIFY;
                    break;
            }
            currentSize = newsize;
            Properties.Settings.Default.LastSize = comboBox1.SelectedIndex;
            Properties.Settings.Default.Save();
            foreach (GameBar b in bars)
            {
                b.changeSize(newsize);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            monitor.shouldRun = false;
            if (barHeatCpu != null)
            {
                Properties.Settings.Default.PosHeatCpu = barHeatCpu.Location;
            }

            if (barHeatGpu != null)
            {
                Properties.Settings.Default.PostHeatGpu = barHeatGpu.Location;
            }
            if (barLoadCpu != null)
            {
                Properties.Settings.Default.PosLoadCpu = barLoadCpu.Location;
            }
            if (barLoadGpu != null)
            {
                Properties.Settings.Default.PosLoadGpu = barLoadGpu.Location;
            }
            if (barDownload != null)
            {
                Properties.Settings.Default.PosDown = barDownload.Location;
            }
            if (barPing != null)
            {
                Properties.Settings.Default.PosPing = barPing.Location;
            }
   
            Properties.Settings.Default.Save();
            Console.WriteLine("saved");
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            monitor = new Monitor(this);
            network = new Network(this);
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            speedTestAsync();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            lTitle.Text = "HARDWARE LOADS";
            panelBars.Visible = false;
            panelTemp.Visible = false;
            panelLoad.Visible = true;
            panelNetwork.Visible = false;
            degis(bLoad);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {
            lTitle.Text = "INFO BARS";
            panelBars.Visible = true;
            panelTemp.Visible = false;
            panelLoad.Visible = false;
            panelNetwork.Visible = false;
            degis(bWindows);
        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox) sender;
            if(c.Checked)
            {
                barHeatCpu = new GameBar();
                barHeatCpu.setType(0);
                barHeatCpu.changeSize(currentSize);
                barHeatCpu.Show();
                bars.Add(barHeatCpu);
                Properties.Settings.Default.openHeatCpu = true;

            }
            else
            {
                if (barHeatCpu != null)
                {
                    barHeatCpu.Hide();
                    barHeatCpu.Close();
                    bars.Remove(barHeatCpu);
                    barHeatCpu = null;
                    Properties.Settings.Default.openHeatCpu = false;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            lTitle.Text = "NETWORK STATUS";
            panelBars.Visible = false;
            panelTemp.Visible = false;
            panelLoad.Visible = false;
            panelNetwork.Visible = true;
            
            degis(bNetwork);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            monitor.cth.Abort();
            monitor.shouldRun = false;
            network.shouldRun = false;
            try
            {
                monitor.ws.Stop();
            }
            catch { }
            notifyIcon1.Visible = false;
            foreach (GameBar bar in bars)
            {
                bar.kapat();
            }
            Application.Exit();
        }

        void degis(CircleButton lab)
        {
            bHeat.BackColor = bg;
            bLoad.BackColor = bg;
            bNetwork.BackColor = bg;
            bWindows.BackColor = bg;
            lab.BackColor = white;
        }
    }

    
}
