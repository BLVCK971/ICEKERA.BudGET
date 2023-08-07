using BudGET.Application.Responses;

namespace BudGET.Application.Features.Objectifs.Commands.CreateObjectif
{
    public class CreateObjectifCommandResponse : BaseResponse
    {
        public CreateObjectifCommandResponse() : base()
        {

        }

        public CreateObjectifDto Objectif { get; set; } = default!;
    }
}

