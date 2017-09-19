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
        public void TestBuyLemons()//Test that BuyLemons() method adds Lemon to List<Lemon> lemons
        {
            Player player = new Player();
            int expectedResult = 1;

            player.inventory.BuyLemons();

            Assert.AreEqual(expectedResult, player.inventory.lemons.Count);
        }
    }
}
