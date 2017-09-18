using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class is for making the recipe for lemonade.
//Parent class of ice, sugar, lemon
//TODO:
//Fix so cannot buy anything if player wallet is too low on cash
namespace Lemonade
{
    public class Store
    {
        Player player;
        public Store(Player player)
        {
            this.player = player;
        }

        public void SellToPlayer()
        {
            Console.WriteLine("Welcome to the store.\n Enter 1 to buy lemons\n Enter 2 to buy sugar\n Enter 3 to buy ice\n Enter 4 to buy cups\n Enter 5 to continue to recipe\n");
            Console.WriteLine(player.name + " has $" + player.wallet.ToString("#.##") + " left\n");
            string option = Console.ReadLine();
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
                    player.recipe.SupplyAmounts();
                    break;
                default:
                    Console.WriteLine("Please pick a valid option");
                    SellToPlayer();
                    break;
            }
        }

        public void SellLemons()
        {
            Console.WriteLine("Enter 1 for 10 for .65");
            Console.WriteLine("Enter 2 for 30 for 2.35");
            Console.WriteLine("Enter 3 for 75 for 4.35");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many lemons would you like to buy?");
            string deal = Console.ReadLine();
            switch (deal)
            {
                case "1":
                    player.wallet = player.wallet - 0.65;
                    for (int i = 0; i < 10; i++)
                    {
                        player.inventory.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.lemons.Count + " lemons\n");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet = player.wallet - 2.35;
                    for (int i = 0; i < 30; i++)
                    {
                        player.inventory.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.lemons.Count + " lemons\n");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet = player.wallet - 4.35;
                    for (int i = 0; i < 75; i++)
                    {
                        player.inventory.BuyLemons();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.lemons.Count + " lemons\n");
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
            Console.WriteLine("Enter 1 for 25 for 1.12");
            Console.WriteLine("Enter 2 for 50 for 1.75");
            Console.WriteLine("Enter 3 for 100 for 3.25");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many cups would you like to buy?");
            string deal = Console.ReadLine();
            switch (deal)
            {
                case "1":
                    player.wallet = player.wallet - 1.12;
                    for (int i = 0; i < 25; i++)
                    {
                        player.inventory.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.cups.Count + " cups\n");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet = player.wallet - 1.75;
                    for (int i = 0; i < 50; i++)
                    {
                        player.inventory.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.cups.Count + " cups\n");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet = player.wallet - 3.25;
                    for (int i = 0; i < 100; i++)
                    {
                        player.inventory.BuyCups();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.cups.Count + " cups\n");
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
            Console.WriteLine("Enter 1 for 100 for .91");
            Console.WriteLine("Enter 2 for 250 for 2.73");
            Console.WriteLine("Enter 3 for 500 for 4.12");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How many icecubes would you like to buy?");
            string deal = Console.ReadLine();
            switch (deal)
            {
                case "1":
                    player.wallet = player.wallet - 0.91;
                    for (int i = 0; i < 100; i++)
                    {
                        player.inventory.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.ice.Count + " icecubes\n");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet = player.wallet - 2.73;
                    for (int i = 0; i < 250; i++)
                    {
                        player.inventory.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.ice.Count + " icecubes\n");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet = player.wallet - 4.12;
                    for (int i = 0; i < 500; i++)
                    {
                        player.inventory.BuyIce();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.ice.Count + " icecubes\n");
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
            Console.WriteLine("Enter 1 for 10 for .72");
            Console.WriteLine("Enter 2 for 30 for 1.41");
            Console.WriteLine("Enter 3 for 75 for 2.63");
            Console.WriteLine("Any other option will bring you back to store");
            Console.WriteLine("How much cups of sugar would you like to buy?");
            string deal = Console.ReadLine();
            switch (deal)
            {
                case "1":
                    player.wallet = player.wallet - .72;
                    for (int i = 0; i < 10; i++)
                    {
                        player.inventory.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.sugar.Count + " cups of sugar\n");
                    SellToPlayer();
                    break;
                case "2":
                    player.wallet = player.wallet - 1.41;
                    for (int i = 0; i < 25; i++)
                    {
                        player.inventory.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.sugar.Count + " cups of sugar\n");
                    SellToPlayer();
                    break;
                case "3":
                    player.wallet = player.wallet - 2.63;
                    for (int i = 0; i < 50; i++)
                    {
                        player.inventory.BuySugar();
                    }
                    Console.WriteLine(player.name + " has " + player.inventory.sugar.Count + " cups of sugar\n");
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