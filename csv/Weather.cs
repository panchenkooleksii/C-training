using CsvHelper.Configuration.Attributes;

class Weather
{
    public Weather(DateTimeOffset timestamp, string city, int temperatureC, int temperatureF, string summary)
    {
        Timestamp = timestamp;
        City = city;
        TemperatureC = temperatureC;
        TemperatureF = temperatureF;
        Summary = summary;
    }
    [Index(0)]
    public DateTimeOffset? Timestamp { get; set; }
    [Index(1)]
    public string? City { get; set; }
    [Index(2)]
    public int? TemperatureC { get; set; }
    [Index(3)]
    public int? TemperatureF { get; set; }
    [Index(4)]
    public string? Summary { get; set; }
}