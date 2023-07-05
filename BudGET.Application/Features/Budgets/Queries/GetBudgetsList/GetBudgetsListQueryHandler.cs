using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Budgets.Queries.GetBudgetsList
{
    public class GetBudgetsListQueryHandler : IRequestHandler<GetBudgetsListQuery, List<BudgetListVm>>
    {
        private readonly IAsyncRepository<Budget> _serviceRepository;
        private readonly IMapper _mapper;

        public GetBudgetsListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Budget> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<List<BudgetListVm>> Handle(GetBudgetsListQuery request, CancellationToken cancellationToken)
        {

            var allBudgets = (await _serviceRepository.ListAllAsync());

            //foreach (var service in allBudgets)
            //{
            //    service.Company = allCompanies.FirstOrDefault(c => c.CompanyId == service.CompanyId);
            //}
            return _mapper.Map<List<BudgetListVm>>(allBudgets);
        }
    }
}

