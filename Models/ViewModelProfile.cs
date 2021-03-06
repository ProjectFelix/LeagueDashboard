﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class ViewModelProfile
    {
        public Summoner Summoner { get; set; }
        public List<ChampionMastery> Masteries { get; set; }
        public Dictionary<int,string> ChampionIDs { get; set; }

        public ChampionInfo Info { get; set; }

        public MatchesResponse Matchlist { get; set; }
    }
}
