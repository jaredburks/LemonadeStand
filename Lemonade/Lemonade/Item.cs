using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Item
    {
        public Inventory inventory;
        public int expire;

        //SOLID PRINCIPAL: OPEN/CLOSED PRICIPAL used for rotten method. Different items expire at different times.
        public virtual void Rotten()//Will destroy expired supplies and give a message
        {
            //TODO: Destroy ice
            foreach (Ice element in inventory.ice)
            {
                if (element.expire == 0)
                {
                    inventory.ice.Remove(element);
                }
            }
            Console.WriteLine("All of your ice cubes melted.");
        }
    }
}
