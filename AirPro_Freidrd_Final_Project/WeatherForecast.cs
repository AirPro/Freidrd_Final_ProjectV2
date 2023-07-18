namespace AirPro_Freidrd_Final_Project
{
    public class WeatherForecast
    {
        // This will have to be changed
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string? Summary { get; set; }
    }
}