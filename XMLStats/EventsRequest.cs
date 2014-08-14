using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLStats.Helpers;

namespace XMLStats
{
    public class EventsRequest
    {
        private readonly string _apiKey;
        private readonly string _userAgentName;
        private readonly string _alternateDomain;

        public EventsRequest(string apiKey, string userAgentName)
        {
            _apiKey = apiKey;
            _userAgentName = userAgentName;
        }

        public EventsRequest(string apiKey, string userAgentName, string alternateDomain) : this(apiKey, userAgentName)
        {
            _alternateDomain = alternateDomain;
        }

        public EventList get(string sport, DateTime date)
        {
            string jsonStr, url = "";
            EventList eventResult = null;
            NameValueCollection queryParameters = new NameValueCollection();

            using (var client = new GZipWebClient(_apiKey, _userAgentName, true))
            {
                if (_alternateDomain == null)
                    url = "https://erikberg.com/events.json";
                else
                    url = "https://" + _alternateDomain + "/events.json";

                if (sport != null)
                    queryParameters.Add("sport", sport);
                if (date != null)
                    queryParameters.Add("date", date.ToString("yyyyMMdd"));

                if (queryParameters.Count > 0)
                {
                    url += RequestHelpers.ToQueryString(queryParameters);
                }

                jsonStr = client.DownloadString(url);
                eventResult = JsonConvert.DeserializeObject<EventList>(jsonStr);

                return eventResult;
            }
        }
    }
}
