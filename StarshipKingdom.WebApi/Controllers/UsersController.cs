using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;
using StarshipKingdom.DataAccess;
using StarshipKingdom.Domain.Models;

namespace StarshipKingdom.WebApi.Controllers
{
    public class UsersController : EntitySetController<User, int>
    {
        private readonly StarshipDbContext _context = new StarshipDbContext();

        [HttpGet]
        [Queryable]
        public override IQueryable<User> Get()
        {
            return _context.Users;
        }

        [HttpPost]
        public override HttpResponseMessage Post(User entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot add User. User is not defined.");
            }

            _context.Users.Add(entity);

            _context.SaveChanges();
        }

        protected override User GetEntityByKey(int key)
        {
            return _context.Users.FirstOrDefault(p => p.Id == key);
        }

        [HttpPut]
        public override HttpResponseMessage Put(int key, User update)
        {
            return base.Put(key, update);
        }

        [HttpDelete]
        public override void Delete(int key)
        {
            base.Delete(key);
        }
    }
}
