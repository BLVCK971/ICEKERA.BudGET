using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.DeleteCompte
{
    public class DeleteCompteCommandHandler : IRequestHandler<DeleteCompteCommand>
    {
        private readonly IAsyncRepository<Compte> _serviceRepository;
        private readonly IMapper _mapper;

        public DeleteCompteCommandHandler(IMapper mapper, IAsyncRepository<Compte> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<Unit> Handle(DeleteCompteCommand request, CancellationToken cancellationToken)
        {
            var serviceToDelete = await _serviceRepository.GetByIdAsync(request.CompteId);

            if (serviceToDelete == null)
            {
                throw new NotFoundException(nameof(Compte), request.CompteId);
            }

            await _serviceRepository.DeleteAsync(serviceToDelete);

            return Unit.Value;
        }
    }
}

