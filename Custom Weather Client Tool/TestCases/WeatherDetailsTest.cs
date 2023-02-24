using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using System.IO;
using System.Reflection;
using Custom_Weather_Client_Tool;

namespace Custom_Weather_Client_Tool.TestCases
{
    public class WeatherDetailsTest
    {
        [Fact]
        public void  GetWeatherDetails_Test()
        {
           var weatherop = new WeatherOperations();
           var result = weatherop.GetWeatherDetails("18.9667", "72.8333");
           Assert.NotNull(result);
        }

    }
}
