using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLStats.Entities;

namespace XMLStats
{
    public class NBABoxScoreRequest
    {
        private readonly string _apiKey;
        private readonly string _userAgentName;
        private readonly string _alternateDomain;

        public NBABoxScoreRequest(string apiKey, string userAgentName)
        {
            _apiKey = apiKey;
            _userAgentName = userAgentName;
        }

        public NBABoxScoreRequest(string apiKey, string userAgentName, string alternateDomain) : this(apiKey, userAgentName)
        {
            _alternateDomain = alternateDomain;
        }

        //Pass Null for any values not needed
        public NBABoxScore get(DateTime eventDate, string visitingTeam, string homeTeam)
        {
            string jsonStr, url = "";
            NBABoxScore scheduleResult = null;

            using (var client = new GZipWebClient(_apiKey, _userAgentName, true))
            {
                if (_alternateDomain == null)
                    url = "https://erikberg.com/nba/boxscore/" + eventDate.ToString("yyyyMMdd") + "-" + visitingTeam + "-at-" + homeTeam + ".json";
                else
                    url = "https://" + _alternateDomain + "/nba/boxscore/" + eventDate.ToString("yyyyMMdd") + "-" + visitingTeam + "-at-" + homeTeam + ".json";

                jsonStr = client.DownloadString(url);
                scheduleResult = JsonConvert.DeserializeObject<NBABoxScore>(jsonStr);

                return scheduleResult;
            }
        }
    }
}
