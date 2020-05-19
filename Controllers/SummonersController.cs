using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyLeagueDashboard.Data;
using MyLeagueDashboard.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using MyLeagueDashboard.API;
using MyLeagueDashboard.Models.DTO;
using MyLeagueDashboard.Models.Utils;
using MyLeagueDashboard.Models.DB;
using System.Text.RegularExpressions;

namespace MyLeagueDashboard.Controllers
{
    public class SummonersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly MasteryResponse _allChamps;
        private Champion_Mastery_V4 _championMastery;

        public SummonersController(ApplicationDbContext context)
        {
            // Context only used for Identity right now. Eventually, will save summoner data
            // to DB after requests complete, so we can check that first before calling API.
            _context = context;
            _championMastery = new Champion_Mastery_V4("na1");
            _allChamps = _championMastery.GetAllChampions();
        }

        
        public IActionResult Profile(FindModel fm)
        {
            // TODO: Add option to select region
            // Currently just using NA region, since that's what I am on.
            
            Champion_Mastery_V4 championMastery = new Champion_Mastery_V4("na1");
            Match_V4 matchv4 = new Match_V4("na1");


            // Get summoner info
            Summoner summoner = _context.Summoners.Where(s => s.Name == fm.Name).SingleOrDefault();
            if (summoner == null) {
                Summoner_V4 summonerv4 = new Summoner_V4("na1");
                summoner = summonerv4.GetSummonerByName(fm.Name);
                summoner.Region = fm.Region;
                _context.Summoners.Add(summoner);
                _context.SaveChanges();
                summoner = _context.Summoners.Where(s => s.Name == fm.Name).SingleOrDefault();
            }
            // Get list of masteries by summoner id
            List<ChampionMastery> masteries = championMastery.GetChampionMasteryById(summoner.Id);
            // List will be top 3 champs by mastery
            ChampionInfo list = new ChampionInfo();
            // Get top 3 champs by mastery
            for (int i = 0; i < 3; i++)
            {
                foreach (KeyValuePair<string, Champion> champ in _allChamps.Data)
                {
                    if (champ.Value.Key == masteries[i].ChampionID.ToString())
                    {
                        champ.Value.Rank = i;
                        list.Champions.Add(champ.Key, champ.Value);
                        break;
                    }
                }
                
                
            }
            // Get matchlist by account id
            MatchesResponse matches = _context.MatchesResponses.Where(r => r.SummonerID == summoner.Id).FirstOrDefault();
            
            if (matches == null)
            {
                int k, d, a;
                k = d = a = 0;
                matches = matchv4.GetMatchesByAccountID(summoner.AccountId);
                matches.SummonerID = summoner.Id;
                foreach (Matches match in matches.Matches)
                {
                    MatchDB matchDB = _context.MatchesDB.Where(m => m.GameID == long.Parse(match.GameID)).FirstOrDefault();
                    if (matchDB == null) { 
                        MatchDTO matchDTO = matchv4.GetMatchByMatchID(match.GameID);
                        matchDB = matchDTO.ConvertMatchDTOToDBv2(_context);
                    } else
                    {
                        matchDB.PlayerInfos = _context.PlayerInfoDBs.Where(p => p.GameID == matchDB.GameID).OrderBy(p => p.ParticipantID).ToList();
                        matchDB.Teams = _context.TeamStatsDBs.Where(t => t.GameID == matchDB.GameID).OrderBy(t => t.TeamID).ToList();
                    }

                    match.MatchDB = matchDB;
                    foreach (PlayerInfoDB p in matchDB.PlayerInfos)
                    {
                        if (p.SummonerID == summoner.Id)
                        {
                            k += p.Kills;
                            d += p.Deaths;
                            a += p.Assists;
                        }
                    }
                }
                summoner.KDA = ((k + a) / (float)d);
                _context.Summoners.Update(summoner);
                _context.MatchesResponses.Add(matches);
                _context.SaveChanges();
            } else
            {
                matches.Matches = _context.Matches.Where(m => m.MatchesResponseID == matches.MatchesResponseID).OrderByDescending(m => m.Timestamp).ToList();
                foreach (Matches match in matches.Matches)
                {
                    
                    MatchDB matchDB = _context.MatchesDB.Where(m => m.GameID == long.Parse(match.GameID)).FirstOrDefault();
                    matchDB.Teams = _context.TeamStatsDBs.Where(t => t.GameID == matchDB.GameID).OrderBy(t => t.TeamID).ToList();
                    matchDB.PlayerInfos = _context.PlayerInfoDBs.Where(p => p.GameID == matchDB.GameID).OrderBy(p => p.ParticipantID).ToList();
                    
                    match.MatchDB = matchDB;
                }
            }

            Dictionary<int, string> championIDs = new Dictionary<int, string>();
            foreach (Champion c in _allChamps.Data.Values)
            {
                championIDs.Add(int.Parse(c.Key), c.Id);
            }
            ViewModelProfile viewModel = new ViewModelProfile { Summoner = summoner,
                                                                Masteries = masteries,
                                                                ChampionIDs = championIDs,
                                                                Info = list,
                                                                Matchlist = matches
                                                              };
            
            return View(viewModel);
        }
    }
}
