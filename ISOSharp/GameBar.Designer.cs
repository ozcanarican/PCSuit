namespace ISOSharp
{
    partial class GameBar
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
            this.components = new System.ComponentModel.Container();
            this.tTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tTitle
            // 
            this.tTitle.BackColor = System.Drawing.Color.Black;
            this.tTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.tTitle.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTitle.ForeColor = System.Drawing.Color.White;
            this.tTitle.Location = new System.Drawing.Point(0, 0);
            this.tTitle.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.tTitle.Name = "tTitle";
            this.tTitle.Padding = new System.Windows.Forms.Padding(5);
            this.tTitle.Size = new System.Drawing.Size(120, 22);
            this.tTitle.TabIndex = 10;
            this.tTitle.Text = "label2";
            this.tTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.tTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.label1.Size = new System.Drawing.Size(120, 120);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "sadsd";
            this.notifyIcon1.BalloonTipTitle = "aaaaaaaa";
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // GameBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(120, 120);
            this.Controls.Add(this.tTitle);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameBar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GameBar";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameBar_FormClosing);
            this.Shown += new System.EventHandler(this.GameBar_Shown);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label tTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}