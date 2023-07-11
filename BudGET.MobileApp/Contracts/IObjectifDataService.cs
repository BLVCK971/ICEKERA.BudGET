using BudGET.MobileApp.Services;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.ObjectifViewModels;

namespace BudGET.MobileApp.Contracts
{
    public interface IObjectifDataService
    {
        Task<List<ObjectifListViewModel>> GetAllObjectifs();
        Task<ObjectifViewModel> GetObjectifById(Guid id);
        Task<ApiResponse<CreateObjectifDto>> CreateObjectif(ObjectifViewModel ObjectifViewModel);
        Task<ApiResponse<Guid>> UpdateObjectif(ObjectifViewModel budgetDetailViewModel);
        Task<ApiResponse<Guid>> DeleteObjectif(Guid id);
    }
}
