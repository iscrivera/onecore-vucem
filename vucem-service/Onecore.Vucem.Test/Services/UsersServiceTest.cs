// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UsersServiceTest.cs" company="Onecore">
//   Onecore
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Onecore.Vucem.Test.Services
{
    using System.Linq;
    using Onecore.Vucem.Services.User;
    using Onecore.Vucem.Facade.Mapping;
    using Onecore.Vucem.Entities.Context;
    using Onecore.Vucem.DataAccess.DAO.User;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper;
    using NUnit.Framework;
    using System.Threading.Tasks;

    /// <summary>
    /// Class UsersServiceTest
    /// </summary>
    [TestFixture]
    public class UsersServiceTest : BaseTest
    {
        /// <summary>
        /// User Service Object
        /// </summary>
        private UsersService userServices;

        /// <summary>
        /// Setup the entire test the <see cref="Init" /> class.
        /// </summary>
        [OneTimeSetUp]
        public void Init()
        {
            var mapperConfiguration = new MapperConfiguration(cfg => cfg.AddProfile<AutoMapperProfile>());
            base.Mapper = mapperConfiguration.CreateMapper();

            var options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseInMemoryDatabase(databaseName: "Temporal")
                .Options;

            base.Context = new DatabaseContext(options);

            // Insert seed data into the database using one instance of the context
            this.Context.CatUser.AddRange(this.GetAllUsers());
            this.Context.SaveChanges();

            base.UsersDao = new UsersDao(this.Context);

            this.userServices = new UsersService(UsersDao);
        }

        /// <summary>
        /// Test Get All Users
        /// </summary>
        [Test]
        public async Task ValidateGetAllUsers()
        {
            var result = await this.userServices.GetAllUsersAsync();

            Assert.True(result != null);
            Assert.True(result.Count() >= 0);
        }

        /// <summary>
        /// Test Get User By Id
        /// </summary>
        [Test]
        public async Task ValidateSpecificUsers()
        {
            var result = await this.userServices.GetUserAsync(2);

            Assert.True(result != null);
            Assert.True(result.FirstName == "Jorge");
        }
    }
}
