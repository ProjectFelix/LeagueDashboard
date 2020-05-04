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

        [HttpPost]
        public IActionResult Profile(string id)
        {
            // TODO: Add option to select region
            // Currently just using NA region, since that's what I am on.
            Summoner_V4 summonerv4 = new Summoner_V4("na1");
            Champion_Mastery_V4 championMastery = new Champion_Mastery_V4("na1");
            

            // Get summoner info
            Summoner summoner = summonerv4.GetSummonerByName(id);
            // Get list of masteries by summoner id
            List<ChampionMastery> masteries = championMastery.GetChampionMasteryById(summoner.Id);
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

            

            ViewModelProfile viewModel = new ViewModelProfile { Summoner = summoner, Masteries = masteries, MasteryResponse = _allChamps, Info = list };
            
            return View(viewModel);
        }
    }
}
