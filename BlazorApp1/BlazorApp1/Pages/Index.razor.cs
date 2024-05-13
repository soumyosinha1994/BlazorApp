using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;

namespace BlazorApp1.Pages
{
    public class IndexBase:ComponentBase
    {
        public WeatherForecast[]? forecasts;
        public int? PageIndex { get; set; }
        protected override async Task OnInitializedAsync()
        {
            WeatherForecastService ForecastService = new WeatherForecastService();
            forecasts= await ForecastService.GetForecastAsync(DateTime.Now);
            PageIndex = 1;

            //forecasts = await Forecast();
        }
        //public async Task<WeatherForecast[]> Forecast()
        //{
        //    WeatherForecastService ForecastService = new WeatherForecastService();
        //    return await ForecastService.GetForecastAsync(DateTime.Now);
             
        //}
    }
}
