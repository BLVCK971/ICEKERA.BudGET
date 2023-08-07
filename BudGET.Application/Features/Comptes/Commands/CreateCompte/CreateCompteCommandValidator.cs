using FluentValidation;

namespace BudGET.Application.Features.Comptes.Commands.CreateCompte
{
    public class CreateCompteCommandValidator : AbstractValidator<CreateCompteCommand>
    {
        public CreateCompteCommandValidator()
        {
            RuleFor(p => p.Intitule)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas exc�der 10 carat�res.");
        }
    }
}

