using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISOSharp
{
    class CircleButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            try
            {
                GraphicsPath path = new GraphicsPath();
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new System.Drawing.Region(path);
            }
            catch (Exception e) {
                System.Diagnostics.Debug.WriteLine("Button error");
            }
        }
    }
}
