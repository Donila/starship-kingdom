using System.ComponentModel.DataAnnotations;

namespace StarshipKingdom.Domain.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int Id { get; set; }
    }
}
