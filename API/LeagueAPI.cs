using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace MyLeagueDashboard.API
{
    public class LeagueAPI
    {
        private string Key { get; set; }
        private string Region { get; set; }

        public LeagueAPI(string region)
        {
            Region = region;
            // Read key from text. Added file to .gitignore.
            // Using temporary dev key.
            Key = GetKey("API/key.txt");
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetURI(string path)
        {
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "?api_key=" + Key;
        }

        protected string GetChampionURI()
        {
            return "http://ddragon.leagueoflegends.com/cdn/10.8.1/data/en_US/champion.json";
        }

        public string GetKey(string path)
        {
            StreamReader sr = new StreamReader(path);
            return sr.ReadToEnd();
        }
    }
}
