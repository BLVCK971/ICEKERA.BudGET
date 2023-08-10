using AutoMapper;
using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.DepenseViewModels;

namespace BudGET.MobileApp.Services;

public class DepenseDataService : BaseDataService, IDepenseDataService
{

    private readonly IMapper _mapper;

    public DepenseDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
    {
        _mapper = mapper;
    }

    public async Task<List<DepenseListViewModel>> GetAllDepenses()
    {
        var allDepenses = await _client.GetAllDepensesAsync();
        var mappedDepenses = _mapper.Map<List<DepenseListViewModel>>(allDepenses);
        return mappedDepenses.ToList();
    }

    public async Task<DepenseViewModel> GetDepenseById(Guid id)
    {
        var selectedDepense = await _client.GetDepenseByIdAsync(id);
        var mappedDepense = _mapper.Map<DepenseViewModel>(selectedDepense);
        return mappedDepense;
    }

    public async Task<ApiResponse<CreateDepenseDto>> CreateDepense(DepenseViewModel DepenseViewModel)
    {
        try
        {
            ApiResponse<CreateDepenseDto> apiResponse = new ApiResponse<CreateDepenseDto>();
            CreateDepenseCommand createDepenseCommand = _mapper.Map<CreateDepenseCommand>(DepenseViewModel);
            var createDepenseCommandResponse = await _client.AddDepenseAsync(createDepenseCommand);
            if (createDepenseCommandResponse.Success)
            {
                apiResponse.Data = _mapper.Map<CreateDepenseDto>(createDepenseCommandResponse.Depense);
                apiResponse.Success = true;
            }
            else
            {
                apiResponse.Data = null;
                foreach (var error in createDepenseCommandResponse.ValidationErrors)
                {
                    apiResponse.ValidationErrors += error + Environment.NewLine;
                }
            }
            return apiResponse;
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<CreateDepenseDto>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> UpdateDepense(DepenseViewModel DepenseDetailViewModel)
    {
        try
        {
            UpdateDepenseCommand updateDepenseCommand = _mapper.Map<UpdateDepenseCommand>(DepenseDetailViewModel);
            await _client.UpdateDepenseAsync(updateDepenseCommand);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> DeleteDepense(Guid id)
    {
        try
        {
            await _client.DeleteDepenseAsync(id);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }
}
