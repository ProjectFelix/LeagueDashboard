using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class ChampionInfo
    {
        public Dictionary<string, Champion> Champions { get; set; }

        public ChampionInfo()
        {
            Champions = new Dictionary<string, Champion>();
        }
    }
}
