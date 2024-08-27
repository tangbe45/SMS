using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaPro.Domain.Interfaces.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? expression = null);

        Task<T> GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        Task Delete(int id);
    }
}
