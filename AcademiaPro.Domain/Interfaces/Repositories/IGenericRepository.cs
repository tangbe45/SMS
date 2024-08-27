using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.Interfaces.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IList<T>> GetAllAsync(
            Expression<Func<T, bool>>? expression = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderby = null,
            List<string>? include = null);

        Task<T> Get(Expression<Func<T, bool>>? expression = null, List<string>? include = null);

        Task Create(T item);

        Task Delete(int id);

        void Update(T entity);

        Task CreateRange(IEnumerable<T> entities);

        void DeleteRange(IEnumerable<T> entities);
    }
}
