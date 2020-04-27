using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class ChampionList
    {
        public Dictionary<string, List<Champion>> Champions { get; set; }
    }
}
