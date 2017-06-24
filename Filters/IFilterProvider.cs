using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSound.Filters
{
    interface IFilterProvider: ISampleProvider
    {
        IEnumerable<float> ReadTransformedSample();
    }
}
