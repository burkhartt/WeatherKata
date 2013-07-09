using System.Collections.Generic;
using System.Linq;
using SharedCode;

namespace WeatherData
{
    internal class WeatherDataRepository : IRepository<WeatherData>
    {
        public IEnumerable<WeatherData> GetAll()
        {
            var csvReader = new FileReader();
            return csvReader.Read<WeatherData>(@"C:\Users\Tim.Burkhart\Documents\Visual Studio 2010\Projects\WeatherData\weather.txt");            
        }
    }
}