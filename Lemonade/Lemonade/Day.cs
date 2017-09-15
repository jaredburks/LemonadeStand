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
        List<Customer> customer;
        int day;
        Weather weather;
        public void DayShift()
        {
            weather = new Weather();
            weather.Forecast();

        }
    }
}
