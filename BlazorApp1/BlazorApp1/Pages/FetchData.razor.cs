using BlazorApp1.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp1.Pages
{
    public class FetchDataBase: ComponentBase
    {
        //[BindProperty]
        [Parameter]
        public WeatherForecast[]? forecasts { get; set; }
        //[Parameter]
        //public EventCallback<WeatherForecast[]> forecastsChanged { get; set; }

        //[Inject] 
        //IWeatherForecastService _ForecastService { get; set; }

        //[BindProperty]
        [Parameter]
        public int? PageIndex { get; set; }
        [Parameter]
        public EventCallback<int?> PageIndexChanged { get; set; }

        [Parameter]
        public RenderFragment CustomMessage { get; set; }

        //[Parameter]
        //public IndexBase Parent { get; set; } = new();

        //protected WeatherForecast[]? _forecasts;

        //protected override async Task OnParametersSetAsync()
        //{

        //    _forecasts = await Parent.Forecast();

        //}
        protected override async Task OnInitializedAsync()
        {
            //forecasts = await _ForecastService.GetForecastAsync(DateTime.Now);
            PageIndex = 2;
            await base.OnInitializedAsync();
        }
    }
}
