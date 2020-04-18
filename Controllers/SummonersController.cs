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

        public SummonersController(ApplicationDbContext context)
        {
            // Context only used for Identity right now. Eventually, will save summoner data
            // to DB after requests complete, so we can check that first before calling API.
            _context = context;
        }

        [HttpPost]
        public IActionResult Profile(string id)
        {
            // TODO: Add option to select region
            // Currently just using NA region, since that's what I am on.
            Summoner_V4 summonerv4 = new Summoner_V4("na1");
            // SummonerV4 handles summoner requests
            Summoner summoner = summonerv4.GetSummonerByName(id);
            
            // Just passing summoner to view. Eventually will make requests for more information,
            // and package into a viewmodel to pass.
            return View(summoner);
        }
    }
}
