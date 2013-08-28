using System.ComponentModel.DataAnnotations.Schema;

namespace StarshipKingdom.Domain.Models.Ships
{
    public class Weaporn : BaseModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Damage { get; set; }

        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }
    }
}
