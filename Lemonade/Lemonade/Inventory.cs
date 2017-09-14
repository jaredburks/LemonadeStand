﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Inventory
    {
        List<Lemon> lemons;
        List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;
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
        public virtual void Decay()//Rate at which supplies goes bad. Ice will be default since it will melt everyday.
        {
            //TODO:After each day expire will decrease by 1 and once it hits 0 call Rotten method to destroy obects
        }

        public virtual void Rotten()//Will destroy expired supplies and give a message
        {
            //TODO: Destroy ice
            Console.WriteLine("All of your ice cubes melted.");
        }
    }
}
