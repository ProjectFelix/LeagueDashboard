using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeagueDashboard.Models.DB
{
    public class ParticipantIdentityDB
    {
        public int ParticipantIdentityDBID { get; set; }
        public int PlayerDBID { get; set; }
        public int Index { get; set; }

        public PlayerDB Player { get; set; }
    }
}
