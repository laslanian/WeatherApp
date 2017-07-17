using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Logger;

namespace WeatherApp.Managers
{
    class WeatherManager
    {
        public XMLLogProvider Logger;

        public async Task<Weather> GetCurrentWeather(Station station)
        {
            Logger = new XMLLogProvider();
            Logger.LogMessage("WeatherManager", "Entering GetCurrentWeather", DateTime.Now);

            WeatherProvider weatherProvider = new WeatherProvider();
            
            dynamic result = await weatherProvider.GetCurrentWeather(station);

            //map result to Weather object

            return new Weather();
        }
    }
}
