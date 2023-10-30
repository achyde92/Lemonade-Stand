using System;
using static System.Formats.Asn1.AsnWriter;

namespace LemonadeStand
{
	public class Game
	{
		Player player;
		List<Day> days;
		int currentday;
		Store store;
		Recipe recipe;
		Day day;

		public Game()
		{
			player = new Player();
			days = new List<Day>();
			store = new Store();
			recipe = new Recipe();
			currentday = 0;

			while (currentday <= 7)
			{
				Day day = new Day();
				day.StartDay();
				EndDay(); 
            }

			//Above I "tried" to do/Use abstraction to hide the details so the only methods would be start and end day.

            public void EndDay()
            {
                double income = recipe.price * day.customersWhoBought;
				double transactionAmount = 0;

                if (income > .transactionAmount)
                {
                    Console.WriteLine($"You profited {income - transactionAmount = store.SellCups(player)}");
                }
                else if (income < store.transactionAmount)
                {
                    Console.WriteLine($"Your losses totaled {income - store.transactionAmount}");
                }
                currentday++;
            }


		
	}
}

