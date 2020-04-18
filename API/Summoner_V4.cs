using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Models;
using Newtonsoft.Json;

namespace MyLeagueDashboard.API
{
    public class Summoner_V4 : LeagueAPI
    {
        public Summoner_V4(string region) : base(region)
        {
        }

        public Summoner GetSummonerByName(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Return good");
                return JsonConvert.DeserializeObject<Summoner>(content);
            }
            else
            {
                Console.WriteLine("Return bad");
                return null;
            }
        }

        public string GetSummonerByNameTest(string SummonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + SummonerName;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            return content;
        }
    }
}
