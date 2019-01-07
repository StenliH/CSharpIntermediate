using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;
        private bool _isOn;

        public void Start()
        {
            if (_isOn == false)
            {
                _isOn = true;
                Console.WriteLine("start\n");
                _startTime = DateTime.Now;
            }
            else
                throw new InvalidOperationException("Stopky již jsou spuštěny.");
        }

        public void Stop()
        {
            if (_isOn == true)
            {
                _stopTime = DateTime.Now;
                Console.WriteLine("stop\n");
                _isOn = false;
            }
            else
                Console.WriteLine("Nejsou spuštěny stopky.");
        }

        public void ShowTime()
        {
            Console.WriteLine("Výsledný čas: " + (_stopTime - _startTime).ToString(@"hh\:mm\:ss\:fff"));
        }

        public static void Demo()
        {
            while (true)
            {
                var stopwatch = new Stopwatch();

                Console.WriteLine("Stiskni Enter pro zapnutí stopek...");
                Console.ReadLine();
                stopwatch.Start();
                Console.ReadLine();
                stopwatch.Stop();
                stopwatch.ShowTime();
                Console.WriteLine("\nType \"exit\" or press Enter to go again.");
                if (Console.ReadLine() == "exit")
                    break;
                Console.Clear();
            }
        }
    }
}
