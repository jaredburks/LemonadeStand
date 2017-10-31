using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//This class will interact with the Store class
namespace Lemonade
{
    public class Player
    {
        public string name = Console.ReadLine();
        public double wallet = 20.00;
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public Pitcher pitcher = new Pitcher();
    }
}
