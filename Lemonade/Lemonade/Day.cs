using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Has weather and list of different customers
namespace Lemonade
{
    class Day
    {
        Customer patron;
        List<Customer> customer = new List<Customer>(new Customer[] { });
        Weather weather;
        public void DayShift()
        {
            weather = new Weather();
            weather.ActualWeather();
            
            for(int i = 0; i < 100; i++)
            {
                customer.Add(new Customer());
            }

            foreach(Customer element in customer)
            {
                element.Purchase();
            }

        }
    }
}
