using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats.Entities
{
    public class NBABoxScore
    {
        public AwayTeam away_team { get; set; }
        public HomeTeam home_team { get; set; }
        public List<int> away_period_scores { get; set; }
        public List<int> home_period_scores { get; set; }
        public List<AwayStat> away_stats { get; set; }
        public List<HomeStat> home_stats { get; set; }
        public List<Official> officials { get; set; }
        public EventInformation event_information { get; set; }
        public AwayTotals away_totals { get; set; }
        public HomeTotals home_totals { get; set; }
    }
}
