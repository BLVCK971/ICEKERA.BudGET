using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommandHandler : IRequestHandler<CreateBudgetCommand, CreateBudgetCommandResponse>
    {
        private readonly IAsyncRepository<Budget> _budgetRepository;
        private readonly IMapper _mapper;

        public CreateBudgetCommandHandler(IMapper mapper, IAsyncRepository<Budget> budgetRepository)
        {
            _mapper = mapper;
            _budgetRepository = budgetRepository;
        }

        public async Task<CreateBudgetCommandResponse> Handle(CreateBudgetCommand request, CancellationToken cancellationToken)
        {
            var createBudgetCommandResponse = new CreateBudgetCommandResponse();

            var validator = new CreateBudgetCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createBudgetCommandResponse.Success = false;
                createBudgetCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createBudgetCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createBudgetCommandResponse.Success)
            {
                var budget = new Budget() { Id = Guid.NewGuid(), Nom = request.Nom, Montant = request.Montant, Exception = request.Exception };
                budget = await _budgetRepository.AddAsync(budget);
                createBudgetCommandResponse.Budget = _mapper.Map<CreateBudgetDto>(budget);
            }

            return createBudgetCommandResponse;
        }
    }
}

