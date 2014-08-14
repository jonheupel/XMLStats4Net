using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class MLBBoxScore
    {
        public AwayTeam away_team { get; set; }
        public HomeTeam home_team { get; set; }
        public List<int> away_period_scores { get; set; }
        public List<int> home_period_scores { get; set; }
        public List<AwayBatter> away_batters { get; set; }
        public List<HomeBatter> home_batters { get; set; }
        public List<AwayPitcher> away_pitchers { get; set; }
        public List<HomePitcher> home_pitchers { get; set; }
        public List<Official> officials { get; set; }
        public EventInformation event_information { get; set; }
        public AwayBatterTotals away_batter_totals { get; set; }
        public HomeBatterTotals home_batter_totals { get; set; }
    }
}
