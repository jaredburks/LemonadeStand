﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Has weather and list of different customers
namespace Lemonade
{
    public class Day
    {
        Player player;
        List<Customer> customer = new List<Customer>(new Customer[] { });
        public void DayShift()
        {
            for (int i = 0; i < 100; i++)
            {
                customer.Add(new Customer());
            }
            foreach(Customer element in customer)
            {
                element.Purchase(player);
            }
        }
    }
}
