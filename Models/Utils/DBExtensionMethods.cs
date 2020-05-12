using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyLeagueDashboard.Data;
using MyLeagueDashboard.Models.DB;
using MyLeagueDashboard.Models.DTO;

namespace MyLeagueDashboard.Models.Utils
{
    public static class DBExtensionMethods
    {
        public static MatchDB ConvertMatchDTOToDB(this MatchDTO dto, ApplicationDbContext context)
        {
            MatchDB match = context.Matches.Where(m => m.GameID == dto.GameID).FirstOrDefault();

            if (match == null) { 
            match = new MatchDB
            {
                GameID = dto.GameID,
                QueueID = dto.QueueID,
                GameType = dto.GameType,
                GameDuration = dto.GameDuration,
                GameMode = dto.GameMode,
                PlatformID = dto.PlatformID,
                SeasonID = dto.SeasonID,
                MapID = dto.MapID,
                ParticipantIdentities = dto.ParticipantIdentities
                                        .Select(p => new ParticipantIdentityDB { 
                                            Player = new PlayerDB
                                            {
                                                ProfileIcon = p.Player.ProfileIcon,
                                                AccountID = p.Player.AccountID,
                                                MatchHistoryURI = p.Player.MatchHistoryURI,
                                                CurrentAccountID = p.Player.CurrentAccountID,
                                                CurrentPlatformID = p.Player.CurrentPlatformID,
                                                SummonerName = p.Player.SummonerName,
                                                PlatformID = p.Player.PlatformID
                                            }

                                        }).ToList(),
                Teams = new List<TeamStatsDB>(),
                Participants = new List<ParticipantDB>()
            };
                context.Matches.Add(match);
            }
            
            context.SaveChanges();
            return match;
        }
    }
}
