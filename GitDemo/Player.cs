using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GitDemo
{
    internal class Player
    {
        public string Name { get; private set; }

        public Player(string name)
        {
            Name = name;
        }
    }
}
