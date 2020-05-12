using Microsoft.CodeAnalysis.CSharp.Syntax;
using MyLeagueDashboard.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DTO
{
    public class MatchDTO
    {
        public long GameID { get; set; }
        public List<ParticipantIdentityDTO> ParticipantIdentities { get; set; }
        public int QueueID { get; set; }
        public string GameType { get; set; }
        public long GameDuration { get; set; }
        public List<TeamStatsDTO> Teams { get; set; }
        public string PlatformID { get; set; }
        public int SeasonID { get; set; }
        public int MapID { get; set; }
        public string GameMode { get; set; }
        public List<ParticipantDTO> Participants { get; set; }

        
    }
}
