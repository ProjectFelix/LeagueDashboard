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
            context.MatchesDB.Add(match);
            
            
            context.SaveChanges();
            return match;
        }

        public static MatchDB ConvertMatchDTOToDBv2(this MatchDTO dto, ApplicationDbContext context)
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
                Teams = dto.Teams.Select(t => new TeamStatsDB
                {
                    GameID = dto.GameID,
                    TowerKills = t.TowerKills,
                    RiftHeraldKills = t.RiftHeraldKills,
                    FirstBlood = t.FirstBlood,
                    InhibitorKills = t.InhibitorKills,
                    DragonKills = t.DragonKills,
                    BaronKills = t.BaronKills,
                    TeamID = t.TeamID,
                    Win = t.Win
                }).ToList(),
            };
            for (int i = 0; i < 10; i++)
            {
                PlayerInfoDB player = new PlayerInfoDB
                {
                    GameID = dto.GameID,
                    ProfileIcon = dto.ParticipantIdentities[i].Player.ProfileIcon,
                    MatchHistoryURI = dto.ParticipantIdentities[i].Player.MatchHistoryURI,
                    SummonerName = dto.ParticipantIdentities[i].Player.SummonerName,
                    SummonerID = dto.ParticipantIdentities[i].Player.SummonerID,
                    PlatformID = dto.ParticipantIdentities[i].Player.PlatformID,
                    ParticipantID = dto.Participants[i].ParticipantID,
                    ChampionID = dto.Participants[i].ChampionID,
                    TeamID = dto.Participants[i].TeamID,
                    Spell1ID = dto.Participants[i].Spell1ID,
                    Spell2ID = dto.Participants[i].Spell2ID,
                    HighestAchievedSeasonTier = dto.Participants[i].HighestAchievedSeasonTier,
                    GoldEarned = dto.Participants[i].Stats.GoldEarned,
                    TotalPlayerScore = dto.Participants[i].Stats.TotalPlayerScore,
                    ChampLevel = dto.Participants[i].Stats.ChampLevel,
                    Deaths = dto.Participants[i].Stats.Deaths,
                    TotalScoreRank = dto.Participants[i].Stats.TotalScoreRank,
                    WardsPlaced = dto.Participants[i].Stats.WardsPlaced,
                    TotalDamageDealt = dto.Participants[i].Stats.TotalDamageDealt,
                    LargestKillingSpree = dto.Participants[i].Stats.LargestKillingSpree,
                    TotalDamageDealtToChampions = dto.Participants[i].Stats.TotalDamageDealtToChampions,
                    TotalMinionsKilled = dto.Participants[i].Stats.TotalMinionsKilled,
                    ObjectivePlayerScore = dto.Participants[i].Stats.ObjectivePlayerScore,
                    Kills = dto.Participants[i].Stats.Kills,
                    CombatPlayerScore = dto.Participants[i].Stats.CombatPlayerScore,
                    Assists = dto.Participants[i].Stats.Assists,
                    Win = dto.Participants[i].Stats.Win,
                    VisionScore = dto.Participants[i].Stats.VisionScore,
                    FirstBloodKill = dto.Participants[i].Stats.FirstBloodKill
                };
                match.PlayerInfos.Add(player);
                
            }
            context.MatchesDB.Add(match);


            context.SaveChanges();
            return match;
        }
    }
}
