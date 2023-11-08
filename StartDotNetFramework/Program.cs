﻿using System;

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
                try
                {
                    Console.WriteLine(YourCode.WriteHere());
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