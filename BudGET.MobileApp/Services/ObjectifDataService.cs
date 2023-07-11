using AutoMapper;
using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.ObjectifViewModels;

namespace BudGET.MobileApp.Services;

public class ObjectifDataService : BaseDataService, IObjectifDataService
{

    private readonly IMapper _mapper;

    public ObjectifDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
    {
        _mapper = mapper;
    }

    public async Task<List<ObjectifListViewModel>> GetAllObjectifs()
    {
        var allObjectifs = await _client.GetAllObjectifsAsync();
        var mappedObjectifs = _mapper.Map<ICollection<ObjectifListViewModel>>(allObjectifs);
        return mappedObjectifs.ToList();
    }

    public async Task<ObjectifViewModel> GetObjectifById(Guid id)
    {
        var selectedObjectif = await _client.GetObjectifByIdAsync(id);
        var mappedObjectif = _mapper.Map<ObjectifViewModel>(selectedObjectif);
        return mappedObjectif;
    }

    public async Task<ApiResponse<CreateObjectifDto>> CreateObjectif(ObjectifViewModel ObjectifViewModel)
    {
        try
        {
            ApiResponse<CreateObjectifDto> apiResponse = new ApiResponse<CreateObjectifDto>();
            CreateObjectifCommand createObjectifCommand = _mapper.Map<CreateObjectifCommand>(ObjectifViewModel);
            var createObjectifCommandResponse = await _client.AddObjectifAsync(createObjectifCommand);
            if (createObjectifCommandResponse.Success)
            {
                apiResponse.Data = _mapper.Map<CreateObjectifDto>(createObjectifCommandResponse.Objectif);
                apiResponse.Success = true;
            }
            else
            {
                apiResponse.Data = null;
                foreach (var error in createObjectifCommandResponse.ValidationErrors)
                {
                    apiResponse.ValidationErrors += error + Environment.NewLine;
                }
            }
            return apiResponse;
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<CreateObjectifDto>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> UpdateObjectif(ObjectifViewModel ObjectifDetailViewModel)
    {
        try
        {
            UpdateObjectifCommand updateObjectifCommand = _mapper.Map<UpdateObjectifCommand>(ObjectifDetailViewModel);
            await _client.UpdateObjectifAsync(updateObjectifCommand);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> DeleteObjectif(Guid id)
    {
        try
        {
            await _client.DeleteObjectifAsync(id);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }
}
