using AcademiaPro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AcademiaPro.Infrastructure.Extensions
{
    public static class InfrastructureServicesRegistration
    {
        public static IServiceCollection ConfigureInfrastructureServices(this IServiceCollection services)
        {

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                string? connection = Environment.GetEnvironmentVariable("DefaultConnection");
                if (connection == null)
                {
                    throw new ArgumentNullException("Connection string not found");
                }
                options.UseNpgsql(connection, options =>
                {
                    options.SetPostgresVersion(new Version(9, 5));
                    options.MigrationsAssembly("AcademiaPro.API");
                });
            });

            return services;
        }
    }
}
