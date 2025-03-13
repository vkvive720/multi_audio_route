using NAudio.Wave;

namespace MultiDeviceAudioUI.AudioProcessing
{
    // A simple delay sample provider that delays audio output by buffering samples.
    public class DelaySampleProvider : ISampleProvider
    {
        private readonly ISampleProvider source;
        private readonly float[] delayBuffer;
        private int delayBufferSamples;
        private int readPos;
        private int writePos;

        public DelaySampleProvider(ISampleProvider source, int delayMilliseconds)
        {
            this.source = source;
            WaveFormat = source.WaveFormat;
            // Calculate delay in samples.
            delayBufferSamples = (int)(source.WaveFormat.SampleRate * (delayMilliseconds / 100.0) * source.WaveFormat.Channels);
            if (delayBufferSamples < 1) delayBufferSamples = 1;
            delayBuffer = new float[delayBufferSamples];
            readPos = 0;
            writePos = 0;
        }

        public WaveFormat WaveFormat { get; private set; }

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = source.Read(buffer, offset, count);
            for (int n = 0; n < samplesRead; n++)
            {
                // Write incoming sample into delay buffer.
                delayBuffer[writePos] = buffer[offset + n];
                writePos = (writePos + 1) % delayBufferSamples;
                // Output delayed sample.
                buffer[offset + n] = delayBuffer[readPos];
                readPos = (readPos + 1) % delayBufferSamples;
            }
            return samplesRead;
        }
    }
}