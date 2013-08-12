using System;
using System.Collections.Generic;
using StarshipKingdom.Domain.Models.BattleMechanic;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models.MatchMaking
{
    public class Match : BaseModel
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public User Creator { get; set; }

        public virtual IEnumerable<Ship> Participants { get; set; }

        public virtual IEnumerable<Move> Moves { get; set; }
    }
}
