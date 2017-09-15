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
        Inventory stash;
        Player player;
        string option = Console.ReadLine();
        public Store(Player player)
        {
            this.player = player;
        }
        
        public void SellToPlayer()
        {
            Console.WriteLine("Welcome to the store, whatchu want?");
            switch (option)
            {
                case "1"://buy lemons
                    SellLemons();
                    break;
                case "2"://buy sugar
                    SellSugar();
                    break;
                case "3"://buy ice
                    SellIce();
                    break;
                case "4"://buy cups
                    SellCups();
                    break;
                case "5":
                    //Quit game or move to recipe
                    break;
                default:
                    Console.WriteLine("Please pick a valid option");
                    SellToPlayer();
                    break;
            }
        }

        public void SellLemons()
        {
            string deal = Console.ReadLine();
            Console.WriteLine("Enter 1 for 10 for .60");
            Console.WriteLine("Enter 2 for 30 for 2.30");
            Console.WriteLine("Enter 3 for 75 for 4.30");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many lemons would you like to buy?");
            switch (deal)
            {
                case "1":
                    player.wallet -= player.wallet - .60;
                    for(int i = 0; i < 10; i++)
                    {
                        stash.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " lemons");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet -= player.wallet - 2.30;
                    for (int i = 0; i < 30; i++)
                    {
                        stash.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " lemons");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet -= player.wallet - 4.30;
                    for (int i = 0; i < 75; i++)
                    {
                        stash.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " lemons");
                    SellToPlayer();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again or continue to Recipe");
                    SellToPlayer();
                    break;
            }
        }
        public void SellCups()
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
