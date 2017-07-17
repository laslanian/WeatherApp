using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Request;

namespace WeatherApp.Providers
{
    class WeatherProvider : BaseWeatherProvider
    {
        public readonly string APIKey = "";
        public readonly string URL = "http://api.openweathermap.org/data/2.5/weather?zip=";

        public async override Task<dynamic> GetCurrentWeather(Station station)
        {
            string request = new WeatherRequest(URL, APIKey, station.Coords).PrepareQuery();
            return await DataProvider.getDataFromService(request);
        }

        public async override Task<dynamic> GetForecastWeather(DateTime date, Station station)
        {
            string request = new WeatherRequest(URL, APIKey, station.Coords).PrepareForecastQuery();
            return await DataProvider.getDataFromService(request);

        }
    }
}
