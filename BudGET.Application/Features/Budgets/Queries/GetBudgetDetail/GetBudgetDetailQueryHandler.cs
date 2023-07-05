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
            private readonly IAsyncRepository<Budget> _serviceRepository;
            private readonly IMapper _mapper;

            public GetBudgetDetailQueryHandler(IMapper mapper, IAsyncRepository<Budget> serviceRepository)
            {
                _mapper = mapper;
                _serviceRepository = serviceRepository;
            }

            public async Task<BudgetDetailVm> Handle(GetBudgetDetailQuery request, CancellationToken cancellationToken)
            {
                var @service = await _serviceRepository.GetByIdAsync(request.BudgetId);
                var serviceDetailDto = _mapper.Map<BudgetDetailVm>(@service);

                return serviceDetailDto;
            }
    }
}


