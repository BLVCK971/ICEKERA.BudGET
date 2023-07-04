using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommandHandler : IRequestHandler<CreateSalaireCommand, CreateSalaireCommandResponse>
    {
        private readonly IAsyncRepository<Salaire> _serviceRepository;
        private readonly IMapper _mapper;

        public CreateSalaireCommandHandler(IMapper mapper, IAsyncRepository<Salaire> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<CreateSalaireCommandResponse> Handle(CreateSalaireCommand request, CancellationToken cancellationToken)
        {
            var createSalaireCommandResponse = new CreateSalaireCommandResponse();

            var validator = new CreateSalaireCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createSalaireCommandResponse.Success = false;
                createSalaireCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createSalaireCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createSalaireCommandResponse.Success)
            {
                var service = new Salaire() { Name = request.Name, CompanyId = request.CompanyId};
                service = await _serviceRepository.AddAsync(service);
                createSalaireCommandResponse.Salaire = _mapper.Map<CreateSalaireDto>(service);
            }

            return createSalaireCommandResponse;
        }
    }
}

