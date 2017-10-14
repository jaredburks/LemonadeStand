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
        public Day day = new Day();
        public Weather weather = new Weather();
        Store store;
        int dayCount = 0;
        public void Rules()
        {
            Console.WriteLine("How to Play:\nYour goal is to make as much money as you can in 7 days by selling lemonade at your lemonade stand.");
            Console.WriteLine("Buy cups, lemons, sugar, and ice cubes, then set your recipe based on the weather and conditions.");
            Console.WriteLine("Start with the basic recipe, but try to vary the recipe and see if you can do better.");
            Console.WriteLine("Lastly, set your price and sell your lemonade at the stand. Try changing up the price based on the weather conditions as well.");
            Console.WriteLine("At the end of the game, you'll see how much money you made. Play again to try and beat your score!\n");
        }
        public void StartGame()
        {
            store = new Store(player);
            Rules();
            Console.WriteLine("Press any key to continue.\n");
            Console.ReadLine();
            Console.WriteLine("Start a new 7 day game. Press any key to continue.\n");
            Console.ReadLine();
            //Need to loop thru 7 days
            string prediction = weather.Forecast();
            store.SellToPlayer();
            //TODO:Start Day 1
            Console.WriteLine(prediction);
            day.DayShift(player);
            //TODO:Show profit from day.
            //TODO:Next day(for 7 days)
            //TODO:Show total profit
            //TODO:Link to database to save results(Name, profit)
        }
    }
}
