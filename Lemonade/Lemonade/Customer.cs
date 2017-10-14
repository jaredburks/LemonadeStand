using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Customer
    {
        public double priceRange;
        public int likesLemons;
        public int likesSugar;
        public int likesIce;
        public int tempPreference;
        public string weatherType;

        public void Purchase(Player player)//If conditions for customer's preferences are made, buy lemonade.
        {
            //TODO: decrement cup from pitcher class.
            player.pitcher.cups -= 1;
            //TODO: Add money to player.wallet
            player.wallet += player.recipe.pricePerCup;
            //TODO: destory instance of self
        }
    }
}
