using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using XMLStats;
using XMLStats.Entities;
using Newtonsoft.Json;
using System.Net;

namespace DemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string userAgentName = "MAKE UP A USER AGENT NAME";
            string apiKey = "ENTER YOUR API KEY HERE";

            //TEAM SCHEDULE Result example
            TeamScheduleResultsRequest resultRequest = new TeamScheduleResultsRequest(apiKey, userAgentName);
            List<TeamScheduleResult> resultList = resultRequest.getSince("mlb", "chicago-cubs", "20140605", "asc");
            TeamScheduleResult result = null;

            if (resultList != null)
            {
                foreach (TeamScheduleResult game in resultList)
                {
                    if (DateTime.Parse(game.event_start_date_time) < DateTime.Today && game.event_status == "completed")
                    {
                        result = game;
                        Console.WriteLine( "On " + DateTime.Parse(result.event_start_date_time).ToString("MM-dd-yyyy") + " " + result.team.full_name + " " + result.team_points_scored + " " + result.opponent.full_name + " " + result.opponent_points_scored);
                    }
                }
            }

            //Event and MLB Box Score Example
            string visitingTeam, homeTeam;
            DateTime eventDate;

            using (var client = new WebClient())
            {
                MLBBoxScore mlbBox = null;

                EventsRequest eventsRequest = new EventsRequest(apiKey, userAgentName);

                EventList eventList = eventsRequest.get("mlb", new DateTime(2014, 6, 8));

                foreach (Event singleEvent in eventList.@event)
                {
                    if (singleEvent.home_team.full_name.Contains("Cubs") || singleEvent.away_team.full_name.Contains("Cubs"))
                    {
                        visitingTeam = singleEvent.away_team.team_id;
                        homeTeam = singleEvent.home_team.team_id;

                        if (DateTime.TryParse(singleEvent.start_date_time, out eventDate))
                        {
                            MLBBoxScoreRequest mlbBoxRequest = new MLBBoxScoreRequest(apiKey, userAgentName);
                            mlbBox = mlbBoxRequest.get(eventDate, visitingTeam, homeTeam);
                        }
                    }
                    if (mlbBox != null)
                    {
                        Console.WriteLine( mlbBox.home_team.full_name + " " + mlbBox.home_batter_totals.runs + " " + mlbBox.away_team.full_name + " " + mlbBox.away_batter_totals.runs);
                    }
                }
            }

            //Event and NBA Box Score Example

            using (var client = new WebClient())
            {
                NBABoxScore nbaBox = null;

                EventsRequest eventsRequest = new EventsRequest(apiKey, userAgentName);

                EventList eventList = eventsRequest.get("nba", new DateTime(2014, 6, 8));

                foreach (Event singleEvent in eventList.@event)
                {
                    if (singleEvent.home_team.full_name.Contains("Heat") || singleEvent.away_team.full_name.Contains("Heat"))
                    {
                        visitingTeam = singleEvent.away_team.team_id;
                        homeTeam = singleEvent.home_team.team_id;

                        if (DateTime.TryParse(singleEvent.start_date_time, out eventDate))
                        {
                            NBABoxScoreRequest nbaBoxRequest = new NBABoxScoreRequest(apiKey, userAgentName);
                            nbaBox = nbaBoxRequest.get(eventDate, visitingTeam, homeTeam);
                        }
                    }
                    if (nbaBox != null)
                    {
                        Console.WriteLine( nbaBox.home_team.full_name + " " + nbaBox.home_totals.points + " " + nbaBox.away_team.full_name + " " + nbaBox.away_totals.points);
                    }
                }
            }
        }
    }
}
