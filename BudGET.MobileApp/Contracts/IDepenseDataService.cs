using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.DepenseViewModels;

namespace BudGET.MobileApp.Contracts;

public interface IDepenseDataService
{
    Task<List<DepenseListViewModel>> GetAllDepenses();
    Task<DepenseViewModel> GetDepenseById(Guid id);
    Task<ApiResponse<CreateDepenseDto>> CreateDepense(DepenseViewModel DepenseViewModel);
    Task<ApiResponse<Guid>> UpdateDepense(DepenseViewModel budgetDetailViewModel);
    Task<ApiResponse<Guid>> DeleteDepense(Guid id);
}
