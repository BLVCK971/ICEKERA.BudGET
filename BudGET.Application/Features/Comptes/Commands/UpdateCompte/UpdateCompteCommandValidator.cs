using FluentValidation;

namespace BudGET.Application.Features.Comptes.Commands.UpdateCompte
{
    public class UpdateCompteCommandValidator : AbstractValidator<UpdateCompteCommand>
    {
        public UpdateCompteCommandValidator()
        {
            RuleFor(p => p.Intitule)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas excéder 10 caratères.");
        }
    }
}

