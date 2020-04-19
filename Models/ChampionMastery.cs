using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class ChampionMastery
    {
        public int ChampionID { get; set; }
        public int ChampionLevel { get; set; }

        public int ChampionPoints { get; set; }
        public long LastPlayTime { get; set; }
        public int ChampionPointsSinceLastLevel { get; set; }
        public int ChampionPointsUntilNextLevel { get; set; }
        public bool ChestGranted { get; set; }
        public int TokensEarned { get; set; }
        public string SummonerID { get; set; }
    }
}
