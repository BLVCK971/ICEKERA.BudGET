using AutoMapper;
using BudGET.Application.Features.Budgets.Commands.CreateBudget;
using BudGET.Application.Features.Budgets.Commands.DeleteBudget;
using BudGET.Application.Features.Budgets.Commands.UpdateBudget;
using BudGET.Application.Features.Budgets.Queries.GetBudgetDetail;
using BudGET.Application.Features.Budgets.Queries.GetBudgetsList;
using BudGET.Application.Features.Comptes.Commands.CreateCompte;
using BudGET.Application.Features.Comptes.Commands.DeleteCompte;
using BudGET.Application.Features.Comptes.Commands.UpdateCompte;
using BudGET.Application.Features.Comptes.Queries.GetCompteDetail;
using BudGET.Application.Features.Comptes.Queries.GetComptesList;
using BudGET.Application.Features.Depenses.Commands.CreateDepense;
using BudGET.Application.Features.Depenses.Commands.DeleteDepense;
using BudGET.Application.Features.Depenses.Commands.UpdateDepense;
using BudGET.Application.Features.Depenses.Queries.GetDepenseDetail;
using BudGET.Application.Features.Depenses.Queries.GetDepensesList;
using BudGET.Application.Features.Objectifs.Commands.CreateObjectif;
using BudGET.Application.Features.Objectifs.Commands.DeleteObjectif;
using BudGET.Application.Features.Objectifs.Commands.UpdateObjectif;
using BudGET.Application.Features.Objectifs.Queries.GetObjectifDetail;
using BudGET.Application.Features.Objectifs.Queries.GetObjectifsList;
using BudGET.Application.Features.Salaires.Commands.CreateSalaire;
using BudGET.Application.Features.Salaires.Commands.DeleteSalaire;
using BudGET.Application.Features.Salaires.Commands.UpdateSalaire;
using BudGET.Application.Features.Salaires.Queries.GetSalaireDetail;
using BudGET.Application.Features.Salaires.Queries.GetSalairesList;
using BudGET.Domain.Entities;

namespace BudGET.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Budget
            CreateMap<Budget, BudgetListVm>().ReverseMap();
            CreateMap<Budget, BudgetDetailVm>().ReverseMap();

            CreateMap<Budget, CreateBudgetCommand>().ReverseMap();
            CreateMap<Budget, CreateBudgetDto>().ReverseMap();
            CreateMap<Budget, DeleteBudgetCommand>().ReverseMap();
            CreateMap<Budget, UpdateBudgetCommand>().ReverseMap();

            //Compte
            CreateMap<Compte, CompteListVm>().ReverseMap();
            CreateMap<Compte, CompteDetailVm>().ReverseMap();

            CreateMap<Compte, CreateCompteCommand>().ReverseMap();
            CreateMap<Compte, CreateCompteDto>().ReverseMap();
            CreateMap<Compte, DeleteCompteCommand>().ReverseMap();
            CreateMap<Compte, UpdateCompteCommand>().ReverseMap();


            //DepenseVMs
            CreateMap<Depense, DepenseListVm>().ReverseMap();
            CreateMap<Depense, DepenseDetailVm>().ReverseMap();

            CreateMap<Depense, CreateDepenseCommand>().ReverseMap();
            CreateMap<Depense, CreateDepenseDto>().ReverseMap();
            CreateMap<Depense, DeleteDepenseCommand>().ReverseMap();
            CreateMap<Depense, UpdateDepenseCommand>().ReverseMap();


            //Objectif
            CreateMap<Objectif, ObjectifListVm>().ReverseMap();
            CreateMap<Objectif, ObjectifDetailVm>().ReverseMap();

            CreateMap<Objectif, CreateObjectifCommand>().ReverseMap();
            CreateMap<Objectif, CreateObjectifDto>().ReverseMap();
            CreateMap<Objectif, DeleteObjectifCommand>().ReverseMap();
            CreateMap<Objectif, UpdateObjectifCommand>().ReverseMap();

            //Salaire
            CreateMap<Salaire, SalaireListVm>().ReverseMap();
            CreateMap<Salaire, SalaireDetailVm>().ReverseMap();

            CreateMap<Salaire, CreateSalaireCommand>().ReverseMap();
            CreateMap<Salaire, CreateSalaireDto>().ReverseMap();
            CreateMap<Salaire, DeleteSalaireCommand>().ReverseMap();
            CreateMap<Salaire, UpdateSalaireCommand>().ReverseMap();

        }
    }
}

