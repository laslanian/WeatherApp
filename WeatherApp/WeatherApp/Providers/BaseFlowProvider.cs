using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Providers
{
    public abstract class BaseFlowProvider
    {
        //retrieves list of stations with metadata
        public abstract void GetStations();
        //retrieves station with metadata
        public abstract void GetStation(string station_no);
        //retrieves a list of timeseries with metadata
        public abstract void GetTimeseriesList();
        //retrieves timeseries data
        public abstract void GetTimeseriesValues();
        //retrieves a layer of timeseries for a given date including location data
        public abstract void GetTimeseriesValuesLayer();
        //retrieves a list of rivers with metadata
        public abstract void GetRiverList();
        //retrieves a list of catchments with metadata
        public abstract void GetCatchmentList();
        //retrieves a list of sites with metadata
        public abstract void GetSiteList();

    }
}
