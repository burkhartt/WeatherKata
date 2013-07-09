using System;
using SharedCode;

namespace WeatherData
{
    public class Program
    {
        private static void Main()
        {
            var repo = new WeatherDataRepository();
            var context = new WeatherContext(new Minimum<WeatherData>(x => x.TemperatureSpread));
            var weather = repo.GetAll();
            var weatherDay = context.Apply(weather);

            Console.WriteLine(weatherDay.Day);
            Console.ReadKey();
        }
    }
}