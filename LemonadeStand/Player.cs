using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            int lemonsToPurchase;

            Console.WriteLine("How many lemons would you like to buy?");
            lemonsToPurchase = int.Parse(Console.ReadLine());

            if (lemonsToPurchase > 0)
            {
                inventory.AddLemonsToInventory(lemonsToPurchase);
            }

            int sugarToPurchase;

            Console.WriteLine("How much sugar would you like to buy?");
            sugarToPurchase = int.Parse(Console.ReadLine());

            if (sugarToPurchase > 0)
            {
                inventory.AddSugarCubesToInventory(sugarToPurchase);
            }

            int iceCubesToPurchase;

            Console.WriteLine("How many ice cubes would you like to buy?");
            iceCubesToPurchase = int.Parse(Console.ReadLine());

            if (iceCubesToPurchase > 0)
            {
                inventory.AddIceCubesToInventory(iceCubesToPurchase);
            }

            int cupsToPurchase;

            Console.WriteLine("How many cups would you like to buy?");
            cupsToPurchase = int.Parse(Console.ReadLine());

            if (cupsToPurchase > 0)
            {
                inventory.AddCupsToInventory(cupsToPurchase);
            }
          
                
        }
    }
}
