using System;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace LemonadeStand
{
	public class Weather
	{
        Random rand;
       public int temperature;
       public string condition;
        List<string> weatherconditions;
       public string predictedForecast;

        public Weather()
		{
            rand = new Random();
            this.temperature = rand.Next(55, 85);
            condition = "";
            weatherconditions = new List<string> { "Rainy", "Cloudy", "Sunny"};
            predictedForecast = "";
        }
        public void Forecast()
        {
            int randNum;
            randNum = rand.Next(3);
            predictedForecast = ($"{weatherconditions[randNum]}");
            Console.WriteLine($"The predicted weather for tomorrow is {predictedForecast} and {temperature} degrees");
        }
        public void ActualWeather()
        {
            int randNum;
            randNum = rand.Next(3);
            condition = ($"{weatherconditions[randNum]}");
            Console.WriteLine($"Today's weather is {condition} and {temperature} degrees");
        }
       
	}
}

