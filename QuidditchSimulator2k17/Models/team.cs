using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchSimulator2k17.Models
{
    public class Team
    {
        public int team_id { get; set; }
        public string name { get; set; }
        public string school { get; set; }
        public string captain { get; set;  }
        public int region_id { get; set; }
        public int playercount { get; set; }

    }
}