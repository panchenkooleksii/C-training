using System.Text.Json;

class JSONHelper
{
    public void WriteListToJSON(IEnumerable<Weather> records)
    {
        string jsonData = JsonSerializer.Serialize(records);
        File.AppendAllText(ConfigReader.PathToJSON,jsonData);
    }
}
