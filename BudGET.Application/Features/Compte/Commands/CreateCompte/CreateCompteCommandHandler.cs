using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Comptes.Commands.CreateCompte
{
    public class CreateCompteCommandHandler : IRequestHandler<CreateCompteCommand, CreateCompteCommandResponse>
    {
        private readonly IAsyncRepository<Compte> _serviceRepository;
        private readonly IMapper _mapper;

        public CreateCompteCommandHandler(IMapper mapper, IAsyncRepository<Compte> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<CreateCompteCommandResponse> Handle(CreateCompteCommand request, CancellationToken cancellationToken)
        {
            var createCompteCommandResponse = new CreateCompteCommandResponse();

            var validator = new CreateCompteCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createCompteCommandResponse.Success = false;
                createCompteCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createCompteCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createCompteCommandResponse.Success)
            {
                var service = new Compte() { Name = request.Name, CompanyId = request.CompanyId};
                service = await _serviceRepository.AddAsync(service);
                createCompteCommandResponse.Compte = _mapper.Map<CreateCompteDto>(service);
            }

            return createCompteCommandResponse;
        }
    }
}

