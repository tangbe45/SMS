using AcademiaPro.Domain.Interfaces.Repositories;
using AcademiaPro.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AcademiaPro.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _db;

        public Repository(ApplicationDbContext dbContext)
        {
            _context = dbContext;
            _db = _context.Set<T>();
        }

        public async Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null)
        {
            return await _db.AsNoTracking().ToListAsync();
        }
        
        public async Task<T> GetById(int id)
        {
            var level = await _db.FindAsync(id);
            if (level == null)
            {
                throw new Exception("Class not found");
            }

            return level;
        }

        public async Task Delete(int id)
        {
            var level = await _db.FindAsync(id);

            if (level == null)
            {
                throw new Exception("Class not found");
            }

            _db.Remove(level);
        }

        public void Insert(T entity)
        {
            _db.Add(entity);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
        }
    }
}
