using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommandHandler : IRequestHandler<CreateSalaireCommand, CreateSalaireCommandResponse>
    {
        private readonly IAsyncRepository<Salaire> _salaireRepository;
        private readonly IAsyncRepository<Compte> _compteRepository;
        private readonly IMapper _mapper;

        public CreateSalaireCommandHandler(IMapper mapper, IAsyncRepository<Salaire> salaireRepository, IAsyncRepository<Compte> compteRepository)
        {
            _mapper = mapper;
            _salaireRepository = salaireRepository;
            _compteRepository = compteRepository;
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
                var salaire = new Salaire() { Nom = request.Nom, Valeur = request.Valeur, CompteId = request.CompteId };
                salaire = await _salaireRepository.AddAsync(salaire);
                createSalaireCommandResponse.Salaire = _mapper.Map<CreateSalaireDto>(salaire);
            }

            return createSalaireCommandResponse;
        }
    }
}

