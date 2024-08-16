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
                options.UseNpgsql(Environment.GetEnvironmentVariable("DefaultConnection"), options =>
                {
                    options.SetPostgresVersion(new Version(9, 5));
                    options.MigrationsAssembly("AcademiaPro.API");
                });
            });

            return services;
        }
    }
}
