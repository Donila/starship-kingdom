using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class Step
    {
        public long Id { get; set; }

        public byte HitCode { get; set; }

        public int MoveId { get; set; }
        public virtual Move Move { get; set; }

        public int ShipId { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
