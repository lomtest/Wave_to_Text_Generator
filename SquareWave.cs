using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFormGenerator
{
    class SquareWave : IWaveGenerator
    {
        string returnWave { get; set; }
        public string generate(string maxSamples, string maxLevel, string multiply)
        {
            var _maxSamples = Int32.Parse(maxSamples);
            var _maxLevel = Int32.Parse(maxLevel);
            var _half = _maxSamples / 2;
            for (double i = 0; i < _maxSamples; i += 1)
            {
                if (i < _half)
                {
                    returnWave += _maxLevel;
                    returnWave += ",\n";
                }
                else
                {
                    returnWave += 0 - _maxLevel;
                    returnWave += ",\n";
                }
                
            }
            returnWave = returnWave.Replace("\n", System.Environment.NewLine);
            return returnWave;
        }
    }
}
