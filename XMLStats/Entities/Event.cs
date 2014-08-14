using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class Event
    {
        public string event_id { get; set; }
        public string event_status { get; set; }
        public string sport { get; set; }
        public string start_date_time { get; set; }
        public string season_type { get; set; }
        public AwayTeam away_team { get; set; }
        public HomeTeam home_team { get; set; }
        public Site site { get; set; }
    }
}
