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
        int day;
        Weather weather;
        Recipe recipe;
        Store store;
        public void Rules()
        {
            Console.WriteLine("How to Play: ");
        }

        public void StartGame()
        {
            Rules();
            Console.WriteLine("Press any key to continue.\n");
            Console.ReadLine();
            Console.WriteLine("Start a new 7 day game. Press any key to continue.\n");
            Console.ReadLine();
            weather.Forecast();
            store.SellToPlayer();
            recipe.SupplyAmounts();
            //TODO:Start Day 1
        }

    }
}
