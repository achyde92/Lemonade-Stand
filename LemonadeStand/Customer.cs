using System;
namespace LemonadeStand
{
	public class Customer
	{
		Random rand;
		int footTraffic;
		List<string> WillingtoBuy;

		public Customer()
		{
			rand = new Random();
			this.footTraffic = rand.Next(10,40);
			WillingtoBuy = new List<string> { "Yes", "No" };
		}
		public void PredictedFactors()
		{
			if (predictedForecast == "rainy") ;
			
		}
	}
}

