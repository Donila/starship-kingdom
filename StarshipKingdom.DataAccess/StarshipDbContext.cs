using System.Data.Entity;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Domain.Models.BattleMechanic;
using StarshipKingdom.Domain.Models.MatchMaking;
using StarshipKingdom.Domain.Models.Ships;

namespace StarshipKingdom.DataAccess
{
    public class StarshipDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Move> Moves { get; set; }

        public DbSet<Step> Steps { get; set; }

        public DbSet<Ship> Ships { get; set; }

        public DbSet<Match> Matches { get; set; }

        public DbSet<ShipBodyPart> ShipBodyParts { get; set; }

        public DbSet<Weaporn> Weaporns { get; set; }
    }
}
