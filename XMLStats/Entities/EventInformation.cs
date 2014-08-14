using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class EventInformation
    {
        public int temperature { get; set; }
        public Site site { get; set; }
        public int attendance { get; set; }
        public string duration { get; set; }
        public string season_type { get; set; }
        public string start_date_time { get; set; }
    }
}
