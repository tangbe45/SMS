using AcademiaPro.Domain.Entities;
using AcademiaPro.Domain.Interfaces.Repositories;
using AcademiaPro.Infrastructure.Data;

namespace AcademiaPro.Infrastructure.Repositories
{
    public class LevelRepository : Repository<Level>, ILevelRepository
    {
        public LevelRepository(ApplicationDbContext context)
            : base(context)
        {
        }

    }
}
