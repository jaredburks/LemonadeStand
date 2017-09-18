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

        Game game;
        public void Purchase()//If conditions for customer's preferences are made, buy lemonade.
        {
            //TODO: decrement cup from pitcher class.
            game.player.pitcher.cups = game.player.pitcher.cups - 1;
            //TODO: Add money to player.wallet
            game.player.wallet = game.player.wallet + game.player.recipe.pricePerCup;
            //TODO: destory instance of self
        }
    }
}
