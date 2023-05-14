using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KranumDataAccess.Repository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetAsync(int id);

        Task<T> GetByIdAsync(int id);
        //Task<T> GetByUUIDAsync(string uuid, bool isUpdate);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);

        List<T> GetByQuery(Expression<Func<T, bool>> Predicate);
    }
}
