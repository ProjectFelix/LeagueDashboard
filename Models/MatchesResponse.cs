using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class MatchesResponse
    {
        public int MatchesResponseID { get; set; }
        public List<Matches> Matches { get; set; }

        public string SummonerID { get; set; }
    }
}
