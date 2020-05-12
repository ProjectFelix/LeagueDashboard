using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Models.DTO;

namespace MyLeagueDashboard.Models.DB
{
    public class MatchDB
    {

        public int MatchDBID { get; set; }
        public long GameID { get; set; }
        public ICollection<ParticipantIdentityDB> ParticipantIdentities { get; set; }
        public int QueueID { get; set; }
        public string GameType { get; set; }
        public long GameDuration { get; set; }
        public ICollection<TeamStatsDB> Teams { get; set; }
        public string PlatformID { get; set; }
        public int SeasonID { get; set; }
        public int MapID { get; set; }
        public string GameMode { get; set; }
        public ICollection<ParticipantDB> Participants { get; set; }
    }
}
