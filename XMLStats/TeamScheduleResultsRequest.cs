using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Specialized;
using XMLStats.Helpers;
using System.Net;

namespace XMLStats
{
    public class TeamScheduleResultsRequest
    {
        private readonly string _apiKey;
        private readonly string _userAgentName;
        private readonly string _alternateDomain; 


        public TeamScheduleResultsRequest(string apiKey, string userAgentName)
        {
            _apiKey = apiKey;
            _userAgentName = userAgentName;
        }

        public TeamScheduleResultsRequest(string apiKey, string userAgentName, string alternateDomain) : this (apiKey, userAgentName)
        {
            _alternateDomain = alternateDomain;
        }

        public List<TeamScheduleResult> getSince(string sport, string teamId, string since)
        {
            return get(sport, teamId, null, since, null, null);
        }

        public List<TeamScheduleResult> getSince(string sport, string teamId, string since, string order)
        {
            return get(sport, teamId, null, since, null, order);
        }

        public List<TeamScheduleResult> get(string sport, string teamId)
        {
            return get(sport, teamId, null, null, null, null);
        }

        //Pass Null for any values not needed
        public List<TeamScheduleResult> get(string sport, string teamId, string season, string since, string until, string order)
        {
            string jsonStr, url = "";
            List<TeamScheduleResult> scheduleResult = null;

            NameValueCollection queryParameters = new NameValueCollection();

            using (var client = new GZipWebClient(_apiKey, _userAgentName, true))
            {
                if (_alternateDomain == null)
                    url = "https://erikberg.com/" + sport + "/results/" + teamId + ".json";
                else
                    url = "https://" + _alternateDomain + "/" + sport + "/results/" + teamId + ".json";

                if (season != null)
                    queryParameters.Add("season", season);
                if (since != null)
                    queryParameters.Add("since", since);
                if (until != null)
                    queryParameters.Add("until", until);
                if (order != null)
                    queryParameters.Add("order", order);

                if (queryParameters.Count > 0)
                {
                    url += RequestHelpers.ToQueryString(queryParameters);
                }

                jsonStr = client.DownloadString(url);
                scheduleResult = JsonConvert.DeserializeObject<List<XMLStats.TeamScheduleResult>>(jsonStr);

                return scheduleResult;
            }
        }
    }
}
