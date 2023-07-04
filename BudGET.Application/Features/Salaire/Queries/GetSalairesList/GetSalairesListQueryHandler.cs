using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Salaires.Queries.GetSalairesList
{
    public class GetSalairesListQueryHandler : IRequestHandler<GetSalairesListQuery, List<SalaireListVm>>
    {
        private readonly IAsyncRepository<Salaire> _serviceRepository;
        private readonly IMapper _mapper;

        public GetSalairesListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Salaire> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<List<SalaireListVm>> Handle(GetSalairesListQuery request, CancellationToken cancellationToken)
        {

            var allSalaires = (await _serviceRepository.ListAllAsync());
            return _mapper.Map<List<SalaireListVm>>(allSalaires);
        }
    }
}

