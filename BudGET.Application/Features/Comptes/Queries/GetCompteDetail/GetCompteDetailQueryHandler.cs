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
            private readonly IAsyncRepository<Compte> _compteRepository;
            private readonly IMapper _mapper;

            public GetCompteDetailQueryHandler(IMapper mapper, IAsyncRepository<Compte> compteRepository)
            {
                _mapper = mapper;
                _compteRepository = compteRepository;
            }

            public async Task<CompteDetailVm> Handle(GetCompteDetailQuery request, CancellationToken cancellationToken)
            {
                var @compte = await _compteRepository.GetByIdAsync(request.CompteId);
                var compteDetailDto = _mapper.Map<CompteDetailVm>(@compte);

                return compteDetailDto;
            }
    }
}


