using System;

namespace StartDotNetFramework
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Project started for first time");
            var stop = false;
            while (!stop)
            {
                Console.WriteLine(YourCode.WriteHere());
                Console.WriteLine("Press any key to restart project or ESC to exit.");
                var key = Console.ReadKey().Key;
                stop = key == ConsoleKey.Escape;
            }
            Console.WriteLine("Project stopped");
        }
    }
}