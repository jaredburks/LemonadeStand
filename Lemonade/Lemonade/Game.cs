using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Game
    {
        Player player = new Player();
        public void Rules()
        {
            Console.WriteLine("How to Play: ");
        }

        public void StartGame()
        {
            Console.WriteLine("Start a new 7 day game. Press any key to continue.");
            Console.ReadLine();
            //TODO:Start Day 1
        }

    }
}
