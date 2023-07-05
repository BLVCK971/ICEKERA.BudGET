using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifsList
{
    public class GetObjectifsListQueryHandler : IRequestHandler<GetObjectifsListQuery, List<ObjectifListVm>>
    {
        private readonly IAsyncRepository<Objectif> _serviceRepository;
        private readonly IMapper _mapper;

        public GetObjectifsListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Objectif> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<List<ObjectifListVm>> Handle(GetObjectifsListQuery request, CancellationToken cancellationToken)
        {

            var allObjectifs = (await _serviceRepository.ListAllAsync());

            return _mapper.Map<List<ObjectifListVm>>(allObjectifs);
        }
    }
}

