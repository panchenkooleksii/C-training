using System.Text.Json;

class JSONHelper
{
    public void ReadWeatherCSV(IEnumerable<Weather> records, string pathToFile)
    {
        string jsonData = JsonSerializer.Serialize(records);
        File.AppendAllText(pathToFile,jsonData);
    }
}
