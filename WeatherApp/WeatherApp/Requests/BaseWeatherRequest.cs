using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Requests
{
    public abstract class BaseWeatherRequest
    {
        public abstract string PrepareQuery();
        public abstract string PrepareForecastQuery();
    }
}
