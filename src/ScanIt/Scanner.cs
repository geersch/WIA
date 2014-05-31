using WIA;

namespace ScanIt
{
    public class Scanner
    {
        private readonly DeviceInfo _deviceInfo;

        public Scanner(DeviceInfo deviceInfo)
        {
            this._deviceInfo = deviceInfo;
        }

        public ImageFile Scan()
        {
            // Connect to the device
            var device = this._deviceInfo.Connect();

            // Start the scan
            var item = device.Items[1];
            var imageFile = (ImageFile) item.Transfer(FormatID.wiaFormatJPEG);

            // Return the imageFile
            return imageFile;
        }

        public override string ToString()
        {
            return this._deviceInfo.Properties["Name"].get_Value().ToString();
        }
    }
}