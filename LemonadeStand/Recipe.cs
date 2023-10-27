using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Recipe
    {
        // member variables (HAS A)
        public int numberOfLemons;
        public int numberOfSugarCubes;
        public int numberOfIceCubes;
        public double price;


        // constructor (SPAWNER)
        public Recipe()
        {
            numberOfLemons = 2;
            numberOfSugarCubes = 4;
            numberOfIceCubes = 10;
            price = 1;
        }

        //Member Methods (CAN DO)
        public void DisplayRecipe()
        {
            Console.WriteLine($"Your recipe currently consists of:\n{numberOfLemons} lemons per pitcher\n{numberOfSugarCubes} sugar cubes per pitcher\n{numberOfIceCubes} ice cubes per pitcher");
        }
        public void RecipeInput()
        {
            Console.WriteLine("How many Ice Cubes in the recipe?");
            numberOfIceCubes = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Lemons in the recipe?");
            numberOfLemons = int.Parse(Console.ReadLine());
            Console.WriteLine("How many Sugar Cubes in the recipe?");
            numberOfSugarCubes = int.Parse(Console.ReadLine());
        }
        public void PriceInput()
        {
            Console.WriteLine("How much will each cup cost?");
            price = double.Parse(Console.ReadLine());
        }
    }
}
