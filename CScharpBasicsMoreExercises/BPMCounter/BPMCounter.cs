using System;

namespace BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            double bpm = double.Parse(Console.ReadLine());
            double numberBeats = double.Parse(Console.ReadLine());

            double bars = numberBeats / 4;
            double seconds = numberBeats * 60 / bpm;
            int minutes = (int)seconds / 60;
            seconds -= minutes * 60;

            Console.WriteLine($"{Math.Round(bars,1)} bars - {minutes}m {Math.Floor(seconds)}s");
        }
    }
}
