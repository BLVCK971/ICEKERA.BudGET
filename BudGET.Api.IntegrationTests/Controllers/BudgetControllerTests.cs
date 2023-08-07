using BudGET.Api.IntegrationTests.Base;
using BudGET.Application.Features.Budgets.Queries.GetBudgetsList;
using System.Text.Json;

namespace BudGET.Api.IntegrationTests.Controllers
{

    public class BudgetControllerTests : IClassFixture<CustomWebApplicationFactory<Program>>
    {
        private readonly CustomWebApplicationFactory<Program> _factory;

        public BudgetControllerTests(CustomWebApplicationFactory<Program> factory)
        {
            _factory = factory;
        }

        [Fact]
        public async Task ReturnsSuccessResultOnGetAllBudgets()
        {
            var client = _factory.GetAnonymousClient();

            var response = await client.GetAsync("/api/budget/all");

            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<List<BudgetListVm>>(responseString);

            Assert.IsType<List<BudgetListVm>>(result);
            Assert.NotEmpty(result);
        }
    }
}
