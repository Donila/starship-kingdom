using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models.Ships
{
    public class Ship : BaseModel
    {
        public string Name { get; set; }

        public int Experience { get; set; }

        public int MaxHp { get; set; }

        public int CurrentHp { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int Mobility { get; set; }

        public int Accuracy { get; set; }

        public virtual IEnumerable<ShipBodyPart> Body { get; set; }
    }
}
