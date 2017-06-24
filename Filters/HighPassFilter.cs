using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSound.Filters
{
    public class HighPassFilter : IFilterProvider
    {
        private readonly ISampleProvider _sourceProvider;
        private readonly int _threshold;
        private readonly long _fileLength;

        public HighPassFilter(ISampleProvider source, int threshold, long numberOfSamples)
        {
            _sourceProvider = source;
            _threshold = threshold;
            _fileLength = numberOfSamples;
        }

        public WaveFormat WaveFormat => _sourceProvider.WaveFormat;

        public int Read(float[] buffer, int offset, int count)
        {
            return 0;
        }

        /// <summary>
        /// Yields a new int after transformation
        /// </summary>
        /// <returns>Returns enumeration of generator</returns>
        public IEnumerable<float> ReadTransformedSample()
        {
            float[] buffer = new float[1];
            _sourceProvider.Read(buffer, 0, 1);
            float actualSample = buffer[0];
            float previousSample = buffer[0];
            float previousBareSample = buffer[0];
            yield return actualSample;

            double timeBetweenSamples = 1.0 / WaveFormat.SampleRate;
            float alphaMultiplier = (float)(timeBetweenSamples / (timeBetweenSamples + (Convert.ToDouble(_threshold))));
            for (int currentSample = 1; currentSample < _fileLength; currentSample++)
            {
                _sourceProvider.Read(buffer, currentSample, 1);
                actualSample = alphaMultiplier * (previousSample + buffer[0] - previousBareSample);
                previousSample = actualSample;
                previousBareSample = buffer[0];
                yield return actualSample;
            }
        }
    }
}
