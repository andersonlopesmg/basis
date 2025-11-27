using Basis.Store.Application.Common.Interfaces;
using Basis.Store.Application.Common.Repositories;
using Basis.Store.Infrastructure.Data;
using Basis.Store.Infrastructure.Repositories;
using Basis.Store.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            options.UseSqlServer(connectionString, sqlOptions =>
            {
                sqlOptions.MigrationsAssembly("Basis.Store.Infrastructure");
            });
        });

        ConfigureLogger(configuration);


        services.AddSingleton<ILoggerService, SerilogLoggerService>();

        services.AddScoped<ILivroRepository, LivroRepository>();


        return services;
    }


    private static void ConfigureLogger(IConfiguration configuration)
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .Enrich.FromLogContext()
            .CreateLogger();
    }
}