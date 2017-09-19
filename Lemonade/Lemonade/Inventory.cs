using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Inventory
    {
        public List<Lemon> lemons = new List<Lemon>(new Lemon[] {});
        public List<Cups> cups = new List<Cups>(new Cups[] { });
        public List<Sugar> sugar = new List<Sugar>(new Sugar[] { });
        public List<Ice> ice = new List<Ice>(new Ice[] { });

        //figure out how to have one buy method for all 4 products(lemon, ice, sugar, cups). Look up "Generics"
        /*public void Buy()//Calls Sell method from store class which would tell how many lemons,ice, ect to add to list.
        {

        }*/
        public void BuyLemons()
        {
            lemons.Add(new Lemon());
        }
        public void BuyCups()
        {
            cups.Add(new Cups());
        }
        public void BuyIce()
        {
            ice.Add(new Ice());
        }
        public void BuySugar()
        {
            sugar.Add(new Sugar());
        }
    }
}
