using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace OpenWeatherLibrary
{
    public class WeatherGenerator
    {
        public static async Task<string> GetWeatherAsync()

        {
            HttpClient httpClient = new HttpClient();

            string cpt = await httpClient.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=f56fd6fd6dd6b3c61a68b9224700830d");

           LocalWeather Localweather = JsonConvert.DeserializeObject<LocalWeather>(cpt);

            var returnString = "";
            


            foreach (Weather weather in LocalWeather.weather)
            {
                returnString = weather.description;
             }

            return cpt;

        }
}
}
