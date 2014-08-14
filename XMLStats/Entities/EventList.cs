using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLStats
{
    public class EventList 
    {
        public string events_date { get; set; }
        public List<Event> @event { get; set; }

        //public IEnumerator GetEnumerator()
        //{
        //    return (@event as IEnumerable).GetEnumerator();
        //}
    }
}
