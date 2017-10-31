using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Has weather and list of different customers
namespace Lemonade
{
    public class Day
    {
        List<Customer> customer = new List<Customer>(new Customer[] { });
        public void DayShift(Weather wearther, Player player)
        {
            for (int i = 0; i < 100; i++)//Loop thru 100 potential customers
            {
                customer.Add(new Customer());
            }
            foreach(Customer element in customer)
            {
                element.Decide(wearther, player);
                //element.Purchase(player);
            }
        }
    }
}
