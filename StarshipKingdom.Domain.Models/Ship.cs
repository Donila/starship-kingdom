﻿using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models
{
    public class Ship
    {
        public string Name { get; set; }

        public int Experience { get; set; }

        public virtual IEnumerable<ShipBodyPart> Body { get; set; }
    }
}