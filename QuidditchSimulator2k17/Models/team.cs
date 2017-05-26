using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchSimulator2k17.Models
{
    public class team
    {
        int team_id { get; set; }
        String name { get; set; }
        String school { get; set; }
        String captain { get; set;  }
        int region_id { get; set; }
        int playercount { get; set; }

    }
}