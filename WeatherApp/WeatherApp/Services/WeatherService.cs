using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Managers;

namespace WeatherApp.Services
{
    public class WeatherService
    {
        public async Task<Weather> GetCurrentWeather(Station station)
        {
            WeatherManager weatherManager = new WeatherManager();
            Weather current = await weatherManager.GetCurrentWeather(station);

            return new Weather();

        }
    }
}
