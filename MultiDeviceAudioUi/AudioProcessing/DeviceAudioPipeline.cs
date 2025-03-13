using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using MultiDeviceAudioUI.Models;

namespace MultiDeviceAudioUI.AudioProcessing
{
    // This class manages the audio pipeline for one output device.
    public class DeviceAudioPipeline
    {
        private OutputDeviceSetting setting;
        private BufferedWaveProvider bufferedProvider;
        private IWavePlayer waveOut;
        // Chain sample providers: Buffered -> Delay -> Volume.
        private ISampleProvider sampleProvider;
        private VolumeSampleProvider volumeProvider;
        private DelaySampleProvider delayProvider;

        public DeviceAudioPipeline(OutputDeviceSetting setting, WaveFormat format)
        {
            this.setting = setting;
            bufferedProvider = new BufferedWaveProvider(format)
            {
                BufferLength = format.AverageBytesPerSecond * 1,
                // Set to false so we can handle overflow manually.
                DiscardOnBufferOverflow = false
            };

            // Convert buffered provider to sample provider.
            sampleProvider = bufferedProvider.ToSampleProvider();
            // Apply delay effect.
            delayProvider = new DelaySampleProvider(sampleProvider, setting.DelayMs);
            // Apply volume control.
            volumeProvider = new VolumeSampleProvider(delayProvider) { Volume = setting.Volume };

            // Convert back to wave provider for playback.
            var finalProvider = volumeProvider.ToWaveProvider16();
            waveOut = new WaveOutEvent { DeviceNumber = setting.DeviceNumber };
            waveOut.Init(finalProvider);
        }

        public void Start() => waveOut.Play();

        public void Stop() => waveOut.Stop();

        // Updated AddSamples: if adding new samples would overflow, flush the buffer first.
        public void AddSamples(byte[] buffer, int offset, int count)
        {
            if (bufferedProvider.BufferedBytes + count > bufferedProvider.BufferLength)
            {
                // Flush the buffer if full.
                bufferedProvider.ClearBuffer();
            }
            bufferedProvider.AddSamples(buffer, offset, count);
        }

        public void Dispose()
        {
            waveOut.Dispose();
        }
    }
}