using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Depenses.Queries.GetDepenseDetail
{
    public class GetDepenseDetailQueryHandler : IRequestHandler<GetDepenseDetailQuery, DepenseDetailVm>
    {
            private readonly IAsyncRepository<Depense> _serviceRepository;
            private readonly IMapper _mapper;

            public GetDepenseDetailQueryHandler(IMapper mapper, IAsyncRepository<Depense> serviceRepository)
            {
                _mapper = mapper;
                _serviceRepository = serviceRepository;
            }

            public async Task<DepenseDetailVm> Handle(GetDepenseDetailQuery request, CancellationToken cancellationToken)
            {
                var @service = await _serviceRepository.GetByIdAsync(request.DepenseId);
                var serviceDetailDto = _mapper.Map<DepenseDetailVm>(@service);

                return serviceDetailDto;
            }
    }
}


