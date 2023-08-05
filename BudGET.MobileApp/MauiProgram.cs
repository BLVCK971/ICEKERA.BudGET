using Blazored.LocalStorage;
using BudGET.MobileApp.Contracts;
using BudGET.MobileApp.Data;
using BudGET.MobileApp.Services;
using Microsoft.Extensions.Logging;

namespace BudGET.MobileApp;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });

        builder.Services.AddMauiBlazorWebView();
        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        builder.Services.AddBlazoredLocalStorage();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();;
#endif

        builder.Services.AddSingleton(new HttpClient
        {
            BaseAddress = new Uri("https://budget.ypepin.com")
        });
        builder.Services.AddHttpClient<IClient, Client>(client => client.BaseAddress = new Uri("https://budget.ypepin.com"));

        builder.Services.AddSingleton<WeatherForecastService>();
        builder.Services.AddScoped<IBudgetDataService, BudgetDataService>();
        builder.Services.AddScoped<ICompteDataService, CompteDataService>();
        builder.Services.AddScoped<IDepenseDataService, DepenseDataService>();
        builder.Services.AddScoped<IObjectifDataService, ObjectifDataService>();
        builder.Services.AddScoped<ISalaireDataService, SalaireDataService>();

        return builder.Build();
    }
}