using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveFormGenerator
{
    class Program
    {
        static string waveform;
        static WaveFactory waveFactory;
        static StreamWriter sw;
        static void Main(string[] args)
        {
            
            Console.WriteLine("WaveForm to Textfile Generator");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select waveform: ");
            Console.WriteLine("Sine");
            Console.WriteLine("Square");
            Console.ForegroundColor = ConsoleColor.Cyan;
            waveform = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Numbers of samples:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var numbersSamples = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Top value:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            var topValue = Console.ReadLine();
            Console.WriteLine("------------------------------");
            Console.WriteLine("Frequency Integer Multiply(1, 2, 3... etc) select 1 for single wave cycle");
            var multiply = Console.ReadLine();
            sw = new StreamWriter(waveform + "Table.txt");
            waveFactory = new WaveFactory(waveform);
            var a = waveFactory.CreateWave();
            sw.Write(a.generate(numbersSamples, topValue, multiply));
            sw.Close();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Your waveform is ready to use");
            Console.ReadKey();

        }
    }
}
