using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Custom_Weather_Client_Tool
{
 public class CountryLoc
 {
     public class CityDetails
        { public string city { get; set; }
         public string lat { get; set; }
         public string lng { get; set; }
         public string country { get; set; }   
         public string iso2 { get; set; } 
         public  string admin_name { get; set; } 
         public string capital { get; set; } 
         public string population { get; set; } 
         public string population_proper { get; set; }
       }
    public class Country
    {
        public List<CityDetails> CityDetails { get; set; }
    }
  }
}
