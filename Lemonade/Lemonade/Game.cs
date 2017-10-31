using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game
    {
        public Day day = new Day();
        public Weather weather = new Weather();
        public Player player;
        Store store;
        int dayCount;
        string prediction;
        double cashBeforeShift;
        double dayProfit;
        double totalProfit;
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
            Console.WriteLine("Enter your name:");
            player = new Player();
            store = new Store(player);
            Rules();
            Console.WriteLine("Press any key to start a new 7 day game.\n");
            Console.ReadLine();
            PlayGame();
            GetTotalProfit();
            PlayAgain();
            //TODO:Link to database to save results(Name, profit)
        }
        public void PlayGame()
        {
            dayCount = 0;
            while (dayCount < 7)
            {
                prediction = weather.Forecast();
                store.SellToPlayer();
                //Start Day 1
                Console.WriteLine(prediction);
                cashBeforeShift = player.wallet;
                day.DayShift(player);
                dayProfit = player.wallet - cashBeforeShift;
                totalProfit += dayProfit;
                GetDayProfit();
                dayCount++;
            }
        }
        public void GetDayProfit()
        {
            Console.WriteLine("Day's Profit: $" + dayProfit + "\n");
        }
        public void GetTotalProfit()
        {
            Console.WriteLine("Total Profit: $" + totalProfit + "\n");
        }
        public void PlayAgain()
        {
            Console.WriteLine("Would you like to play again? Enter 'y' for yes, 'n' for no.");
            string option;
            switch (option = Console.ReadLine())
            {
                case "y":
                    StartGame();
                    break;
                case "n":
                    break;
                default:
                    Console.WriteLine("Please Enter 'y' to start new game or 'n' to quit game\n");
                    PlayAgain();
                    break;
            }
        }
    }
}
