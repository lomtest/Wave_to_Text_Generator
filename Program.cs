using System;
using System.IO;

namespace WaveFormGenerator
{
    class Program
    {
        static string waveform;
        static WaveFactory waveFactory;
        static StreamWriter sw;
        static void Main(string[] args)
        {
            
            Write("WaveForm to Textfile Generator \n------------------------------");
            Color("yellow");
            Write("Select \nwaveform: \nSine \nSquare \nDefault is random numbers");
            Color("cyan");
            waveform = Console.ReadLine();

            Color("green");
            Write("Numbers of samples:");
            Color("cyan");
            var numbersSamples = Console.ReadLine();

            Write("------------------------------");
            Color("red");
            Write("Top value:");
            Color("cyan");
            var topValue = Console.ReadLine();

            Write("------------------------------");
            Write("Frequency Integer Multiply(1, 2, 3... etc) select 1 for single wave cycle");
            var multiply = Console.ReadLine();
            sw = new StreamWriter(waveform + "Table.txt");
            waveFactory = new WaveFactory(waveform);
            var a = waveFactory.CreateWave();
            sw.Write(a.generate(numbersSamples, topValue, multiply));
            sw.Close();
            Color("white");
            Write("Your " + waveform + "waveform is ready to use (in " + waveform + "Table.txt)");
            Console.ReadKey();

        }

        static void Write(string line)
        {
            Console.WriteLine(line);
        }

        static void Color(string color)
        {
            switch (color.ToLower())
            {
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
        }
    }
}
