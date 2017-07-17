using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using WeatherApp.Services;
using WeatherApp.Logger; 
using System.Threading.Tasks;

namespace WeatherApp.Droid
{
	[Activity (Label = "WeatherApp.Android", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
        WeatherService m_weatherService=null;
        LogProvider m_logger = null;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

            FlowService flowService = new FlowService();
            flowService.GetCurrentFlow(new Station());

			button.Click +=  async delegate {
                try
                {
                    Weather weather = await m_weatherService.GetCurrentWeather(new Station());
                }
                catch (Exception ex)
                {
                    m_logger.LogException(this.Class.Name, ex.InnerException.ToString(), ex.Message, DateTime.Now);
                }
                //assign weather to UI

            };
		}
        private void InitializeComponents()
        {
            m_weatherService = new WeatherService();
            m_logger = new LogProvider();
        }
	}
}


