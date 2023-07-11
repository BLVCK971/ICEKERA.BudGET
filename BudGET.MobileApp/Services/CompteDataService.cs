using AutoMapper;
using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Services.Base;
using BudGET.MobileApp.ViewModels.CompteViewModels;

namespace BudGET.MobileApp.Services;

public class CompteDataService : BaseDataService, ICompteDataService
{

    private readonly IMapper _mapper;

    public CompteDataService(IClient client, IMapper mapper, ILocalStorageService localStorage) : base(client, localStorage)
    {
        _mapper = mapper;
    }

    public async Task<List<CompteListViewModel>> GetAllComptes()
    {
        var allComptes = await _client.GetAllComptesAsync();
        var mappedComptes = _mapper.Map<ICollection<CompteListViewModel>>(allComptes);
        return mappedComptes.ToList();
    }

    public async Task<CompteViewModel> GetCompteById(Guid id)
    {
        var selectedCompte = await _client.GetCompteByIdAsync(id);
        var mappedCompte = _mapper.Map<CompteViewModel>(selectedCompte);
        return mappedCompte;
    }

    public async Task<ApiResponse<CreateCompteDto>> CreateCompte(CompteViewModel CompteViewModel)
    {
        try
        {
            ApiResponse<CreateCompteDto> apiResponse = new ApiResponse<CreateCompteDto>();
            CreateCompteCommand createCompteCommand = _mapper.Map<CreateCompteCommand>(CompteViewModel);
            var createCompteCommandResponse = await _client.AddCompteAsync(createCompteCommand);
            if (createCompteCommandResponse.Success)
            {
                apiResponse.Data = _mapper.Map<CreateCompteDto>(createCompteCommandResponse.Compte);
                apiResponse.Success = true;
            }
            else
            {
                apiResponse.Data = null;
                foreach (var error in createCompteCommandResponse.ValidationErrors)
                {
                    apiResponse.ValidationErrors += error + Environment.NewLine;
                }
            }
            return apiResponse;
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<CreateCompteDto>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> UpdateCompte(CompteViewModel CompteDetailViewModel)
    {
        try
        {
            UpdateCompteCommand updateCompteCommand = _mapper.Map<UpdateCompteCommand>(CompteDetailViewModel);
            await _client.UpdateCompteAsync(updateCompteCommand);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }

    public async Task<ApiResponse<Guid>> DeleteCompte(Guid id)
    {
        try
        {
            await _client.DeleteCompteAsync(id);
            return new ApiResponse<Guid>() { Success = true };
        }
        catch (ApiException ex)
        {
            return ConvertApiExceptions<Guid>(ex);
        }
    }
}
