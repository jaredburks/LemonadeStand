using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game
    {
        Player player;
        int dayCount = 0;
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        Store store;
        Inventory inventory = new Inventory();
        Day day = new Day();
        public void Rules()
        {
            Console.WriteLine("How to Play: ");
        }

        public void StartGame()
        {
            player = new Player();
            store = new Store(player);
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
