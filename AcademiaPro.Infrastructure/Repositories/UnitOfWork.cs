using AcademiaPro.Domain.Entities;
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
        private IGenericRepository<Level>? _levels;
        private GenericRepository<Classroom>? _classrooms;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Level> Levels => _levels ??= new GenericRepository<Level>(_context);
        public IGenericRepository<Classroom> Classrooms => _classrooms ??= new GenericRepository<Classroom>(_context);  

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
