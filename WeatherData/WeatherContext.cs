using System.Collections.Generic;
using SharedCode;

namespace WeatherData
{
    internal class WeatherContext : Context<WeatherData>
    {
        private readonly ContextStrategy<WeatherData> strategy;

        public WeatherContext(ContextStrategy<WeatherData> strategy)
        {
            this.strategy = strategy;
        }

        public override WeatherData Apply(IEnumerable<WeatherData> weather)
        {
            return strategy.Execute(weather);            
        }
    }
}