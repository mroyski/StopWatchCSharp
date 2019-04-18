using System;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = new StopWatch();

            Console.WriteLine("Enter 1 to start");
            Console.WriteLine("Enter 2 to stop");
            Console.WriteLine("Enter 3 to quit");
            Console.WriteLine("****************");
            bool GameTime = true;
            while (GameTime)
            {
                var input = Console.ReadLine();
                if (input == "1")
                {
                    watch.Start();
                }
                else if (input == "2")
                {
                    watch.Stop();
                }
                else if (input == "3")
                {
                    GameTime = false;
                }
            }
        }
    }
}
