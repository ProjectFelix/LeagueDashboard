using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DB
{
    public class TeamStatsDB
    {
        public int TeamStatsDBID { get; set; }
        public int TowerKills { get; set; }
        public int RiftHeraldKills { get; set; }
        public bool FirstBlood { get; set; }
        public int InhibitorKills { get; set; }
        public int DragonKills { get; set; }
        public int BaronKills { get; set; }
        public int TeamID { get; set; }
        public string Win { get; set; } // "Win" or "Fail"
    }
}
