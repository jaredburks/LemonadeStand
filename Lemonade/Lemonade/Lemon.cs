using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    class Lemon : Inventory
    {
        public Lemon()
        {
            expire = 2;
        }

        public override void Rotten()//Rate at which Lemon goes bad.
        {
            //TODO: Destroy lemons
            foreach (Lemon element in lemons)
            {
                if (element.expire == 0)
                {
                    lemons.Remove(element);
                }
            }
            Console.WriteLine("All of your lemons spoiled.");
        }

    }
}
