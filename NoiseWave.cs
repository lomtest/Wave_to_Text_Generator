using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFormGenerator
{
    class NoiseWave : IWaveGenerator
    {
        string returnWave { get; set; }
        public string generate(string maxSamples, string maxLevel, string multiply)
        {
            Random rnd = new Random();
            var _maxLevel = int.Parse(maxLevel);
            var _lowestLevel = 0 - _maxLevel;
            var _maxSamples = int.Parse(maxSamples);
            for (int i = 0; i < _maxSamples; i++)
            {
                returnWave += rnd.Next(_lowestLevel, _maxLevel).ToString();
                returnWave += ",\n";
            }
            returnWave = returnWave.Replace("\n", System.Environment.NewLine);
            return returnWave;
        }
    }
}
