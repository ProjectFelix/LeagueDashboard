using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Models;
using Newtonsoft.Json;

namespace MyLeagueDashboard.API
{
    public class Champion_Mastery_V4 : LeagueAPI
    {
        public Champion_Mastery_V4(string region) : base(region)
        {
        }

        public List<ChampionMastery> GetChampionMasteryById(string summonerID)
        {
            string path = "champion-mastery/v4/champion-masteries/by-summoner/" + summonerID;

            var response = GET(GetURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.Write("Return good");
                return JsonConvert.DeserializeObject<List<ChampionMastery>>(content);
            }
            else
            {
                Console.Write("Return bad");
                return null;
            }
        }

        // Thought this was going to be needed. But it doesnt work. Can just call DeserializeObject using a List type
        public IEnumerable<T> DeserializeObjects<T>(string input)
        {
            JsonSerializer serializer = new JsonSerializer();
            using (var strreader = new StringReader(input))
                using (var jsonreader = new JsonTextReader(strreader))
            {
                jsonreader.SupportMultipleContent = true;
                while (jsonreader.Read())
                {
                    yield return serializer.Deserialize<T>(jsonreader);
                }
            }

        }
    }
}

