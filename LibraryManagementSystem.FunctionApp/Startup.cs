using LibraryManagementAPI;
using LibraryManagementAPI.Data;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(LibraryManagementSystem.FunctionApp.Startup))] // ✅ Correct namespace

namespace LibraryManagementSystem.FunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            var connectionString = Environment.GetEnvironmentVariable("PostgresConnectionString");

            builder.Services.AddDbContext<LibraryDbContext>(options =>
                options.UseNpgsql(connectionString));
        }
    }
}
