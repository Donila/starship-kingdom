using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models.BattleMechanic
{
    public class GlobalMechanics
    {
        public IDictionary<int, int> ExpirienceTable { get; set; }

        public IDictionary<int, int> AttackPerLevelTable { get; set; }

        public IDictionary<int, int> DefencePerLevelTable { get; set; }

        public IDictionary<int, int> MobilityPerLevelTable { get; set; }

        public IDictionary<int, int> EvationPerLevelTable { get; set; }
    }
}
