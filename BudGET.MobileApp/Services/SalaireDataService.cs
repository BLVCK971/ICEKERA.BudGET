using AutoMapper;
using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.SalaireViewModels;

namespace BudGET.MobileApp.Services;

public class SalaireDataService : BaseDataService, ISalaireDataService
{

    private readonly IMapper _mapper;

    public SalaireDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
    {
        _mapper = mapper;
    }

    public async Task<List<SalaireListViewModel>> GetAllSalaires()
    {
        var allSalaires = await _client.GetAllSalairesAsync();
        var mappedSalaires = _mapper.Map<ICollection<SalaireListViewModel>>(allSalaires);
        return mappedSalaires.ToList();
    }

    public async Task<SalaireViewModel> GetSalaireById(Guid id)
    {
        var selectedSalaire = await _client.GetSalaireByIdAsync(id);
        var mappedSalaire = _mapper.Map<SalaireViewModel>(selectedSalaire);
        return mappedSalaire;
    }

    public async Task<ApiResponse<CreateSalaireDto>> CreateSalaire(SalaireViewModel SalaireViewModel)
    {
        try
        {
            ApiResponse<CreateSalaireDto> apiResponse = new ApiResponse<CreateSalaireDto>();
            CreateSalaireCommand createSalaireCommand = _mapper.Map<CreateSalaireCommand>(SalaireViewModel);
            var createSalaireCommandResponse = await _client.AddSalaireAsync(createSalaireCommand);
            if (createSalaireCommandResponse.Success)
            {
                apiResponse.Data = _mapper.Map<CreateSalaireDto>(createSalaireCommandResponse.Salaire);
                apiResponse.Success = true;
            }
            else
            {
                apiResponse.Data = null;
                foreach (var error in createSalaireCommandResponse.ValidationErrors)
                {
                    apiResponse.ValidationErrors += error + Environment.NewLine;
                }
            }
            return apiResponse;
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<CreateSalaireDto>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> UpdateSalaire(SalaireViewModel SalaireDetailViewModel)
    {
        try
        {
            UpdateSalaireCommand updateSalaireCommand = _mapper.Map<UpdateSalaireCommand>(SalaireDetailViewModel);
            await _client.UpdateSalaireAsync(updateSalaireCommand);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> DeleteSalaire(Guid id)
    {
        try
        {
            await _client.DeleteSalaireAsync(id);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }
}
