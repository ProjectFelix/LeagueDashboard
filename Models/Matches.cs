using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models
{
    public class Matches
    {
        public string NA1 { get; set; }
        public string GameID { get; set; }

        public int Champion { get; set; }
        public int Queue { get; set; }
        public int Season { get; set; }
        public long Timestamp { get; set; }
        public string Role { get; set; }
        public string Lane { get; set; }
    }
}
