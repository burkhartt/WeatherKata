using System.Collections.Generic;
using SharedCode;

namespace SoccerLeague
{
    internal class EnglishPremierLeagueStandingsContext : Context<EnglishPremierLeagueStanding>
    {
        private readonly ContextStrategy<EnglishPremierLeagueStanding> strategy;

        public EnglishPremierLeagueStandingsContext(ContextStrategy<EnglishPremierLeagueStanding> strategy)
        {
            this.strategy = strategy;
        }

        public override EnglishPremierLeagueStanding Apply(IEnumerable<EnglishPremierLeagueStanding> data)
        {
            return strategy.Execute(data);
        }
    }
}