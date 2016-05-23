using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFormGenerator
{
    public interface IWaveGenerator
    {
        string generate(string maxSamples, string maxLevel, string multiply);
    }
}
