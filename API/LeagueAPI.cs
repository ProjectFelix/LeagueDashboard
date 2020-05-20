using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;
using Microsoft.Azure.KeyVault;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

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
            Task getKey = new Task(async () => await GetSecret());
            getKey.Start();
            getKey.Wait();
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
            return "https://" + Region + ".api.riotgames.com/lol/" + path + "api_key=" + Key;
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

        public async Task GetSecret()
        {
            // clientsecret value Lkb.~~h2.Mb26ajhlemnw1bJ1s27QL-rs8
            // active client ID "c179dabc-339d-48cb-86b2-b8fa065044a5"
            const string aci = "c179dabc-339d-48cb-86b2-b8fa065044a5";
            const string acs = "Lkb.~~h2.Mb26ajhlemnw1bJ1s27QL-rs8";
            const string key_uri = "https://leaguedashkey.vault.azure.net/";

            var kvc = new KeyVaultClient(new KeyVaultClient.AuthenticationCallback(
                async (string authority, string resource, string scope) =>
                {
                    var authContext = new AuthenticationContext(authority);
                    var credential = new ClientCredential(aci, acs);
                    AuthenticationResult result = await authContext.AcquireTokenAsync(resource, credential);
                    if (result == null)
                    {
                        throw new InvalidOperationException("Failed to retrieve JWT token");
                    }
                    return result.AccessToken;
                }));

            var secretBundle = await kvc.GetSecretAsync(key_uri, "LeagueDashAPIKey");
            Key = secretBundle.Value;
        }
    }
}
