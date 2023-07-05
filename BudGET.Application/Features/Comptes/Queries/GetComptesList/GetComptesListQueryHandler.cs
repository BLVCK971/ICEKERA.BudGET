using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Comptes.Queries.GetComptesList
{
    public class GetComptesListQueryHandler : IRequestHandler<GetComptesListQuery, List<CompteListVm>>
    {
        private readonly IAsyncRepository<Compte> _serviceRepository;
        private readonly IMapper _mapper;

        public GetComptesListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Compte> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<List<CompteListVm>> Handle(GetComptesListQuery request, CancellationToken cancellationToken)
        {

            var allComptes = (await _serviceRepository.ListAllAsync());
            return _mapper.Map<List<CompteListVm>>(allComptes);
        }
    }
}

