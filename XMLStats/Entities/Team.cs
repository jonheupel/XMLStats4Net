using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class Team
    {
        public string team_id { get; set; }
        public string abbreviation { get; set; }
        public bool active { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string conference { get; set; }
        public string division { get; set; }
        //public string site { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string full_name { get; set; }
        public string site_name { get; set; }
    }
}
