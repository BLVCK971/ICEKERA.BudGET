using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommandHandler : IRequestHandler<CreateObjectifCommand, CreateObjectifCommandResponse>
    {
        private readonly IAsyncRepository<Objectif> _serviceRepository;
        private readonly IMapper _mapper;

        public CreateObjectifCommandHandler(IMapper mapper, IAsyncRepository<Objectif> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<CreateObjectifCommandResponse> Handle(CreateObjectifCommand request, CancellationToken cancellationToken)
        {
            var createObjectifCommandResponse = new CreateObjectifCommandResponse();

            var validator = new CreateObjectifCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createObjectifCommandResponse.Success = false;
                createObjectifCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createObjectifCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createObjectifCommandResponse.Success)
            {
                var service = new Objectif() { Nom = request.Nom, Valeur = request.Valeur };
                service = await _serviceRepository.AddAsync(service);
                createObjectifCommandResponse.Objectif = _mapper.Map<CreateObjectifDto>(service);
            }

            return createObjectifCommandResponse;
        }
    }
}

