using System;
using System.Threading.Tasks;
using WeatherApp.Providers;
using WeatherApp.Request;

namespace WeatherApp
{
    public class Core
    {
        private string Key;
        private string URL;

        public string m_key { get { return Key; }set { Key = value; } }
        public string m_url { get { return URL; } set { URL = value; } }

        public Core(string url, string key)
        {
            this.m_key = key;
            this.m_url = url;
        }//http://kiwis.grandriver.ca
        public static async Task<dynamic> GetData(string query)
        {
            return await DataProvider.getDataFromService(query).ConfigureAwait(false);
        }

        public async Task<Weather> GetWeather(string zipCode)
        {
                        //Sign up for a free API key at http://openweathermap.org/appid  
            string key = "YOUR KEY HERE";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?zip="
                + zipCode + ",us&appid=" + key + "&units=imperial";

            //Make sure developers running this sample replaced the API key
            if (key == "YOUR API KEY HERE")
            {
                throw new ArgumentException("You must obtain an API key from openweathermap.org/appid and save it in the 'key' variable.");
            }

            dynamic results = await DataProvider.getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }

        //public Station GetStation(string stationId) { }
        //public static async Task<> GetStations() { }

        //public static async Task<> GetFlowByStation(string stationId) { }
        //public static async Task<> GetWaterQualityByStation(string stationId) { }

        //public static async Task<> GetFlowHistoryByStation(string stationId) { }
        //public static async Task<> GetWaterQualityHistoryByStation(string stationId) { }
    }
    

}

