using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Will show the amount of supplies to subtract from inventory and be put in pitcher.
namespace Lemonade
{
    class Recipe
    {
        Inventory inventory = new Inventory();
        int numLemon;
        int cupsOfSugar;
        int numIce;
        double pricePerCup;
        public void SupplyAmounts()
        {
            Console.WriteLine("Recipe\n\nChoose how much of each item to put in a pitcher of lemonade.");
            Console.WriteLine(" Enter 1 for price per cup\n Enter 2 for number of lemons\n Enter 3 for cups of sugar\n Enter 4 for icecubes per cup\n Enter 5 to Begin Selling Lemonade");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    ChoosePrice();
                    SupplyAmounts();
                    break;
                case "2":
                    LemonsInPitcher();
                    SupplyAmounts();
                    break;
                case "3":
                    ChooseCupsOfSugar();
                    SupplyAmounts();
                    break;
                case "4":
                    ChooseIcecubes();
                    SupplyAmounts();
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please enter a valid option\n");
                    SupplyAmounts();
                    break;
            }
        }

        public double ChoosePrice()
        {
            Console.WriteLine("Enter price per cup of lemonade");
            pricePerCup = Convert.ToDouble(Console.ReadLine());
            return pricePerCup;
        }

        public int LemonsInPitcher()
        {
            Console.WriteLine("Enter # of lemons per pitcher");
            numLemon = Convert.ToInt32(Console.ReadLine());
            return numLemon;
        }

        public int ChooseCupsOfSugar()
        {
            Console.WriteLine("Enter # of cups of sugar per pitcher");
            cupsOfSugar = Convert.ToInt32(Console.ReadLine());
            return cupsOfSugar;
        }

        public int ChooseIcecubes()
        {
            Console.WriteLine("Enter # of icecubes per cup");
            numIce = Convert.ToInt32(Console.ReadLine());
            return numIce;
        }
    }
}
