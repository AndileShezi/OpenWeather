using OpenWeatherLibrary;
using System;
using System.Threading.Tasks;

namespace OpenWeatherConsole
{
    class Program
    {
    static async Task Main(string[] args)
        {
            WeatherGenerator weather = new WeatherGenerator();
            string weatherNow = await weather.GetWeatherAsync();
            Console.WriteLine(weatherNow);
        }
    }
}

