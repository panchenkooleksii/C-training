using System.Text.Json;

static class JSONHelper
{
    public static void WriteListToJSON(List<Weather> records)
    {
        string jsonData = JsonSerializer.Serialize(records);
        File.AppendAllText(ConfigReader.PathToJSON,jsonData);
    }
}
