using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade;
using System.Collections.Generic;

namespace LemonadeStandTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()//Test that BuyLemons() method adds Lemon to List<Lemon> lemons
        {
            Inventory inventory;
            List<Lemon> lemons = new List<Lemon>(new Lemon[] { });
            inventory.BuyLemons();
        }
    }
}
