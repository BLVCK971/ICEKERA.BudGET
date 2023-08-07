using BudGET.Application.Responses;

namespace BudGET.Application.Features.Depenses.Commands.CreateDepense
{
    public class CreateDepenseCommandResponse : BaseResponse
    {
        public CreateDepenseCommandResponse() : base()
        {

        }

        public CreateDepenseDto Depense { get; set; } = default!;
    }
}

