using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;


static class HelperCSVReader
{
   static public IEnumerable<Weather> ReadWeatherFromCSVHelper()
    {
       CsvConfiguration csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";"
            };
        IEnumerable<Weather> records = new List<Weather>();
        if(File.Exists(ConfigReader.PathToCSV))
        {
            StreamReader reader = new StreamReader(ConfigReader.PathToCSV);
            CsvReader csv = new CsvReader(reader, csvConfig);
            records = csv.GetRecords<Weather>();
        }
        return records;
    }
    static public List<Weather> ReadWeatherFromCSV()
    {
        List<Weather> records = new List<Weather>();
        if(File.Exists(ConfigReader.PathToCSV))
        {
            string readText = File.ReadAllText(ConfigReader.PathToCSV);
            List<string> lines = readText.Split("\r\n").ToList();
            lines.RemoveAt(0);
            lines.ForEach(line=>{
                var propperties = line.Split(";");
                records.Add(new Weather(propperties[0], propperties[1],propperties[2],propperties[3],propperties[4]));
            });
        }
        return records;
    }
}
