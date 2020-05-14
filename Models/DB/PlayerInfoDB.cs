using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DB
{
    public class PlayerInfoDB
    {
        public int PlayerInfoDBID { get; set; }
        public long GameID { get; set; }
        public int ProfileIcon { get; set; }
        public string AccountID { get; set; }
        public string MatchHistoryURI { get; set; }
        public string CurrentAccountID { get; set; }
        public string CurrentPlatformID { get; set; }
        public string SummonerName { get; set; }
        public string SummonerID { get; set; }
        public string PlatformID { get; set; }
        public int ParticipantID { get; set; }
        public int ChampionID { get; set; }
        public int TeamID { get; set; }
        public int Spell1ID { get; set; }
        public int Spell2ID { get; set; }
        public string HighestAchievedSeasonTier { get; set; }
        public int GoldEarned { get; set; }
        public int TotalPlayerScore { get; set; }
        public int ChampLevel { get; set; }
        public int Deaths { get; set; }
        public int TotalScoreRank { get; set; }
        public int WardsPlaced { get; set; }
        public long TotalDamageDealt { get; set; }
        public int LargestKillingSpree { get; set; }
        public long TotalDamageDealtToChampions { get; set; }
        public int TotalMinionsKilled { get; set; }
        public int ObjectivePlayerScore { get; set; }
        public int Kills { get; set; }
        public int CombatPlayerScore { get; set; }
        public int Assists { get; set; }
        public bool Win { get; set; }
        public long VisionScore { get; set; }
        public bool FirstBloodKill { get; set; }
    }
}
