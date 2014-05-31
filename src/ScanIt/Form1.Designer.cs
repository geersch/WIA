namespace ScanIt
{
    partial class Form1
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
            this.Devices = new System.Windows.Forms.ListBox();
            this.ListDevices = new System.Windows.Forms.Button();
            this.Scan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Devices
            // 
            this.Devices.FormattingEnabled = true;
            this.Devices.Location = new System.Drawing.Point(12, 12);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(199, 251);
            this.Devices.TabIndex = 0;
            // 
            // ListDevices
            // 
            this.ListDevices.Location = new System.Drawing.Point(217, 12);
            this.ListDevices.Name = "ListDevices";
            this.ListDevices.Size = new System.Drawing.Size(101, 23);
            this.ListDevices.TabIndex = 1;
            this.ListDevices.Text = "List Devices";
            this.ListDevices.UseVisualStyleBackColor = true;
            this.ListDevices.Click += new System.EventHandler(this.ListDevices_Click);
            // 
            // Scan
            // 
            this.Scan.Location = new System.Drawing.Point(217, 41);
            this.Scan.Name = "Scan";
            this.Scan.Size = new System.Drawing.Size(101, 23);
            this.Scan.TabIndex = 2;
            this.Scan.Text = "Scan";
            this.Scan.UseVisualStyleBackColor = true;
            this.Scan.Click += new System.EventHandler(this.Scan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 278);
            this.Controls.Add(this.Scan);
            this.Controls.Add(this.ListDevices);
            this.Controls.Add(this.Devices);
            this.Name = "Form1";
            this.Text = "ScantIt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Devices;
        private System.Windows.Forms.Button ListDevices;
        private System.Windows.Forms.Button Scan;
    }
}

