using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats.Entities
{
    public class BasketballTotals
    {
        public int minutes { get; set; }
        public int points { get; set; }
        public int assists { get; set; }
        public int turnovers { get; set; }
        public int steals { get; set; }
        public int blocks { get; set; }
        public int field_goals_attempted { get; set; }
        public int field_goals_made { get; set; }
        public int three_point_field_goals_attempted { get; set; }
        public int three_point_field_goals_made { get; set; }
        public int free_throws_attempted { get; set; }
        public int free_throws_made { get; set; }
        public int defensive_rebounds { get; set; }
        public int offensive_rebounds { get; set; }
        public int personal_fouls { get; set; }
        public double field_goal_percentage { get; set; }
        public double three_point_percentage { get; set; }
        public double free_throw_percentage { get; set; }
    }
}
