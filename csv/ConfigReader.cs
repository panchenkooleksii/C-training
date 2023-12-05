using Microsoft.Extensions.Configuration;
public class ConfigReader
{
    IConfigurationRoot _builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    private string ReadConfig(string key) => _builder[key];
    public string PathToCSV => ReadConfig("PathToCSV");
}