if(File.Exists(ConfigReader.PathToJSON))
    File.Delete(ConfigReader.PathToJSON);
var records = HelperCSVReader.ReadWeatherFromCSV();
JSONHelper.WriteListToJSON(records);
