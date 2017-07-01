using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Dsp;

namespace DSound.Filters
{
    public class Filter : ISampleProvider
    {
        private readonly ISampleProvider _sourceProvider;
        private readonly List<BiQuadFilter[]> _filters;

        public Filter(ISampleProvider source, List<BiQuadFilter[]> filters)
        {
            _sourceProvider = source;
            _filters = filters;
        }

        public WaveFormat WaveFormat => _sourceProvider.WaveFormat;

        public int Read(float[] buffer, int offset, int count)
        {
            int samplesRead = _sourceProvider.Read(buffer, offset, count);
            foreach (var filter in _filters)
            {
                for (int i = 0; i < samplesRead; i++)
                    buffer[offset + i] = filter[(i % _sourceProvider.WaveFormat.Channels)].Transform(buffer[offset + i]);
            }

            return samplesRead;
        }

        public static BiQuadFilter[] CreateFiltersTable(BiQuadFilter filter, int channels)
        {
            BiQuadFilter[] f = new BiQuadFilter[channels];
            for (var i = 0; i < channels; i++)
            {
                f[i] = filter;
            }
            return f;
        }
    }
}
