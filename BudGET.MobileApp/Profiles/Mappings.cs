using AutoMapper;
using BudGET.MobileApp.Services;
using BudGET.MobileApp.ViewModels.BudgetViewModels;
using BudGET.MobileApp.ViewModels.CompteViewModels;
using BudGET.MobileApp.ViewModels.DepenseViewModels;
using BudGET.MobileApp.ViewModels.ObjectifViewModels;
using BudGET.MobileApp.ViewModels.SalaireViewModels;

namespace GloboTicket.TicketManagement.App.Profiles
{
    public class Mappings : Profile
    {
        public Mappings()
        {
            //Vms are coming in from the API, ViewModel are the local entities in Blazor
            CreateMap<CreateBudgetCommand, BudgetViewModel>().ReverseMap();
            CreateMap<CreateBudgetDto, BudgetViewModel>().ReverseMap();
            CreateMap<UpdateBudgetCommand, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDetailVm, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDto, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDto2, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDto3, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDto4, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetDto5, BudgetViewModel>().ReverseMap();
            CreateMap<BudgetListVm, BudgetListViewModel>().ReverseMap();

            CreateMap<CreateCompteCommand, CompteViewModel>().ReverseMap();
            CreateMap<CreateCompteDto, CompteViewModel>().ReverseMap();
            CreateMap<UpdateCompteCommand, CompteViewModel>().ReverseMap();
            CreateMap<CompteDetailVm, CompteViewModel>().ReverseMap();
            CreateMap<CompteListVm, CompteListViewModel>().ReverseMap();

            CreateMap<CreateDepenseCommand, DepenseViewModel>().ReverseMap();
            CreateMap<CreateDepenseDto, DepenseViewModel>().ReverseMap();
            CreateMap<UpdateDepenseCommand, DepenseViewModel>().ReverseMap();
            CreateMap<DepenseDetailVm, DepenseViewModel>().ReverseMap();
            CreateMap<DepenseDto, DepenseViewModel>().ReverseMap();     
            CreateMap<DepenseListVm, DepenseListViewModel>().ReverseMap();

            CreateMap<CreateObjectifCommand, ObjectifViewModel>().ReverseMap();
            CreateMap<CreateObjectifDto, ObjectifViewModel>().ReverseMap();
            CreateMap<UpdateObjectifCommand, ObjectifViewModel>().ReverseMap();
            CreateMap<ObjectifDetailVm, ObjectifViewModel>().ReverseMap();
            CreateMap<ObjectifDto, ObjectifViewModel>().ReverseMap();
            CreateMap<ObjectifListVm, ObjectifListViewModel>().ReverseMap();

            CreateMap<CreateSalaireCommand, SalaireViewModel>().ReverseMap();
            CreateMap<CreateSalaireDto, SalaireViewModel>().ReverseMap();
            CreateMap<UpdateSalaireCommand, SalaireViewModel>().ReverseMap();
            CreateMap<SalaireDetailVm, SalaireViewModel>().ReverseMap();
            CreateMap<SalaireDto, SalaireViewModel>().ReverseMap();
            CreateMap<SalaireListVm, SalaireListViewModel>().ReverseMap();

        }
    }
}
