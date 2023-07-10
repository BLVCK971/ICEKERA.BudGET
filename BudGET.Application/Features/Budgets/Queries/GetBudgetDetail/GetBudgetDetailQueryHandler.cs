using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetDetail
{
    public class GetBudgetDetailQueryHandler : IRequestHandler<GetBudgetDetailQuery, BudgetDetailVm>
    {
            private readonly IAsyncRepository<Budget> _budgetRepository;
            private readonly IMapper _mapper;

            public GetBudgetDetailQueryHandler(IMapper mapper, IAsyncRepository<Budget> budgetRepository)
            {
                _mapper = mapper;
                _budgetRepository = budgetRepository;
            }

            public async Task<BudgetDetailVm> Handle(GetBudgetDetailQuery request, CancellationToken cancellationToken)
            {
                var @budget = await _budgetRepository.GetByIdAsync(request.Id);
                var budgetDetailDto = _mapper.Map<BudgetDetailVm>(@budget);

                return budgetDetailDto;
            }
    }
}


