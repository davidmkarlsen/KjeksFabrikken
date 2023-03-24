using System.Linq.Expressions;
using KjeksFabrikken.Models;

namespace KjeksFabrikken.DataAccess.Repository.IRepository;

public interface ICookieRepository : IRepository<Cookie>
{
    void Update(Cookie obj);
    IQueryable<Cookie> GetAll(
        params Expression<Func<Cookie, object>>[] includeExpressions);

    Cookie GetById(int id);
}