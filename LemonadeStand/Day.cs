using System;
namespace LemonadeStand
{
	internal class Day
	{
		Weather weather;
		public List<Customer> customers;
		Wallet wallet;

		public Day()
		{
			customers = new List<Customer>();
			weather = new Weather();
			wallet = new Wallet();
		}

		public void StartDay()
		{
            Weather weather = new Weather();
            weather.Forecast();
            weather.ActualWeather();

        }

		public void CreateCustomers(int numOfCustomers)
		{
			for (int i = 0; i < numOfCustomers; i++)
			{
				customers.Add(new Customer());
			}
		}

		public int SimulatingCustomersWalkingBy(double lemonadePrice)
		{
			int customersWhoBought = 0;

			foreach (Customer customer in customers)
			{
				if (customer.WillBuyLemonade(lemonadePrice))
				{
					Console.WriteLine("A customer puchased lemonade!");
					customersWhoBought++;
				}
				else
				{
					Console.WriteLine("A customer walked away.");
				}
			}
			return customersWhoBought;
		}

		public int FootTraffic()
		{
			int potentialfootTraffic = 0;

			foreach(Customer customer in customers)
			{
				if (weather.condition == "Rainy")
				{
					Console.WriteLine("The rain is driving away customers");
					 potentialfootTraffic = potentialfootTraffic + 15;
				}
				else if (weather.condition == "Cloudy")
				{
					Console.WriteLine("The Weather is mid, expect a moderate number of customers");
					 potentialfootTraffic = potentialfootTraffic + 25;
				}
				else if (weather.condition == "Sunny")
				{
					Console.WriteLine("The weather is nice! There should many people out!");
					potentialfootTraffic = potentialfootTraffic + 35;
				}
				if (weather.temperature <=  64)
				{
					Console.WriteLine("It's a little chilly today");
					potentialfootTraffic = potentialfootTraffic - 5;
				}
				else if (weather.temperature <= 74 && weather.temperature > 64)
				{
					Console.WriteLine("The weather is nearly perfect today");
					potentialfootTraffic = potentialfootTraffic + 5;
				}
				else if (weather.temperature >= 75)
				{
					Console.WriteLine("It's hot today. People will be thirsty");
					potentialfootTraffic = potentialfootTraffic + 10;
				}
			}
			return potentialfootTraffic;
		}
		public void EndDay()
		{
			double income;
			double transactionAmount;

			if (wallet.AcceptMoney(income) > wallet.PayMoneyForItems(transactionAmount))
			{
				Console.WriteLine($"You profited {wallet.AcceptMoney() - wallet.PayMoneyForItems()}");
			}
			else if (wallet.AcceptMoney() < wallet.PayMoneyForItems())
			{
				Console.WriteLine($"Your losses totaled {wallet.AcceptMoney() - wallet.PayMoneyForItems()}");
			}
		}
	}
}

