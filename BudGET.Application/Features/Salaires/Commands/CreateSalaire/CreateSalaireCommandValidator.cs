using FluentValidation;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommandValidator : AbstractValidator<CreateSalaireCommand>
    {
        public CreateSalaireCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas excéder 10 caratères.");
        }
    }
}

