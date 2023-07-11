using AutoMapper;
using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.BudgetViewModels;

namespace BudGET.MobileApp.Services;

public class BudgetDataService : BaseDataService, IBudgetDataService
{

    private readonly IMapper _mapper;

    public BudgetDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
    {
        _mapper = mapper;
    }

    public async Task<List<BudgetListViewModel>> GetAllBudgets()
    {
        var allBudgets = await _client.GetAllBudgetsAsync();
        var mappedBudgets = _mapper.Map<ICollection<BudgetListViewModel>>(allBudgets);
        return mappedBudgets.ToList();
    }

    public async Task<BudgetViewModel> GetBudgetById(Guid id)
    {
        var selectedBudget = await _client.GetBudgetByIdAsync(id);
        var mappedBudget = _mapper.Map<BudgetViewModel>(selectedBudget);
        return mappedBudget;
    }

    public async Task<ApiResponse<CreateBudgetDto>> CreateBudget(BudgetViewModel BudgetViewModel)
    {
        try
        {
            ApiResponse<CreateBudgetDto> apiResponse = new ApiResponse<CreateBudgetDto>();
            CreateBudgetCommand createBudgetCommand = _mapper.Map<CreateBudgetCommand>(BudgetViewModel);
            var createBudgetCommandResponse = await _client.AddBudgetAsync(createBudgetCommand);
            if (createBudgetCommandResponse.Success)
            {
                apiResponse.Data = _mapper.Map<CreateBudgetDto>(createBudgetCommandResponse.Budget);
                apiResponse.Success = true;
            }
            else
            {
                apiResponse.Data = null;
                foreach (var error in createBudgetCommandResponse.ValidationErrors)
                {
                    apiResponse.ValidationErrors += error + Environment.NewLine;
                }
            }
            return apiResponse;
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<CreateBudgetDto>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> UpdateBudget(BudgetViewModel BudgetDetailViewModel)
    {
        try
        {
            UpdateBudgetCommand updateBudgetCommand = _mapper.Map<UpdateBudgetCommand>(BudgetDetailViewModel);
            await _client.UpdateBudgetAsync(updateBudgetCommand);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> DeleteBudget(Guid id)
    {
        try
        {
            await _client.DeleteBudgetAsync(id);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }
}
