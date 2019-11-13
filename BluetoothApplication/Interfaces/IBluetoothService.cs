using System;
using System.Threading.Tasks;

namespace BluetoothApplication.Interfaces
{
    public delegate void DataUpdatedEventHandler(object sender, EventArgs e);
    public delegate void DeviceConnectionStatusChangedEventHandler(object sender, EventArgs e);
    public delegate void DeviceScanningStatusChangedEventHandler(object sender, EventArgs e);
    public delegate void TemperatureScaleChangedEventHandler(object sender, EventArgs e);

    public interface IBluetoothService
    {
        event DataUpdatedEventHandler DataUpdated;
        event DeviceConnectionStatusChangedEventHandler DeviceConnectionStatusChanged;
        event DeviceScanningStatusChangedEventHandler DeviceScanningStatusChanged;
        event TemperatureScaleChangedEventHandler TemperatureScaleChanged;

        string DeviceName { get; set; }
        bool DeviceConnected { get; set; }
        bool ScanningForDevice { get; set; }


        Task StartScanningForDevices();
        Task StopScanningForDevices();

        Task Connect();
        Task Disconnect();

        Task StartSendingUpdates();
        Task StopSendingUpdates();


        //TemperatureMeasurementUnits TemperatureScale { get; set; }
        //Task ReadValueAsync();
        //Task Dispose();

    }
}
