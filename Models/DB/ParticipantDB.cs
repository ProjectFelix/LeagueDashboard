using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DB
{
    public class ParticipantDB
    {
        public int ParticipantDBID { get; set; }
        public int ParticipantID { get; set; }
        public int ChampionID { get; set; }
        public ParticipantStatsDB Stats { get; set; }
        public int TeamID { get; set; }
        public int Spell1ID { get; set; }
        public int Spell2ID { get; set; }
        public string HighestAchievedSeasonTier { get; set; }
    }
}
