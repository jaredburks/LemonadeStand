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

        public void Purchase()//If conditions for customer's preferences are made, buy lemonade.
        {
            //TODO: decrement supplies(cups,ice,lemon,sugar)
            //TODO: destory instance of self
        }
    }
}
