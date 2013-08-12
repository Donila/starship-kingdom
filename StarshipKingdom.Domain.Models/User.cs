using System.Collections.Generic;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.Domain.Models
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public virtual IEnumerable<Ship> Ships { get; set; }
    }
}
