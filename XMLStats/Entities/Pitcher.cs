using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class Pitcher
    {
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string display_name { get; set; }
        public int pitch_order { get; set; }
        public int errors { get; set; }
        public bool win { get; set; }
        public bool loss { get; set; }
        public bool save { get; set; }
        public bool hold { get; set; }
        public double era { get; set; }
        public double whip { get; set; }
        public double innings_pitched { get; set; }
        public int hits_allowed { get; set; }
        public int runs_allowed { get; set; }
        public int earned_runs { get; set; }
        public int walks { get; set; }
        public int intentional_walks { get; set; }
        public int strike_outs { get; set; }
        public int home_runs_allowed { get; set; }
        public int pitch_count { get; set; }
        public int pitches_strikes { get; set; }
        public int wild_pitches { get; set; }
        public int hit_by_pitch { get; set; }
        public string team_abbreviation { get; set; }
    }
}
