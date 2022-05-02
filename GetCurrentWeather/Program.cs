using System;
using Newtonsoft.Json;
using System.Net;

namespace GetCurrentWeather
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            //args = new[] { "-c", "London", "-u", "metric" };
            var city = "";
            if (args.Length == 1)
                return 1;
            else
                city = args[1];
            var i = 2;
            while (i < args.Length)
            {
                if (args[i] == "-u" || args[i] == "--units") break;
                city += " " + args[i];
                i++;
            }
            var units = "";
            if (i >= args.Length)
                units = "metric";
            else if (args[i + 1] == "metric" || args[i + 1] == "imperial")
                units = args[i + 1];
            else
                return 1;
            var webClient = new WebClient();
            var apiCall =
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={Environment.GetEnvironmentVariable("OPENWEATHER_API_KEY")}&units={units}";
            var json = "";
            try
            {
                json = webClient.DownloadString(apiCall);
            }
            catch (WebException exception)
            {
                return 404;
            }
            var apiResult = JsonConvert.DeserializeObject<Root>(json);
            Console.WriteLine(city + "|" + (int)apiResult.Main.Temp + "|" + apiResult.Wind.Speed + "|" + apiResult.Main.Humidity + "|" + apiResult.Main.Pressure);
            return 0;
        }
    }
}