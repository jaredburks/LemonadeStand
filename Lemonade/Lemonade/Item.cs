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
