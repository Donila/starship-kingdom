using NUnit.Framework;
using StarshipKingdom.DataAccess.Repositories;
using StarshipKingdom.Domain.Models;
using StarshipKingdom.Services;

namespace StarshipKingdom.DataAccess.Tests
{
    [TestFixture]
    public class UserRepositoryTest
    {
        [Test]
        public void InsertUser_ReturnsIdentity()
        {
            var repository = new UserRepository(new ApplicationSettingsReader());

            var result = repository.Insert(new User {Name = "InsertTest", Email = "test@test.com", Password = "asd"});

            Assert.That(result > 0);
        }
    }
}
