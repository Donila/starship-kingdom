using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using StarshipKingdom.Domain.Models.BattleMechanic;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models.MatchMaking
{
    public class Match : BaseModel
    {
        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public int CreatorId { get; set; }

        [ForeignKey("CreatorId")]
        public User Creator { get; set; }
    }
}
