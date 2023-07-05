using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Depenses.Queries.GetDepensesList
{
    public class GetDepensesListQueryHandler : IRequestHandler<GetDepensesListQuery, List<DepenseListVm>>
    {
        private readonly IAsyncRepository<Depense> _serviceRepository;
        private readonly IMapper _mapper;

        public GetDepensesListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Depense> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<List<DepenseListVm>> Handle(GetDepensesListQuery request, CancellationToken cancellationToken)
        {

            var allDepenses = (await _serviceRepository.ListAllAsync());

            return _mapper.Map<List<DepenseListVm>>(allDepenses);
        }
    }
}

