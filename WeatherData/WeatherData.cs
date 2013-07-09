using System.Collections.Generic;
using SharedCode;

namespace WeatherData
{
    internal class WeatherData : ConvertibleDataType
    {
        public int Day { get; set; }
        public int MaxTemperature { get; set; }
        public int MinTemperature { get; set; }
        public int TemperatureSpread { get { return MaxTemperature - MinTemperature; } }
        public override IDictionary<int, string> GetMappings()
        {
            return new Dictionary<int, string>
                {
                    {0, "Day"},
                    {1, "MaxTemperature"},
                    {2, "MinTemperature"}
                };
        }
    }
}