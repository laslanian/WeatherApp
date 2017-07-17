using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Request
{
    public abstract class BaseFlowRequest
    {
        public abstract string PrepareQuery();
        
    }
}
