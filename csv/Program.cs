ConfigReader appConfig = new ConfigReader();
HelperCSVReader reader = new HelperCSVReader();
JSONHelper writter = new JSONHelper();

if(File.Exists(appConfig.PathToJSON))
    File.Delete(appConfig.PathToJSON);
var records = reader.ReadWeatherCSV(appConfig.PathToCSV);
writter.ReadWeatherCSV(records, appConfig.PathToJSON);
