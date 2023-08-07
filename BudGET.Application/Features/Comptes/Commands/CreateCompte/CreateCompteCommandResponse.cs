using BudGET.Application.Responses;

namespace BudGET.Application.Features.Comptes.Commands.CreateCompte
{
    public class CreateCompteCommandResponse : BaseResponse
    {
        public CreateCompteCommandResponse() : base()
        {

        }

        public CreateCompteDto Compte { get; set; } = default!;
    }
}

