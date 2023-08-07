using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense
{
    public class CreateDepenseCommandHandler : IRequestHandler<CreateDepenseCommand, CreateDepenseCommandResponse>
    {
        private readonly IAsyncRepository<Depense> _serviceRepository;
        private readonly IMapper _mapper;

        public CreateDepenseCommandHandler(IMapper mapper, IAsyncRepository<Depense> serviceRepository)
        {
            _mapper = mapper;
            _serviceRepository = serviceRepository;
        }

        public async Task<CreateDepenseCommandResponse> Handle(CreateDepenseCommand request, CancellationToken cancellationToken)
        {
            var createDepenseCommandResponse = new CreateDepenseCommandResponse();

            var validator = new CreateDepenseCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                createDepenseCommandResponse.Success = false;
                createDepenseCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createDepenseCommandResponse.ValidationErrors.Add(error.ErrorMessage);
                }
            }
            if (createDepenseCommandResponse.Success)
            {
                var service = new Depense() { Nom = request.Nom, Date = request.Date, Valeur = request.Valeur, Prevu = request.Prevu };
                service = await _serviceRepository.AddAsync(service);
                createDepenseCommandResponse.Depense = _mapper.Map<CreateDepenseDto>(service);
            }

            return createDepenseCommandResponse;
        }
    }
}

