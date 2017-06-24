using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio;
using NAudio.Wave;

namespace DSound.Filters
{
    public class LowPassFilter : IFilterProvider
    {
        private ISampleProvider _sourceProvider;
        private int _threshold;

        public LowPassFilter(ISampleProvider source, int threshold)
        {
            _sourceProvider = source;
            _threshold = threshold;
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
            int actualindex = 0;
            float[] actualSample = new float[1];
            float[] previousSample = new float[1];
            _sourceProvider.Read(actualSample, actualindex, 1);
            yield return actualSample[0];
            double timeBetweenSamples = 1.0 / WaveFormat.SampleRate;
            float alphaMultiplier = (float)(timeBetweenSamples / (timeBetweenSamples + (Convert.ToDouble(_threshold))));
            //_sourceProvider.WaveFormat.
            yield return 0;
        }
    }
}
