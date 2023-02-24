// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Text.Json;
using System.Text.Json.Serialization;
using static Custom_Weather_Client_Tool.CountryLoc;
using System.Linq;

namespace Custom_Weather_Client_Tool
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Enter City Name: ");
            var CityName = Console.ReadLine();
            Country CountryDetailsObj = null;
            string FileName = @"in.json";
            string WorkingDirPath = Directory.GetCurrentDirectory();
            var InstallDir = WorkingDirPath.Substring(0, WorkingDirPath.IndexOf("Custom Weather Client Tool", StringComparison.OrdinalIgnoreCase) + 26);
            var JsonFilePath= Path.Combine(InstallDir,"Data", FileName);
            string  JText =File.ReadAllText(JsonFilePath);
            CountryDetailsObj = JsonSerializer.Deserialize<Country>(JText);
            CityDetails City = CountryDetailsObj.CityDetails.Where(x => x.city.Equals(CityName)).FirstOrDefault();
            if (City != null)
            {
                WeatherOperations op = new WeatherOperations();
                var result = op.GetWeatherDetails(City.lat, City.lng); // Get the weather deatils based on the given country's latitude and longitude. 
                Console.WriteLine(Environment.NewLine + result);
            }
            else
            {
                Console.WriteLine("Country: "+CityName+ " is not valid!!!");

            }

        }
    

    }  


   
}
