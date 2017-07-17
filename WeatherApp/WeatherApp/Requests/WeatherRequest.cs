using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Requests;

namespace WeatherApp.Request
{
    class WeatherRequest : BaseWeatherRequest
    {
        public Coordinates Coords { get; set; }
        public string APIKey { get; set; }
        public string URL { get; set; }
        public WeatherRequest(string url, string key, Coordinates coords)
        {
            this.URL = url;
            this.APIKey = key;
            this.Coords = coords;
        }

        public override string PrepareQuery()
        {
            return URL + Coords + ",us&appid=" + APIKey + "&units=imperial";
        }
        public override string PrepareForecastQuery()
        {
            throw new NotImplementedException();
        }
    }
}
