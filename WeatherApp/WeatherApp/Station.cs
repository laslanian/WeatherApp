using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class Station
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public Coordinates Coords { get; set; }
        public Weather Weather { get; set; }
        public WaterFlow Flow { get; set; }
        public WaterQuality Quality { get; set; }

        public Station()
        {
            this.Id = String.Empty;
            this.Name = String.Empty;
            this.Coords = new Coordinates();
            this.Weather = new Weather();
            this.Flow = new WaterFlow();
            this.Quality = new WaterQuality();
        }
    }
    public class Coordinates
    {
        public double Longitude {get;set;}
        public double Latitude { get; set; }
        public Coordinates()
        {
            this.Longitude = 0;
            this.Latitude = 0;
        }
    }
    public class WaterQuality
    {
        public double DissolvedO2 { get; set; }
        public double Nitrogen { get; set; }
        public double Turbidity { get; set; }
        public Temperature WaterTemp {get;set;}

        public WaterQuality()
        {
            this.DissolvedO2 = 0;
            this.Nitrogen = 0;
            this.Turbidity = 0;
            this.WaterTemp = new Temperature();

        }
    }
    public class WaterFlow
    {
        public double FlowRate { get; set; }
        public double WaterLevel { get; set; }
        public WaterFlow()
        {
            this.FlowRate = 0;
            this.WaterLevel = 0;
        }
        
    }
    public class Temperature
    {
        public double Celcius { get; set; }
        public double Fahrenheit { get; set; }
        public Temperature()
        {
            this.Celcius = 0;
            this.Fahrenheit = 0;
        }

        public double ConvertToFahrenheit() { return 0; }
        public double ConvertToCelcius() { return 0; }
    }
}
