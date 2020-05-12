using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Models;
using MyLeagueDashboard.Models.DTO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MyLeagueDashboard.API
{
    public class Match_V4 : LeagueAPI
    {
        public Match_V4(string region) : base(region)
        {
        }

        public MatchesResponse GetMatchesByAccountID(string accountID)
        {
            string path = $"match/v4/matchlists/by-account/{accountID}?endIndex=2&";

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Return good");
                return JsonConvert.DeserializeObject<MatchesResponse>(content);
            }
            else
            {
                Console.WriteLine("Return bad");
                return null;
            }
        }

        public MatchDTO GetMatchByMatchID(string matchID)
        {
            string path = $"match/v4/matches/{matchID}?";

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Return good");
                return JsonConvert.DeserializeObject<MatchDTO>(content);
            }
            else
            {
                Console.WriteLine("Return bad");
                return null;
            }
        }
    }
}
