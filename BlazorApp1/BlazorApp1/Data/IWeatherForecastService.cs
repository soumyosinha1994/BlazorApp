﻿namespace BlazorApp1.Data
{
    public interface IWeatherForecastService
    {
        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate);
    }
}
