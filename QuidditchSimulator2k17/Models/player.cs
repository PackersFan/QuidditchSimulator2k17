using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuidditchSimulator2k17.Models
{
    public class Player
    {
        public int player_id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public int number { get; set; }
        public string position { get; set; }
        public int team_id { get; set; }
    }
}