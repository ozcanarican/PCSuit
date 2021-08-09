namespace ISOSharp
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.labCpu = new System.Windows.Forms.Label();
            this.labGpu = new System.Windows.Forms.Label();
            this.labLoadCpu = new System.Windows.Forms.Label();
            this.labLoadGpu = new System.Windows.Forms.Label();
            this.labDown = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labCpu
            // 
            resources.ApplyResources(this.labCpu, "labCpu");
            this.labCpu.ForeColor = System.Drawing.Color.White;
            this.labCpu.Name = "labCpu";
            this.labCpu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labCpu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labCpu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // labGpu
            // 
            resources.ApplyResources(this.labGpu, "labGpu");
            this.labGpu.ForeColor = System.Drawing.Color.White;
            this.labGpu.Name = "labGpu";
            this.labGpu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labGpu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labGpu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // labLoadCpu
            // 
            resources.ApplyResources(this.labLoadCpu, "labLoadCpu");
            this.labLoadCpu.ForeColor = System.Drawing.Color.White;
            this.labLoadCpu.Name = "labLoadCpu";
            this.labLoadCpu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labLoadCpu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labLoadCpu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // labLoadGpu
            // 
            resources.ApplyResources(this.labLoadGpu, "labLoadGpu");
            this.labLoadGpu.ForeColor = System.Drawing.Color.White;
            this.labLoadGpu.Name = "labLoadGpu";
            this.labLoadGpu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labLoadGpu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labLoadGpu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // labDown
            // 
            resources.ApplyResources(this.labDown, "labDown");
            this.labDown.ForeColor = System.Drawing.Color.White;
            this.labDown.Name = "labDown";
            this.labDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.labDown.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.labDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // GameWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.labDown);
            this.Controls.Add(this.labLoadGpu);
            this.Controls.Add(this.labLoadCpu);
            this.Controls.Add(this.labGpu);
            this.Controls.Add(this.labCpu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameWindow";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCpu;
        private System.Windows.Forms.Label labGpu;
        private System.Windows.Forms.Label labLoadCpu;
        private System.Windows.Forms.Label labLoadGpu;
        private System.Windows.Forms.Label labDown;
    }
}