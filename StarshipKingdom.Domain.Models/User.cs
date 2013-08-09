using System.Collections.Generic;

namespace StarshipKingdom.Domain.Models
{
    public class User
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public virtual IEnumerable<Ships.Ship> Ships { get; set; }
    }
}
