using System;

namespace WaveFormGenerator
{
    class SineWave : IWaveGenerator
    {
        string returnWave { get; set; }
        public string generate(string maxSamples, string maxLevel, string multiply)
        {
            var _maxSamples = Int32.Parse(maxSamples);
            var _maxLevel = double.Parse(maxLevel);
            var _multiply = double.Parse(multiply);
            double yValue;
            int yValueInt;
            var steps = 1.0 / _maxSamples;
            steps /= _multiply;
            for (int f = 0; f < _multiply; f++)
            {
                for (double i = 0; i < 1.0; i += steps )
                {
                    yValue = Math.Sin(i * 2 * Math.PI);
                    yValueInt = Convert.ToInt16(yValue * _maxLevel);
                    returnWave += yValueInt.ToString();
                    returnWave += ",\n";
                }
            }
            
            returnWave = returnWave.Replace("\n", System.Environment.NewLine);
            return returnWave;
        }
    }
}
