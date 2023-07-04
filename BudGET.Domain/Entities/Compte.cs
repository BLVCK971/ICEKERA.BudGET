using BudGET.Domain.Common;
using System;

namespace BudGET.Domain.Entities;

public class Compte : AuditableEntity
{
    public string Intitule { get; set; }
    public double Montant { get; set; }
    public bool EstCompteCourant { get; set; }
    public List<Depense>? Depenses { get; set; }
    public List<Budget>? Budgets { get; set; }
    public List<Objectif>? Objectifs { get; set; }
    public List<Salaire>? Salaires { get; set; }

    public Compte() 
    {
        Intitule = "";
        Montant = 0.0;
        EstCompteCourant = false;
    }
}

