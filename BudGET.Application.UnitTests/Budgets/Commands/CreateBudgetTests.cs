using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Features.Budgets.Commands.CreateBudget;
using BudGET.Application.Profiles;
using BudGET.Application.UnitTests.Mocks;
using BudGET.Domain.Entities;
using Moq;
using Shouldly;

namespace BudGET.Application.UnitTests.Categories.Commands
{
    public class CreateBudgetTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Budget>> _mockBudgetRepository;

        public CreateBudgetTests()
        {
            _mockBudgetRepository = RepositoryMocks.GetBudgetRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task Handle_ValidBudget_AddedToCategoriesRepo()
        {
            var handler = new CreateBudgetCommandHandler(_mapper, _mockBudgetRepository.Object);

            await handler.Handle(new CreateBudgetCommand() { Nom = "Test" }, CancellationToken.None);

            var allCategories = await _mockBudgetRepository.Object.ListAllAsync();
            allCategories.Count.ShouldBe(5);
        }
    }
}
