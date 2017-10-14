using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemonade;
using System.Collections.Generic;
using System.IO;

namespace LemonadeStandTest
{
    [TestClass]
    public class LemonadeTest
    {
        [TestMethod]
        public void BuyLemons_AddLemonsToLemonsList()//Test that BuyLemons() method adds Lemon to List<Lemon> lemons
        {
            //Arrange
            Player player = new Player();
            int expectedResult = 1;
            //Act
            player.inventory.BuyLemons();
            //Assert
            Assert.AreEqual(expectedResult, player.inventory.lemons.Count);
        }
        [TestMethod]
        public void BuyCups_AddCupsTocupsList()//Test that BuyCups() method adds Cups to List<Cups> cups
        {
            //Arrange
            Player player = new Player();
            int expectedResult = 1;
            //Act
            player.inventory.BuyCups();
            //Assert
            Assert.AreEqual(expectedResult, player.inventory.cups.Count);
        }
        [TestMethod]
        public void BuySugar_AddSugarToSugarList()//Test that BuySugar() method adds Sugar to List<Sugar> sugar
        {
            //Arrange
            Player player = new Player();
            int expectedResult = 1;
            //Act
            player.inventory.BuySugar();
            //Assert
            Assert.AreEqual(expectedResult, player.inventory.sugar.Count);
        }
        [TestMethod]
        public void BuyIce_AddIceToIceList()//Test that BuyIce() method adds Ice to List<Ice> ice
        {
            //Arrange
            Player player = new Player();
            int expectedResult = 1;
            //Act
            player.inventory.BuyIce();
            //Assert
            Assert.AreEqual(expectedResult, player.inventory.ice.Count);
        }
        [TestMethod]
        public void Rotten_SugarExpire_SugarListEqualZero()
        {
            //Arrange
            Player player = new Player();
            player.inventory.BuySugar();
            player.inventory.sugar[0].expire = 0;
            int expectedResult = 0;
            //Act
            player.inventory.sugar[0].Rotten();
            //Assert
            Assert.AreEqual(expectedResult, player.inventory.sugar.Count);
        }
    [TestMethod]
        public void SellLemons_BuyTenLemons_Subtract65Cents()//Test SellLemons() method. Specifically that the price subtracts from player's wallet's total.
        {
            //Arrange
            Player player = new Player();
            Store store = new Store(player);
            double expectedResult = 19.35;
            string input = "1";
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);
            //Act
            store.SellLemons();
            //Assert
            Assert.AreEqual(expectedResult, player.wallet);
        }
    }
}
