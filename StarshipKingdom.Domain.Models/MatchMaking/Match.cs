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

        public int CreatorId { get; set; }
        public User Creator { get; set; }

        public virtual ICollection<Ship> Ships { get; set; }

        public virtual ICollection<Move> Moves { get; set; }
    }
}
