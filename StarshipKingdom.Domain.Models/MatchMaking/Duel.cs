using System.Collections.Generic;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models.MatchMaking
{
    public sealed class Duel : Match
    {
        public Duel()
        {
            Participants = new List<Ship>(2);
        }

        public User Player { get; set; }
    }
}
