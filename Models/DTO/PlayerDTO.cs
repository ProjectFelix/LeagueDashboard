using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DTO
{
    public class PlayerDTO
    {
        public int ProfileIcon { get; set; }
        public string AccountID { get; set; }
        public string MatchHistoryURI { get; set; }
        public string CurrentAccountID { get; set; }
        public string CurrentPlatformID { get; set; }
        public string SummonerName { get; set; }
        public string SummonerID { get; set; }
        public string PlatformID { get; set; }
    }
}
