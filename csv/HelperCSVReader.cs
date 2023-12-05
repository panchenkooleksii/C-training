using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


class HelperCSVReader
{
    StreamReader reader;
    CsvReader csv;
    CsvConfiguration csvConfig;
    
    

    public IEnumerable<Weather> ReadWeatherCSV(string pathToFile)
    {
        csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
        IEnumerable<Weather> records = new List<Weather>();
        if(File.Exists(pathToFile))
        {
            reader = new StreamReader(pathToFile);
            csv = new CsvReader(reader, csvConfig);
            records = csv.GetRecords<Weather>();
        }
        return records;
    }
}
