using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.CompteViewModels;

namespace BudGET.MobileApp.Contracts;

public interface ICompteDataService
{
    Task<List<CompteListViewModel>> GetAllComptes();
    Task<CompteViewModel> GetCompteById(Guid id);
    Task<ApiResponse<CreateCompteDto>> CreateCompte(CompteViewModel CompteViewModel);
    Task<ApiResponse<Guid>> UpdateCompte(CompteViewModel budgetDetailViewModel);
    Task<ApiResponse<Guid>> DeleteCompte(Guid id);
}
