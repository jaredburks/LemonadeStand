﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonade
{
    public class Game
    {
        Player player;
        int day;
        Weather weather = new Weather();
        Recipe recipe = new Recipe();
        Store store = new Store();
        public void Rules()
        {
            Console.WriteLine("How to Play: ");
        }

        public void StartGame()
        {
            player = new Player();
            Rules();
            Console.WriteLine("Press any key to continue.\n");
            Console.ReadLine();
            Console.WriteLine("Start a new 7 day game. Press any key to continue.\n");
            Console.ReadLine();
            weather.Forecast();
            store.SellToPlayer();
            //TODO:Start Day 1
        }

    }
}
