namespace MultiDeviceAudioUI.Models
{
    public class OutputDeviceSetting
    {
        public string DeviceName { get; set; }
        public int DeviceNumber { get; set; }
        public float Volume { get; set; }
        public int DelayMs { get; set; }
        // New property to allow enabling/disabling playback on this device.
        public bool IsEnabled { get; set; } = true;
    }
}