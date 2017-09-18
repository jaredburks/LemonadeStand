using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Customer
    {
        public double priceRange;
        public int likesLemons;
        public int likesSugar;
        public int likesIce;
        public int tempPreference;
        public string weatherType;

        Player player = new Player();
        Recipe recipe = new Recipe();
        Pitcher pitcher = new Pitcher();

        public void Purchase()//If conditions for customer's preferences are made, buy lemonade.
        {
            //TODO: decrement cup from pitcher class.
            //TODO: Add money to player.wallet
            player.wallet = player.wallet + recipe.pricePerCup;
            //TODO: destory instance of self
        }
    }
}
