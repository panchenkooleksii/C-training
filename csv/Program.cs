
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;

var appConfig = new ConfigReader();

using var reader = new StreamReader(appConfig.PathToCSV);
var config = new CsvConfiguration(CultureInfo.InvariantCulture)
{
    Delimiter = ";"
};
using var csv = new CsvReader(reader, config);

// read CSV file
var records = csv.GetRecords<Weather>();

Console.WriteLine(records.Count());
// output
foreach (var r in records)
{
   Console.WriteLine($"{r.Timestamp,-15}{r.City,-10}{r.TemperatureC,15}{r.TemperatureF,15}{r.Summary,5}");
}