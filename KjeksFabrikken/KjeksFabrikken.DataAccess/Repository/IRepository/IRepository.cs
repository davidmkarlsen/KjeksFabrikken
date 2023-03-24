using System.Linq.Expressions;

namespace KjeksFabrikken.DataAccess.Repository.IRepository;

public interface IRepository<T> where T : class
{
    T Single(Expression<Func<T, bool>> filter);
    void Add(T entity);
}