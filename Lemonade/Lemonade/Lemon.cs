using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Lemon : Item
    {
        public Lemon()
        {
            expire = 2;
        }

        public override void Rotten()//Rate at which Lemon goes bad.
        {
            //TODO: Destroy lemons
            foreach (Lemon element in inventory.lemons)
            {
                if (element.expire == 0)
                {
                    inventory.lemons.Remove(element);
                }
            }
            Console.WriteLine("All of your lemons spoiled.");
        }

    }
}
