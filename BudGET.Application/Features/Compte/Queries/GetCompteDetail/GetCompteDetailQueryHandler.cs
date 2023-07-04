using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Queries.GetCompteDetail
{
    public class GetCompteDetailQueryHandler : IRequestHandler<GetCompteDetailQuery, CompteDetailVm>
    {
            private readonly IAsyncRepository<Compte> _serviceRepository;
            private readonly IMapper _mapper;

            public GetCompteDetailQueryHandler(IMapper mapper, IAsyncRepository<Compte> serviceRepository)
            {
                _mapper = mapper;
                _serviceRepository = serviceRepository;
            }

            public async Task<CompteDetailVm> Handle(GetCompteDetailQuery request, CancellationToken cancellationToken)
            {
                var @service = await _serviceRepository.GetByIdAsync(request.CompteId);
                var serviceDetailDto = _mapper.Map<CompteDetailVm>(@service);

                return serviceDetailDto;
            }
    }
}


