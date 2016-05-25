using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFormGenerator
{
    class WaveFactory
    {
        string _waveForm { get; set; }
        public WaveFactory(string waveform)
        {
            _waveForm = waveform;
        }
        public IWaveGenerator CreateWave()
        {
            switch(_waveForm.ToLower())
            {
                case "square":
                    return new SquareWave();

                case "sine":
                    return new SineWave();

                default:
                    return new NoiseWave();
            }
        }
    }
}
