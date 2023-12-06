
HelperCSVReader reader = new HelperCSVReader();
JSONHelper writter = new JSONHelper();

if(File.Exists(ConfigReader.PathToJSON))
    File.Delete(ConfigReader.PathToJSON);
var records = reader.ReadWeatherFromCSV();
writter.WriteListToJSON(records);
