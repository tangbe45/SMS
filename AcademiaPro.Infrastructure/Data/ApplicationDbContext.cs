using AcademiaPro.Domain.Entities;
using AcademiaPro.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace AcademiaPro.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Level>? Classes { get; set; }


        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("sms_app");

            modelBuilder.ApplyConfiguration(new LevelConfiguration());
        }
    }
}
