using BudGET.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BudGET.Persistence;

public class BudGETDbContext : DbContext
{
    public BudGETDbContext(DbContextOptions<BudGETDbContext> options)
        : base(options)
    {

    }

    public DbSet<Budget>? Budgets { get; set; }
    public DbSet<Compte>? Comptes { get; set; }
    public DbSet<Depense>? Depenses { get; set; }
    public DbSet<Objectif>? Objectifs { get; set; }
    public DbSet<Salaire>? Salaires { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(BudGETDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }

}
