using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Sugar will decay/go bad after 2 days
namespace Lemonade
{
    public class Sugar : Item
    {
        public Sugar()
        {
            expire = 3;
        }
        public override void Rotten()//Rate at which sugar goes bad.
        {
            //TODO: Destroy sugar
            foreach (Sugar element in inventory.sugar)
            {
                if (element.expire == 0)
                {
                    inventory.sugar.Remove(element);
                }
            }
            Console.WriteLine("The sugar has bugs in it, it must be thorwn out.");
        }
    }
}
