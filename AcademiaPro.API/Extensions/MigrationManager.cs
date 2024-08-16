using AcademiaPro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AcademiaPro.API.Extensions
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication webApp)
        {
            using(var scope = webApp.Services.CreateScope())
            {
                using(var appContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }

            return webApp;
        }
    }
}
