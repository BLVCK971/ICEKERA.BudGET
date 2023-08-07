using FluentValidation;

namespace BudGET.Application.Features.Budgets.Commands.UpdateBudget
{
    public class UpdateBudgetCommandValidator : AbstractValidator<UpdateBudgetCommand>
    {
        public UpdateBudgetCommandValidator()
        {
            RuleFor(p => p.Nom)
                .NotEmpty().WithMessage("{PropertyName} est requis.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} ne doit pas exc�der 10 carat�res.");
        }
    }
}

