using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class is for making the recipe for lemonade.
//Parent class of ice, sugar, lemon
//TODO:
//adjust amount of lemons, sugar, and ice in lemonade
//price for each item would adjust player's cash
//set a price per cup for customers
namespace Lemonade
{
    class Store
    {
        Player player;
        string option = Console.ReadLine();
        public Store(Player player)
        {
            this.player = player;
        }
        
        public void SellToPlayer()
        {
            switch (option)
            {
                case "1"://buy lemons
                    break;
                case "2"://buy sugar
                    break;
                case "3"://buy ice
                    break;
                case "4"://buy cups
                    break;
                case "5":
                    //Quit game
                    break;
                default:
                    Console.WriteLine("Please pick a valid option");
                    SellToPlayer();
                    break;
            }
        }

        public void SellLemons()
        {
            //10 for .60
            //30 for 2.30
            //75 for 4.30
            Console.WriteLine("How many lemons would you like to buy?");
        }
        public void SellCUps()
        {
            //25 for 1
            //50 for 1.75
            //100 for 3.25
        }
        public void SellIce()
        {
            //100 for 90
            //250 for 2.70
            //500 for 4
        }
        public void SellSugar()
        {
            //10 for .70
            //25 for 1.40
            //50 for 2.60
        }
    }
}
