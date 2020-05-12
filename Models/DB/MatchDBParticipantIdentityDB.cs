using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DB
{
    public class MatchDBParticipantIdentityDB
    {
        public int MatchDBParticipantIdentityDBID { get; set; }
        public int MatchDBID { get; set; }
        public int ParticipantIdentityDBID { get; set; }
    }
}
