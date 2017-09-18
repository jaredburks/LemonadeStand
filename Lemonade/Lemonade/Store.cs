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
        Recipe recipe;
        string option = Console.ReadLine();
        public Store(Player player)
        {
            this.player = player;
        }

        public void SellToPlayer()
        {
            Console.WriteLine("Welcome to the store.\n Enter 1 to buy lemons\n Enter 2 to buy sugar\n Enter 3 to buy ice\n Enter 4 to buy cups\n Enter 5 to contine to recipe\n");
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
                    //move on to recipe
                    recipe.SupplyAmounts();
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
                    for (int i = 0; i < 10; i++)
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
            string deal = Console.ReadLine();
            Console.WriteLine("Enter 1 for 25 for 1.00");
            Console.WriteLine("Enter 2 for 50 for 1.75");
            Console.WriteLine("Enter 3 for 100 for 3.25");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many cups would you like to buy?");
            switch (deal)
            {
                case "1":
                    player.wallet -= player.wallet - 1.00;
                    for (int i = 0; i < 25; i++)
                    {
                        stash.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet -= player.wallet - 1.75;
                    for (int i = 0; i < 50; i++)
                    {
                        stash.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet -= player.wallet - 3.25;
                    for (int i = 0; i < 100; i++)
                    {
                        stash.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups");
                    SellToPlayer();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again or continue to Recipe");
                    SellToPlayer();
                    break;
            }
        }

        public void SellIce()
        {
            //100 for .90
            //250 for 2.70
            //500 for 4.00
            string deal = Console.ReadLine();
            Console.WriteLine("Enter 1 for 100 for .90");
            Console.WriteLine("Enter 2 for 250 for 2.70");
            Console.WriteLine("Enter 3 for 500 for 4.00");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many icecubes would you like to buy?");
            switch (deal)
            {
                case "1":
                    player.wallet -= player.wallet - .90;
                    for (int i = 0; i < 100; i++)
                    {
                        stash.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " icecubes");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet -= player.wallet - 2.70;
                    for (int i = 0; i < 250; i++)
                    {
                        stash.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " icecubes");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet -= player.wallet - 4.00;
                    for (int i = 0; i < 500; i++)
                    {
                        stash.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " icecubes");
                    SellToPlayer();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again or continue to Recipe");
                    SellToPlayer();
                    break;
            }
        }

        public void SellSugar()
        {
            //10 for .70
            //25 for 1.40
            //50 for 2.60
            string deal = Console.ReadLine();
            Console.WriteLine("Enter 1 for 10 for .70");
            Console.WriteLine("Enter 2 for 30 for 1.40");
            Console.WriteLine("Enter 3 for 75 for 2.60");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How much cups of sugar would you like to buy?");
            switch (deal)
            {
                case "1":
                    player.wallet -= player.wallet - .70;
                    for (int i = 0; i < 10; i++)
                    {
                        stash.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups of sugar");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet -= player.wallet - 1.40;
                    for (int i = 0; i < 25; i++)
                    {
                        stash.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups of sugar");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet -= player.wallet - 2.60;
                    for (int i = 0; i < 50; i++)
                    {
                        stash.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + stash.lemons.Count + " cups of sugar");
                    SellToPlayer();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again or continue to Recipe");
                    SellToPlayer();
                    break;
            }
        }
    }
}