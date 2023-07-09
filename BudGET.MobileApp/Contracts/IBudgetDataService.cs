using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels;

namespace BudGET.MobileApp.Contracts
{
    public interface IBudgetDataService
    {
        Task<List<BudgetListViewModel>> GetAllBudgets();
        //Task<BudgetDetailViewModel> GetBudgetById(Guid id);
        Task<ApiResponse<CreateBudgetDto>> CreateBudget(BudgetViewModel BudgetViewModel);
        Task<ApiResponse<Guid>> UpdateBudget(BudgetDetailViewModel budgetDetailViewModel);
        Task<ApiResponse<Guid>> DeleteBudget(Guid id);
    }
}
