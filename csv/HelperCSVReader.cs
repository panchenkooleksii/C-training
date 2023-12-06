using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

class HelperCSVReader
{
    StreamReader reader;
    CsvReader csv;
    CsvConfiguration csvConfig;
    
    public IEnumerable<Weather> ReadWeatherFromCSV()
    {
        csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
        IEnumerable<Weather> records = new List<Weather>();
        if(File.Exists(ConfigReader.PathToCSV))
        {
            reader = new StreamReader(ConfigReader.PathToCSV);
            csv = new CsvReader(reader, csvConfig);
            records = csv.GetRecords<Weather>();
        }
        return records;
    }
}
