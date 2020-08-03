using System;

namespace AuctionExplorer
{
    public class WeatherForecast
    {
        public int BigChungus { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureCelsius { get; set; }

        public int TemperatureFahrenheit => 32 + (int) (TemperatureCelsius / 0.5556);

        public int TemperatureKelvin => TemperatureCelsius + 381;

        public string WeatherSummary { get; set; }
    }
}