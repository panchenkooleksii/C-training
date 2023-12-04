
using Microsoft.Extensions.Configuration;
var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
Console.WriteLine(builder["Path"]);