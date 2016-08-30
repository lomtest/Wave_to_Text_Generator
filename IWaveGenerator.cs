using System;

namespace WaveFormGenerator
{
    public interface IWaveGenerator
    {
        string generate(string maxSamples, string maxLevel, string multiply);
    }
}
