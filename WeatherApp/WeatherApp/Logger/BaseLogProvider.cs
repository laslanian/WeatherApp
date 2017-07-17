using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Logger
{
    public abstract class BaseLogProvider
    {
        protected string m_basepath = "C:\\Users\\leoas\\Documents\\WeatherApp_LOG\\";

        
        public abstract void LogEntity(string caller, string entity, string message, DateTime dt);
        public abstract void LogException(string caller, string exception, string message, DateTime dt);
        public abstract void LogMessage(string caller, string message, DateTime dt);
    }
}
