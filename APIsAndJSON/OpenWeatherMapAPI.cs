using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {

        public static void Weather()
        {
            Console.Write("enter zipcode: ");
            var zip = Console.ReadLine();
            HttpClient instance = new HttpClient();
            var apiKeyObj = File.ReadAllText("AppSettings.json");
            var apiKey = JObject.Parse(apiKeyObj).GetValue("apiKey");
            var WeatherURL = $"https://api.openweathermap.org/data/2.5/weather?zip={zip}&appid={apiKey}&units=imperial";
            var WeatherResponse = instance.GetStringAsync(WeatherURL).Result;
            var WeatherQuote = JObject.Parse(WeatherResponse);
            Console.WriteLine($"Weather : {WeatherQuote["main"]["temp"]}");


        }
    }
}
