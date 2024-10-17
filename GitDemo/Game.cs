using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GitDemo
{
    internal class Game
    {

        public void Run()
        {
            WriteLine("Welcome to the game");

            Write("\nEnter your name: ");
            string name = ReadLine();
            Player currentPlayer = new Player(name);

            WriteLine($"\nLet's get started {currentPlayer.Name}!");

            WriteLine("\nPress any key to exit...");
            ReadKey(true);
        }
    }
}
