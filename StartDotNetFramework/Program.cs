using System;

namespace StartDotNetFramework
{
    // ReSharper disable once ClassNeverInstantiated.Global
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Project started for first time");
            var stop = false;
            while (!stop)
            {
                try
                {
                    var result = YourCode.WriteHere();
                    Console.WriteLine("Result:");
                    Console.WriteLine(result + Environment.NewLine);
                }
                catch
                {
                    continue;
                }

                Console.WriteLine("Press any key to restart project or Space to exit.");
                var key = Console.ReadKey().Key;
                stop = key == ConsoleKey.Spacebar;
            }

            Console.WriteLine(Environment.NewLine + "Project stopped");
        }
    }
}