using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        // member variables (HAS A)
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public string name;
        public Store store;

        // constructor (SPAWNER)
        public Player(string name)
        {
            inventory = new Inventory();
            wallet = new Wallet();
            recipe = new Recipe();
            this.name = name;

        }

        // member methods (CAN DO)

        public void PlayerName()
        {
            Console.WriteLine("What is the players name?");
            string name = Console.ReadLine();
        }

        public void PurchaseSupplies()
        {
            if ()
            {
                Store.SellLemons();
            }
        }
    }
}
