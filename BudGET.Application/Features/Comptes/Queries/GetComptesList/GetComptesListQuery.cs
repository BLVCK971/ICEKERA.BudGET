using MediatR;

namespace BudGET.Application.Features.Comptes.Queries.GetComptesList
{
    public class GetComptesListQuery : IRequest<List<CompteListVm>>
    {
    }
}

