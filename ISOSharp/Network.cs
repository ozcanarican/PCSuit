using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOSharp
{
    class Network
    {
        int topCurrentDown, topCurrentUp, tempDown, tempUp, download, upload = 0;
        int maxDown, maxUp = 10;
        Form1 form;
        public bool shouldRun = true;
        public Network(Form1 form)
        {
            this.form = form;
            Thread th = new Thread(new ThreadStart(usage));
            th.Start();
        }
        void usage()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return;

            NetworkInterface[] interfaces
                = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface ni in interfaces)
            {
                topCurrentUp += (int)(ni.GetIPv4Statistics().BytesSent / 1024);
                topCurrentDown += (int)(ni.GetIPv4Statistics().BytesReceived / 1024);
            }
            tempUp = topCurrentUp;
            tempDown = topCurrentDown;

            while (shouldRun)
            {
                topCurrentDown = 0;
                topCurrentUp = 0;
                foreach (NetworkInterface ni in interfaces)
                {
                    topCurrentUp += (int)(ni.GetIPv4Statistics().BytesSent / 1024 /3);
                    topCurrentDown += (int)(ni.GetIPv4Statistics().BytesReceived / 1024 / 3);
                }
                download = topCurrentDown - tempDown;
                tempDown = topCurrentDown;
                upload = topCurrentUp- tempUp;
                tempUp = topCurrentUp;
                if(download > maxDown)
                {
                    maxDown = download;
                    form.maxDown(maxDown);
                }
                if (upload > maxUp)
                {
                    maxUp = upload;
                    form.maxUp(maxUp);
                }
           
                if (download < 0) download = 0;
                if (upload < 0) upload = 0;

                try
                {
                    form.Invoke((MethodInvoker)delegate
                    {
                        if (form.Visible && form.isPanelNetwork())
                        {

                        }
                        form.downs.Add(download);
                        form.ups.Add(upload);
                        if (form.downs.Count > 20)
                        {
                            form.downs.RemoveAt(0);
                            form.ups.RemoveAt(0);
                        }
                        form.currentDown(download);
                        form.currentUp(upload);
                        

                    });

                    
                 }
                catch { }

              

               

                Thread.Sleep(3000);
            }
        }
    }

}
