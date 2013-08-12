using NUnit.Framework;
using StarshipKingdom.DataAccess.Repositories;
using StarshipKingdom.Services;

namespace StarshipKingdom.DataAccess.Tests
{
    [TestFixture]
    public class RepositoryTests
    {
        [Test]
        public void GetUserById_Returns_UserModel()
        {
            var repository = new UserRepository(new ApplicationSettingsReader());

            var user = repository.Get(1);

            Assert.That(user.Name == "Test");
        }
    }
}
