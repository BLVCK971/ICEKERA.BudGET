using BudGET.Application.Contracts.Persistence;
using BudGET.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BudGET.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<BudGETDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("BudGETConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));

            services.AddScoped<IBudgetRepository, BudgetRepository>();
            services.AddScoped<ICompteRepository, CompteRepository>();
            services.AddScoped<IDepenseRepository, DepenseRepository>();
            services.AddScoped<IObjectifRepository, ObjectifRepository>();
            services.AddScoped<ISalaireRepository, SalaireRepository>();

            return services;
        }
    }
}
