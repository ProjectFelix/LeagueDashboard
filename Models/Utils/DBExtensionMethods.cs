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
            MatchDB match = new MatchDB
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
                Teams = dto.Teams.Select(t => new TeamStatsDB { 
                    TowerKills = t.TowerKills,
                    RiftHeraldKills = t.RiftHeraldKills,
                    FirstBlood = t.FirstBlood,
                    InhibitorKills = t.InhibitorKills,
                    DragonKills = t.DragonKills,
                    BaronKills = t.BaronKills,
                    TeamID = t.TeamID,
                    Win = t.Win
                }).ToList(),
                Participants = dto.Participants
                                    .Select(p => new ParticipantDB { 
                                        ParticipantID = p.ParticipantID,
                                        ChampionID = p.ChampionID,
                                        Stats = new ParticipantStatsDB
                                        {
                                            GoldEarned = p.Stats.GoldEarned,
                                            TotalPlayerScore = p.Stats.TotalPlayerScore,
                                            ChampLevel = p.Stats.ChampLevel,
                                            Deaths = p.Stats.Deaths,
                                            TotalScoreRank = p.Stats.TotalScoreRank,
                                            WardsPlaced = p.Stats.WardsPlaced,
                                            TotalDamageDealt = p.Stats.TotalDamageDealt,
                                            LargestKillingSpree = p.Stats.LargestKillingSpree,
                                            TotalDamageDealtToChampions = p.Stats.TotalDamageDealtToChampions,
                                            TotalMinionsKilled = p.Stats.TotalMinionsKilled,
                                            ObjectivePlayerScore = p.Stats.ObjectivePlayerScore,
                                            Kills = p.Stats.Kills,
                                            CombatPlayerScore = p.Stats.CombatPlayerScore,
                                            ParticipantID = p.Stats.ParticipantID,
                                            Assists = p.Stats.Assists,
                                            Win = p.Stats.Win,
                                            VisionScore = p.Stats.VisionScore,
                                            FirstBloodKill = p.Stats.FirstBloodKill
                                        },
                                        TeamID = p.TeamID,
                                        Spell1ID = p.Spell1ID,
                                        Spell2ID = p.Spell2ID,
                                        HighestAchievedSeasonTier = p.HighestAchievedSeasonTier
                                    }).ToList()
            };
            context.Matches.Add(match);
            
            
            context.SaveChanges();
            return match;
        }
    }
}
