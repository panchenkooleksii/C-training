using CsvHelper.Configuration.Attributes;

class Weather
{
    [Index(0)]
    public string? Timestamp { get; set; }
    [Index(1)]
    public string? City { get; set; }
    [Index(2)]
    public int? TemperatureC { get; set; }
    [Index(3)]
    public int? TemperatureF { get; set; }
    [Index(4)]
    public string? Summary { get; set; }
}