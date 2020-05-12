using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MyLeagueDashboard.Data;

namespace MyLeagueDashboard.API
{
    public class Champion_Mastery_V4 : LeagueAPI
    {
        public Champion_Mastery_V4(string region) : base(region)
        {
        }

        public List<ChampionMastery> GetChampionMasteryById(string summonerID)
        {
            string path = $"champion-mastery/v4/champion-masteries/by-summoner/{summonerID}?";

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

        public MasteryResponse GetChampionList()
        {
            MasteryResponse response = new MasteryResponse();
            using (StreamReader r = File.OpenText("C:/Users/James/source/repos/MyLeagueDashboard/Data/ExampleChampion.json"))
            {
                string json = r.ReadToEnd();
                JObject championSearch = JObject.Parse(json);
                //IList<JToken> results = championSearch["data"].Children().ToList();
                response = championSearch.ToObject<MasteryResponse>();
                //list.Champions = dict;
            }
            return response;
        }

        public MasteryResponse GetAllChampions()
        {
            MasteryResponse response = new MasteryResponse();
            var resp = GET(GetChampionURI());
            string content = resp.Content.ReadAsStringAsync().Result;

            if (resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.Write("Return good");
                response = JsonConvert.DeserializeObject<MasteryResponse>(content);
            }
            else
            {
                Console.Write("Return bad");
                return null;
            }
            return response;
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

