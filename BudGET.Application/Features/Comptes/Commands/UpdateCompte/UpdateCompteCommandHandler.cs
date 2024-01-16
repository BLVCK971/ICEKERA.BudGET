using AutoMapper;
using BudGET.Application.Contracts.Persistence;
using BudGET.Application.Exceptions;
using BudGET.Domain.Entities;
using MediatR;

namespace BudGET.Application.Features.Comptes.Commands.UpdateCompte
{
    public class UpdateCompteCommandHandler : IRequestHandler<UpdateCompteCommand>
    {
        private readonly IAsyncRepository<Compte> _eventRepository;
        private readonly IMapper _mapper;

        public UpdateCompteCommandHandler(IMapper mapper, IAsyncRepository<Compte> serviceRepository)
        {
            _mapper = mapper;
            _eventRepository = serviceRepository;
        }

        public async Task Handle(UpdateCompteCommand request, CancellationToken cancellationToken)
        {

            var serviceToUpdate = await _eventRepository.GetByIdAsync(request.Id);

            if (serviceToUpdate == null)
            {
                throw new NotFoundException(nameof(Compte), request.Id);
            }

            var validator = new UpdateCompteCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
                throw new ValidationException(validationResult);

            _mapper.Map(request, serviceToUpdate, typeof(UpdateCompteCommand), typeof(Compte));

            await _eventRepository.UpdateAsync(serviceToUpdate);
        }
    }
}

