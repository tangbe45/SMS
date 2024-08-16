using AcademiaPro.Domain.Interfaces.Repositories;
using AcademiaPro.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private ILevelRepository? _levelRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public ILevelRepository LevelRepository => 
            _levelRepository ??= new LevelRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
