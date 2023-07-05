using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail
{
    public class GetObjectifDetailQueryHandler : IRequestHandler<GetObjectifDetailQuery, ObjectifDetailVm>
    {
            private readonly IAsyncRepository<Objectif> _serviceRepository;
            private readonly IMapper _mapper;

            public GetObjectifDetailQueryHandler(IMapper mapper, IAsyncRepository<Objectif> serviceRepository)
            {
                _mapper = mapper;
                _serviceRepository = serviceRepository;
            }

            public async Task<ObjectifDetailVm> Handle(GetObjectifDetailQuery request, CancellationToken cancellationToken)
            {
                var @service = await _serviceRepository.GetByIdAsync(request.ObjectifId);
                var serviceDetailDto = _mapper.Map<ObjectifDetailVm>(@service);

                return serviceDetailDto;
            }
    }
}


