using System.Collections.Generic;
using System.Linq;
using SharedCode;

namespace SoccerLeague
{
    internal class EnglishPremierLeagueStandingsRepository : IRepository<EnglishPremierLeagueStanding>
    {
        public IEnumerable<EnglishPremierLeagueStanding> GetAll()
        {
            var csvReader = new FileReader();
            return csvReader.Read<EnglishPremierLeagueStanding>(@"C:\Users\Tim.Burkhart\Documents\Visual Studio 2010\Projects\WeatherData\football.txt");
        }
    }
}