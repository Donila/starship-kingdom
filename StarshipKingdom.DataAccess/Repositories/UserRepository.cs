using System.Data.SqlClient;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Services;

namespace StarshipKingdom.DataAccess.Repositories
{
    public interface IUserRepository
    {
    }

    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(IApplicationSettingsReader reader) : base(reader)
        {
        }

        public override int Insert(User model)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(User model)
        {
            throw new System.NotImplementedException();
        }
    }
}
