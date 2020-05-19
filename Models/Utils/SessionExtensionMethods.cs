using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.Utils
{
    public static class SessionExtensionMethods
    {
        public static void SetSummoner(this ISession session, Summoner summ)
        {
            session.SetString("Summoner", JsonConvert.SerializeObject(summ));
        }
        public static Summoner GetSummoner(this ISession session)
        {
            return JsonConvert.DeserializeObject<Summoner>(session.GetString("Summoner"));
        }
    }
}
