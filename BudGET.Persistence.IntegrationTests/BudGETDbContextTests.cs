using BudGET.Application.Contracts;
using BudGET.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;

namespace BudGET.Persistence.IntegrationTests
{
    public class BudGETDbContextTests
    {
        private readonly BudGETDbContext _budGETDbContext;
        //private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        //private readonly string _loggedInUserId;

        public BudGETDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<BudGETDbContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;

            //_loggedInUserId = "00000000-0000-0000-0000-000000000000";
            //_loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            //_loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _budGETDbContext = new BudGETDbContext(dbContextOptions);
        }

        [Fact]
        public async void Save_NomProperty()
        {
            var bg = new Budget() {Id = Guid.NewGuid(), Nom = "Test budget" };

            _budGETDbContext.Budgets.Add(bg);
            await _budGETDbContext.SaveChangesAsync();

            bg.Nom.ShouldBe("Test budget");
        }
    }
}
