using System;
using SharedCode;

namespace SoccerLeague
{
    internal class Program
    {
        private static void Main()
        {
            var repo = new EnglishPremierLeagueStandingsRepository();
            var standings = repo.GetAll();
            var context = new EnglishPremierLeagueStandingsContext(new Minimum<EnglishPremierLeagueStanding>(x => x.GoalDifference));
            var standing = context.Apply(standings);

            Console.WriteLine(standing.TeamName);
            Console.ReadKey();
        }
    }
}