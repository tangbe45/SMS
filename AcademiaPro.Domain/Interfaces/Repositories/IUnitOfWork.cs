using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChangesAsync();

        ILevelRepository LevelRepository { get; }
    }
}
