using StarshipKingdom.Domain.Models.MatchMaking;

namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class Move
    {
        public int Id { get; set; }

        public int MoveNumber { get; set; }

        public int GivenDamage { get; set; }

        public virtual Step AttackerStep { get; set; }

        public virtual Step DefenderStep { get; set; }

        public virtual Match Match { get; set; }
    }
}
