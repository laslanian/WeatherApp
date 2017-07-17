using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Request
{
    class GRCAFlowRequest : BaseFlowRequest
    {
        
        public override string PrepareQuery()
        {
            throw new NotImplementedException();
        }
        public string PrepareQuery(string request, string format)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(FRConstants.GRCA);
            builder.Append(FRConstants.Service);
            builder.Append(request);
            builder.Append(FRConstants.AMP);
            builder.Append(FRConstants.DataSourceString);
            builder.Append(FRConstants.AMP);
            builder.Append(FRConstants.FormatString);
            builder.Append(format);

            return builder.ToString();
        }
    }

    class FRConstants
    {
        public const string GRCA = "http://kiwis.grandriver.ca/KiWIS/KiWIS?";
        public const string Service = "service=kisters&type=queryServices&request=";
        public const string DataSourceString = "datasource=0";
        public const string FormatString = "format=";
        public const string AMP = "&";


        #region Requests

        public const string GetStationList = "getStationList";
        public const string GetTimeseriesList = "getTimeseriesList";
        public const string GetTimeseriesValues = "getTimeseriesValues";
        public const string GetTimeseriesValueLayer = "getTimeseriesValueLayer";
        public const string GetSiteList = "getSiteList";
        public const string GetParameterList = "getParameterList";
        public const string GetParameterTypeList = "getParameterTypeList";
        public const string GetTimeseriesTypeList = "getTimeseriesTypeList";
        public const string GetGroupList = "getGroupList";
        public const string GetGraph = "getGraph";
        public const string GetGraphTemplateList = "getGraphTemplateList";
        public const string GetCatchmentList = "getCatchmentList";
        public const string GetRiverList = "getRiverList";

        #endregion

        #region Format
        public const string ASCII = "ASCII";
        public const string HTML = "HTML";
        public const string CSV = "CSV";
        public const string TABJSON = "TABJSON";
        public const string OBJSON = "OBJSON";
        public const string XLSX = "XLSX";
        #endregion
        
    }
}
//http://kiwis.grandriver.ca/KiWIS/KiWIS?service=kisters&type=queryServices&request=getStationList&datasource=0&format=html&station_name=A*&catchment_id=12
