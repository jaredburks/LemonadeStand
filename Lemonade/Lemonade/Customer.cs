using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Customer
    {
        public void Decide(Weather weather, Player player)
        {
            Random rnd = new Random();
            int chance = rnd.Next(1, 6);  // chance of buying: >= 1 and < 5
            if(chance == 1)
            {
                PriceFactor(player);
            }
            else if (chance == 2)
            {
                WeatherFactor(weather, player);
            }
            else if (chance == 3)
            {
                RecipeFactor(player);
            }
            else
            {
                Purchase(player);
            }
        }
        public void Purchase(Player player)//If conditions for customer's preferences are made, buy lemonade.
        {
            //decrement cup from pitcher class.
            player.pitcher.cups -= 1;
            //Add money to player.wallet
            player.wallet += player.recipe.pricePerCup;
        }
        public void PriceFactor(Player player)
        {
            if(player.recipe.pricePerCup > 1)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 100);  // chance of buying: >= 1 and < 100
                if(chance > 90)
                {
                    Purchase(player);
                }
            }
        }
        public void WeatherFactor(Weather weather, Player player)
        {
            if (weather.realTemp < 60 && weather.skyType == "cloudy" || weather.skyType == "rainy")
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 100);  // chance of buying: >= 1 and < 100
                if (chance > 50)
                {
                    Purchase(player);
                }
            }
        }
        public void RecipeFactor(Player player)
        {
            if (2 > player.recipe.numLemon || player.recipe.numLemon > 8 || player.recipe.cupsOfSugar < 2)
            {
                Random rnd = new Random();
                int chance = rnd.Next(1, 100);  // chance of buying: >= 1 and < 100
                if (chance > 50)
                {
                    Purchase(player);
                }
            }
        }
    }
}
