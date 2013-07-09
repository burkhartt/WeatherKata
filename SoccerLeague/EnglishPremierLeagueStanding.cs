using System.Collections.Generic;
using SharedCode;

namespace SoccerLeague
{
    internal class EnglishPremierLeagueStanding : ConvertibleDataType
    {
        public string TeamName { get; set; }
        public int GoalsScoredFor { get; set; }
        public int GoalsScoredAgainst { get; set; }
        public int GoalDifference { get { return GoalsScoredFor - GoalsScoredAgainst; } }
        public override IDictionary<int, string> GetMappings() {
            return new Dictionary<int, string>
                {
                    {1, "TeamName"},
                    {6, "GoalsScoredFor"},
                    {8, "GoalsScoredAgainst"}
                };
        }
    }
}