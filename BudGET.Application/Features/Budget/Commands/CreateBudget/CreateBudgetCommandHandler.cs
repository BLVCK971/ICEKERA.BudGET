using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Commands.CreateBudget
{
    public class CreateBudgetCommandHandler : IRequestHandler<CreateBudgetCommand, CreateBudgetCommandResponse>
    {
        private readonly IAsyncRepository<Budget> _serviceRepository;
        private readonly IMapper _mapper;

        public CreateBudgetCommandHandler(IMapper mapper, IAsyncRepository<Budget> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
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
                var service = new Budget() { Name = request.Name, CompanyId = request.CompanyId};
                service = await _serviceRepository.AddAsync(service);
                createBudgetCommandResponse.Budget = _mapper.Map<CreateBudgetDto>(service);
            }

            return createBudgetCommandResponse;
        }
    }
}

