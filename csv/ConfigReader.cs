using Microsoft.Extensions.Configuration;
public static class ConfigReader
{
    static IConfigurationRoot configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    private static string ReadConfig(string key) => configuration[key];
    public static string PathToCSV => ReadConfig("PathToCSV");
    public static string PathToJSON => ReadConfig("PathToJSON");
}