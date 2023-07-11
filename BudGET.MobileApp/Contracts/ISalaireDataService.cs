using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.SalaireViewModels;

namespace BudGET.MobileApp.Contracts
{
    public interface ISalaireDataService
    {
        Task<List<SalaireListViewModel>> GetAllSalaires();
        Task<SalaireViewModel> GetSalaireById(Guid id);
        Task<ApiResponse<CreateSalaireDto>> CreateSalaire(SalaireViewModel SalaireViewModel);
        Task<ApiResponse<Guid>> UpdateSalaire(SalaireViewModel budgetDetailViewModel);
        Task<ApiResponse<Guid>> DeleteSalaire(Guid id);
    }
}
