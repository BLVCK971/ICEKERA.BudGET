using BudGET.Domain.Entities;

namespace BudGET.Application.Features.Comptes.Queries.GetCompteDetail
{
    public class CompteDetailVm
    {
        public Guid Id { get; set; }
        public string Intitule { get; set; } = string.Empty;
        public double Montant { get; set; } = double.MinValue;
        public bool EstCompteCourant { get; set; } = false;
        public ICollection<Depense>? Depenses { get; set; }
        public ICollection<Budget>? Budgets { get; set; }
        public ICollection<Objectif>? Objectifs { get; set; }
        public ICollection<Salaire>? Salaires { get; set; }
    }
}

