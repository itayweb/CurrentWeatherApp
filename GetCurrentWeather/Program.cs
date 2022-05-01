using System;
using Newtonsoft.Json;
using System.Net;

namespace GetCurrentWeather
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var units = args.Length == 2 ? "metric" : args[3];
            var city = args[1];
            var webClient = new WebClient();
            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY")}&units={units}";
            var json = webClient.DownloadString(apiCall);
            var apiResult = JsonConvert.DeserializeObject<Root>(json);
            Console.WriteLine(city + "|" + apiResult.Main.Temp + "|" + apiResult.Wind.Speed + "|" + apiResult.Main.Humidity + "|" + apiResult.Main.Pressure);
        }
    }
}