using BudGET.Api;

var builder = WebApplication.CreateBuilder(args);
var app = builder
       .ConfigureServices()
       .ConfigurePipeline();

//app.MapGet("/", () => "Hello World!");


await app.ResetDatabaseAsync();

app.Run();
public partial class Program { }