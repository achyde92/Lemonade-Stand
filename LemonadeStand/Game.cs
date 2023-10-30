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
		double transactionAmount;

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

                public void EndDay()
                {
                    double income = recipe.price * day.customersWhoBought;

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

		
	}
}

