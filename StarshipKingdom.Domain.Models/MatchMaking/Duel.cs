using System.Collections.Generic;

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
