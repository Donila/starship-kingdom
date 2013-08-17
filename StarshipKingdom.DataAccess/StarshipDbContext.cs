using System.Data.Entity;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Domain.Models.BattleMechanic;

namespace StarshipKingdom.DataAccess
{
    public class StarshipDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Move> Moves { get; set; }

        public DbSet<Step> Steps { get; set; }
    }
}
