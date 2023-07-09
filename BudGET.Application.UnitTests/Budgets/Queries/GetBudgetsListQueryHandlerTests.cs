using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Features.Budgets.Queries.GetBudgetsList;
using BudGET.Application.Profiles;
using BudGET.Application.UnitTests.Mocks;
using BudGET.Domain.Entities;
using Moq;
using Shouldly;

namespace BudGET.Application.UnitTests.Budgets.Queries
{
    public class GetBudgetsListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Budget>> _mockBudgetRepository;

        public GetBudgetsListQueryHandlerTests()
        {
            _mockBudgetRepository = RepositoryMocks.GetBudgetRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetBudgetListTest()
        {
            var handler = new GetBudgetsListQueryHandler(_mapper, _mockBudgetRepository.Object);

            var result = await handler.Handle(new GetBudgetsListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<BudgetListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
