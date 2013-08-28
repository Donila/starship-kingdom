using System.ComponentModel.DataAnnotations.Schema;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class Step
    {
        public long Id { get; set; }

        public byte HitCode { get; set; }

        public long MoveId { get; set; }

        [ForeignKey("MoveId")]
        public virtual Move Move { get; set; }

        public int ShipId { get; set; }

        [ForeignKey("ShipId")]
        public virtual Ship Ship { get; set; }
    }
}
