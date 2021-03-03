using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Entity.Models
{
    public partial class Team
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Match> MatchTeam1Navigations { get; set; }
        public virtual ICollection<Match> MatchTeam2Navigations { get; set; }
    }
}
