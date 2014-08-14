using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class TeamScheduleResult
    {
        public string event_id { get; set; }
        public string event_status { get; set; }
        //public string event_start_date { get; set; }
        public string event_start_date_time { get; set; }
        public string event_season_type { get; set; }
        public int team_event_number_in_season { get; set; }
        public string team_event_location_type { get; set; }
        public string team_event_result { get; set; }
        public int team_points_scored { get; set; }
        public int team_events_won { get; set; }
        public int team_events_lost { get; set; }
        public Team team { get; set; }
        public int opponent_points_scored { get; set; }
        public int opponent_events_won { get; set; }
        public int opponent_events_lost { get; set; }
        public Opponent opponent { get; set; }
        public Site site { get; set; }
    }
}
