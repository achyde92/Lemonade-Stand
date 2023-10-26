using System;
namespace LemonadeStand
{
	public class Customer
	{
		Random rand;
		int footTraffic;
		List<string> WillingtoBuy;
		string BuyOrPass;
		Weather weather;

		public Customer()
		{
			rand = new Random();
			this.footTraffic = rand.Next();
			WillingtoBuy = new List<string> { "Yes", "No" };
			Weather weather = new Weather();
		}
		public void WeatherCond()
		{
			int randNum;
			randNum = rand.Next(10, 40);
			if (weather.condition == "Rainy")
			{
				footTraffic = rand.Next(9, 20);
			}
			else if (weather.condition == "Cloudy")
            {
				footTraffic = rand.Next(20, 30);
            }
			else if (weather.condition == "Sunny")
            {
                footTraffic = rand.Next(30, 41);
			}
		}
		public void WeatherTemp()
		{
			if (weather.temperature <= 65 )
			{
                footTraffic - 5;
			}
			 else if (weather.temperature >75)
			{
               footTraffic + 5;
			}
		}
		public void PricePoint()
		{
			int randNum;
			randNum = rand.Next(2);
			if (price > 3) ;
			BuyOrPass = ($"{WillingtoBuy[randNum]}");
		}
	}
}

