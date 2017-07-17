using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Providers
{
    public abstract class BaseWeatherProvider
    {
        //retrieves current weather by location
        public abstract Task<dynamic> GetCurrentWeather(Station station);//Location loc
        //retrieves weather by date/location
        public abstract Task<dynamic> GetForecastWeather(DateTime date, Station station);//Location loc
    }
}
