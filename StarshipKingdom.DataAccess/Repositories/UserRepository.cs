using System.Data;
using System.Linq;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Services;
using StarshipKingdom.Services.Exceptions;

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

        public override User Get(int id)
        {
            using (var context = new StarshipDbContext())
            {
                var user = context.Users.SingleOrDefault(u => u.Id == id);

                if (user == null)
                {
                    throw new NotFoundException();
                }

                return user;
            }
        }

        public override int Insert(User model)
        {
            using (var context = new StarshipDbContext())
            {
                var user = context.Users.Attach(model);

                context.SaveChanges();

                return user.Id;
            }
        }

        public override void Update(User model)
        {
            using (var context = new StarshipDbContext())
            {
                context.Users.Attach(model);

                context.Entry(model).State = EntityState.Modified;

                context.SaveChanges();
            }
        }

        public override void Delete(User model)
        {
            using (var context = new StarshipDbContext())
            {
                context.Users.Remove(model);

                context.SaveChanges();
            }
        }
    }
}
