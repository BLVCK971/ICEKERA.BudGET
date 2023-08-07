using BudGET.Application.Responses;

namespace BudGET.Application.Features.Salaires.Commands.CreateSalaire
{
    public class CreateSalaireCommandResponse : BaseResponse
    {
        public CreateSalaireCommandResponse() : base()
        {

        }

        public CreateSalaireDto Salaire { get; set; } = default!;
    }
}

