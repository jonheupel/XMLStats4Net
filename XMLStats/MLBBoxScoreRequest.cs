using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLStats.Helpers;

namespace XMLStats
{
    public class MLBBoxScoreRequest
    {
        private readonly string _apiKey;
        private readonly string _userAgentName;
        private readonly string _alternateDomain;

        public MLBBoxScoreRequest(string apiKey, string userAgentName)
        {
            _apiKey = apiKey;
            _userAgentName = userAgentName;
        }

        public MLBBoxScoreRequest(string apiKey, string userAgentName, string alternateDomain) : this(apiKey, userAgentName)
        {
            _alternateDomain = alternateDomain;
        }

        //Pass Null for any values not needed
        public MLBBoxScore get(DateTime eventDate, string visitingTeam, string homeTeam)
        {
            string jsonStr, url = "";
            MLBBoxScore scheduleResult = null;


            using (var client = new GZipWebClient(_apiKey, _userAgentName, true))
            {
                if (_alternateDomain == null)
                    url = "https://erikberg.com/mlb/boxscore/" + eventDate.ToString("yyyyMMdd") + "-" + visitingTeam + "-at-" + homeTeam + ".json";
                else
                    url = "https://" + _alternateDomain + "/mlb/boxscore/" + eventDate.ToString("yyyyMMdd") + "-" + visitingTeam + "-at-" + homeTeam + ".json";

                jsonStr = client.DownloadString(url);
                scheduleResult = JsonConvert.DeserializeObject<MLBBoxScore>(jsonStr);

                return scheduleResult;
            }
        }

        //Pass Null for any values not needed
        public MLBBoxScore get(string _eventId)
        {
            string jsonStr, url = "";
            MLBBoxScore scheduleResult = null;


            using (var client = new GZipWebClient(_apiKey, _userAgentName, true))
            {
                if (_alternateDomain == null)
                    url = "https://erikberg.com/mlb/boxscore/" + _eventId + ".json";
                else
                    url = "https://" + _alternateDomain + "/mlb/boxscore/" + _eventId + ".json";

                jsonStr = client.DownloadString(url);
                scheduleResult = JsonConvert.DeserializeObject<MLBBoxScore>(jsonStr);

                return scheduleResult;
            }
        }
    }
}
