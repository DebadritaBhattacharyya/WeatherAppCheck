
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Weather_Client_Tool
{
    public class WeatherOperations
    {
        public string GetWeatherDetails(string latitude, string longitude)  // Get the weather deatils based on the given country's latitude and longitude. 
        {
            using (var client = new System.Net.WebClient()) //WebClient  
            {
                client.Headers.Add("Content-Type:application/json"); //Content-Type  
                client.Headers.Add("Accept:application/json");
                var result = client.DownloadString("https://api.open-meteo.com/v1/forecast?latitude="+latitude+"&longitude="+longitude+"&current_weather=true"); //URI
                return result;
            }
        }
    }
}
