using System.Collections.ObjectModel;
using System.Windows;
using NAudio.Wave;
using NAudio.CoreAudioApi;
using MultiDeviceAudioUI.Models;
using MultiDeviceAudioUI.AudioProcessing;
using System.Collections.Generic;
using System.Linq;

namespace MultiDeviceAudioUI
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<OutputDeviceSetting> OutputDevices { get; set; }
        private IWaveIn capture;
        private List<DeviceAudioPipeline> pipelines = new List<DeviceAudioPipeline>();

        public MainWindow()
        {
            InitializeComponent();
            OutputDevices = new ObservableCollection<OutputDeviceSetting>();
            // Enumerate output devices.
            for (int i = 0; i < WaveOut.DeviceCount; i++)
            {
                var cap = WaveOut.GetCapabilities(i);
                OutputDevices.Add(new OutputDeviceSetting
                {
                    DeviceName = cap.ProductName,
                    DeviceNumber = i,
                    Volume = 1.0f,
                    DelayMs = 0,
                    IsEnabled = true // default enabled
                });
            }
            DataContext = this;
        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            // Create capture instance (system loopback capture).
            capture = new WasapiLoopbackCapture();
            capture.DataAvailable += Capture_DataAvailable;
            capture.StartRecording();

            // Create an audio pipeline only for the enabled output devices.
            foreach (var setting in OutputDevices.Where(d => d.IsEnabled))
            {
                var pipeline = new DeviceAudioPipeline(setting, capture.WaveFormat);
                pipelines.Add(pipeline);
                pipeline.Start();
            }
        }

        private void Capture_DataAvailable(object sender, WaveInEventArgs e)
        {
            // Feed captured audio to all device pipelines.
            foreach (var pipeline in pipelines)
            {
                pipeline.AddSamples(e.Buffer, 0, e.BytesRecorded);
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            capture.StopRecording();
            capture.Dispose();
            foreach (var pipeline in pipelines)
            {
                pipeline.Stop();
                pipeline.Dispose();
            }
            pipelines.Clear();
        }
    }
}