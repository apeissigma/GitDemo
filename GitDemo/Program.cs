using System;
using static System.Console;

namespace GitDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello version control :)");

            Game myGame = new Game();
            myGame.Run();
        }
    }
}
