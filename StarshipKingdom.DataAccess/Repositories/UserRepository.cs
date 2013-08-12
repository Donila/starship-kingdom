using System.Data.SqlClient;
using System.Linq;
using Dapper;
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
            using (var connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                var result = connection.Query<int>(
                    "insert into [dbo].[Users](Name, Email, Password) " +
                    "values (@Name, @Email, @Password);" +
                    " SELECT CAST(@@IDENTITY as int)", model).FirstOrDefault();

                return result;
            }
        }

        public override void Update(User model)
        {
            throw new System.NotImplementedException();
        }
    }
}
