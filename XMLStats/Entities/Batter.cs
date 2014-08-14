using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class Batter
    {
        public string last_name { get; set; }
        public string first_name { get; set; }
        public string display_name { get; set; }
        public string position { get; set; }
        public int bat_order { get; set; }
        public int sub_bat_order { get; set; }
        public int singles { get; set; }
        public int doubles { get; set; }
        public int triples { get; set; }
        public int hits { get; set; }
        public int rbi { get; set; }
        public int sacrifices { get; set; }
        public double ops { get; set; }
        public int at_bats { get; set; }
        public int plate_appearances { get; set; }
        public int home_runs { get; set; }
        public int sac_flies { get; set; }
        public int sac_hits { get; set; }
        public int stolen_bases { get; set; }
        public int caught_stealing { get; set; }
        public int rbi_with_two_outs { get; set; }
        public int total_bases { get; set; }
        public int runs { get; set; }
        public int walks { get; set; }
        public int strike_outs { get; set; }
        public int left_on_base { get; set; }
        public int hit_by_pitch { get; set; }
        public string team_abbreviation { get; set; }
        public int extra_base_hits { get; set; }
        public string slg_string { get; set; }
        public string batting_highlights { get; set; }
        public double strikeout_rate { get; set; }
        public string ops_string { get; set; }
        public double at_bats_per_rbi { get; set; }
        public double walk_rate { get; set; }
        public double plate_appearances_per_rbi { get; set; }
        public double stolen_base_average { get; set; }
        public double slg { get; set; }
        public double at_bats_per_home_run { get; set; }
        public string obp_string { get; set; }
        public string avg_string { get; set; }
        public double avg { get; set; }
        public double obp { get; set; }
        public double plate_appearances_per_home_run { get; set; }
    }
}
