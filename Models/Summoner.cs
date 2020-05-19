using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class Summoner
    {
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string PuuId { get; set; }
        public string Name { get; set; }
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public int SummonerLevel { get; set; }

        public float KDA { get; set; }
        public string Region { get; set; }

        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }


    }
}
