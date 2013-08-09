using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models
{
    public class User
    {
        public string Name { get; set; }

        public virtual IEnumerable<Ship> Ships { get; set; }
    }
}
