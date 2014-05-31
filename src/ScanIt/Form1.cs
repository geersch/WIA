using System;
using System.IO;
using System.Windows.Forms;
using WIA;

namespace ScanIt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ListDevices_Click(object sender, EventArgs e)
        {
            // Clear the ListBox.
            Devices.Items.Clear();

            // Create a DeviceManager instance
            var deviceManager = new DeviceManager();

            // Loop through the list of devices and add the name to the listbox
            for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
            {
                //Add the device to the list if it is a scanner
                if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                {
                    return;
                }

                Devices.Items.Add(new Scanner(deviceManager.DeviceInfos[i]));
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            // Scanner selected?
            var device = Devices.SelectedItem as Scanner;
            if (device == null)
            {
                MessageBox.Show("Please select a device.", "Warning",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Scan
            var image = device.Scan();

            // Save the image
            var path = @"c:\scan.jpeg";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            image.SaveFile(path);
        }
    }
}
