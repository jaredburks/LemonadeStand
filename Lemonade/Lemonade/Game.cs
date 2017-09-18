using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game
    {
        public Player player = new Player();
        int dayCount = 0;
        Weather weather = new Weather();
        Store store;
        Day day = new Day();
        public void Rules()
        {
            Console.WriteLine("How to Play: ");
        }

        public void StartGame()
        {
            store = new Store(player);
            // player.inventory.cups.Count;
            Rules();
            Console.WriteLine("Press any key to continue.\n");
            Console.ReadLine();
            Console.WriteLine("Start a new 7 day game. Press any key to continue.\n");
            Console.ReadLine();
            weather.Forecast();
            store.SellToPlayer();
            //TODO:Start Day 1
            day.DayShift();
        }

    }
}
