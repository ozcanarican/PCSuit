using LiveCharts;
using LiveCharts.Wpf;
using OpenHardwareMonitor.Hardware;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOSharp
{
    class Monitor
    {
        public WebServer ws;
        Computer thisComputer;
        double tempCpu = 0;
        public bool shouldRun = true;
        Form1 form;
        public Thread cth;
       


        int tcpu, tgpu, lcpu, lgpu, lmem = 0;

        public Monitor(Form1 form)
        {
            this.form = form;
            thisComputer = new Computer() { CPUEnabled = true, GPUEnabled = true, RAMEnabled=true };
            thisComputer.Open();
            Console.WriteLine(thisComputer.Hardware);
            cth = new Thread(new ThreadStart(GetCpu));
            cth.Start();
            

            ws = new WebServer(SendResponse, "http://*:8082/");
            ws.Run();


        }

        void GetCpu()
        {
            while (shouldRun)
            {
                String temp = "";
                form.clearCpu();
                foreach (var hardwareItem in thisComputer.Hardware)
                {
                    //CPU
                    if (hardwareItem.HardwareType == HardwareType.CPU)
                    {
                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                            subHardware.Update();

                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature)
                            {

                                try
                                {
                                    string[] row = { sensor.Name, sensor.Value.Value.ToString() };
                                    var listViewItem = new ListViewItem(row);
                                    form.addCpuItem(listViewItem);
                                    if (sensor.Name.Contains("Package"))
                                    {
                                        form.mainCpu(int.Parse(sensor.Value.Value.ToString()));
                                        tcpu = int.Parse(sensor.Value.Value.ToString());
                                    }
                                }
                                catch (Exception e) { }
                               
                            }
                            else if (sensor.SensorType == SensorType.Load)
                            {
                                if (sensor.Name.Contains("Total"))
                                {
                                    try
                                    {
                                        form.cpuLoad((int)sensor.Value.Value);
                                        lcpu = (int)sensor.Value.Value;
                                    }
                                    catch (Exception e) { }
                                }
                            }
                        }
                    }
                   else if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                    {
                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                            subHardware.Update();

                        foreach (var sensor in hardwareItem.Sensors)
                        {
                            if (sensor.SensorType == SensorType.Temperature)
                            {
                                form.mainGpu(int.Parse(sensor.Value.Value.ToString()));
                                tgpu = int.Parse(sensor.Value.Value.ToString());
                            }
                            else if (sensor.SensorType == SensorType.Load)
                            {

                                if (sensor.Name.Contains("Core"))
                                {
                                    try
                                    {
                                        form.gpuLoad((int)sensor.Value.Value);
                                        lgpu = (int)sensor.Value.Value;
                                    }
                                    catch (Exception e) { }
                                }
                            }
                        }
                    }
                    else if (hardwareItem.HardwareType == HardwareType.RAM)
                    {
                        hardwareItem.Update();
                        foreach (IHardware subHardware in hardwareItem.SubHardware)
                            subHardware.Update();

                        foreach (var sensor in hardwareItem.Sensors)
                        {
                           if (sensor.SensorType == SensorType.Load)
                            {
                                
                                    try
                                    {
                                        form.memLoad((int)sensor.Value.Value);
                                        lmem = (int)sensor.Value.Value;
                                }
                                    catch (Exception e) { }
                                
                            }
                        }
                    }
                    Thread.Sleep(Helper.WaitSecond * 1000);
                }
            }
           
        }

        public string SendResponse(HttpListenerRequest request)
        {
            return "<html>  <head>    <title>WEB MONITOR</title>    <meta http-equiv='refresh' content='2'/>    " +
                "<style>h2{color:white;}body {background:#000000; color: Green; font-size: 2em;}</style>  </head>  <body>    <div class='main'><h2>PCSUIT WEB MONITOR</h2><ul>      " +
                "<li>CPU TEMP: "+ tcpu+ "</li>      " +
                "<li>GPU TEMP: " + tgpu + "</li>      " +
                "<li>MAX CPU: " + form.maxCpu.ToString() + "</li>      " +
                "<li>MAX GPU: " + form.maxGpu.ToString() + "</li>      " +
                "<li>CPU LOAD: %" + lcpu + "</li>      " +
                "<li>GPU LOAD: %" + lgpu + "</li>      " +
                "<li>MEM LOAD: %" + lmem + "</li>        " +
                "</ul>    </div>  </body></html>";
            /*return string.Format(
                "<html>  <head>    <title>ISO WEB MONITOR</title>    <meta http-equiv='refresh' content='2'/>    <style>body {font-size: 2em;}</style>  </head>  <body>    <div class='main'><h2>ISO WEB</h2><ul>      <li>CPU TEMP: {0}</li>      <li>GPU TEMP: {1}</li>      <li>MAX CPU: {2}</li>      <li>MAX GPU: {3}</li>      <li>CPU LOAD: {4}</li>      <li>GPU LOAD: {5}</li>      <li>MEM LOAD: {6}</li>        </ul>    </div>  </body></html>", 
                tcpu, tgpu, tcpu, tgpu, tcpu, tgpu, tcpu, tgpu);*/
        }

    }
    
}
