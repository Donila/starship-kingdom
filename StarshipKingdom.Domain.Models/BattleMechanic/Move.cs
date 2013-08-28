using System.ComponentModel.DataAnnotations.Schema;
using StarshipKingdom.Domain.Models.MatchMaking;

namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class Move
    {
        public long Id { get; set; }

        public int MoveNumber { get; set; }

        public int GivenDamage { get; set; }

        [NotMapped]
        public virtual Step AttackerStep { get; set; }

        [NotMapped]
        public virtual Step DefenderStep { get; set; }

        public int MatchId { get; set; }

        [ForeignKey("MatchId")]
        public virtual Match Match { get; set; }
    }
}
