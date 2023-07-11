using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.BudgetViewModels;

namespace BudGET.MobileApp.Contracts;

public interface IBudgetDataService
{
    Task<List<BudgetListViewModel>> GetAllBudgets();
    Task<BudgetViewModel> GetBudgetById(Guid id);
    Task<ApiResponse<CreateBudgetDto>> CreateBudget(BudgetViewModel BudgetViewModel);
    Task<ApiResponse<Guid>> UpdateBudget(BudgetViewModel budgetDetailViewModel);
    Task<ApiResponse<Guid>> DeleteBudget(Guid id);
}
