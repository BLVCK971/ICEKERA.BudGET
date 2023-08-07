using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Salaires.Queries.GetSalaireDetail
{
    public class GetSalaireDetailQueryHandler : IRequestHandler<GetSalaireDetailQuery, SalaireDetailVm>
    {
        private readonly IAsyncRepository<Salaire> _serviceRepository;
        private readonly IMapper _mapper;

        public GetSalaireDetailQueryHandler(IMapper mapper, IAsyncRepository<Salaire> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<SalaireDetailVm> Handle(GetSalaireDetailQuery request, CancellationToken cancellationToken)
        {
            var @service = await _serviceRepository.GetByIdAsync(request.Id);
            var serviceDetailDto = _mapper.Map<SalaireDetailVm>(@service);

            return serviceDetailDto;
        }
    }
}


