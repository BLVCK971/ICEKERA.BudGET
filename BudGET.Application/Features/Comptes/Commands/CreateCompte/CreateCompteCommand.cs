using MediatR;

namespace BudGET.Application.Features.Comptes.Commands.CreateCompte
{
    public class CreateCompteCommand : IRequest<CreateCompteCommandResponse>
    {
        public string Intitule { get; set; } = string.Empty;
        public double Montant { get; set; } = double.MinValue;
        public bool EstCompteCourant { get; set; } = false;
    }
}

