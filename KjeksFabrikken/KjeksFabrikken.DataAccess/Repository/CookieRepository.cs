using System.Linq.Expressions;
using KjeksFabrikken.DataAccess.Data;
using KjeksFabrikken.DataAccess.Repository.IRepository;
using KjeksFabrikken.Models;
using Microsoft.EntityFrameworkCore;

namespace KjeksFabrikken.DataAccess.Repository;

public class CookieRepository : Repository<Cookie>, ICookieRepository
{
    private ApplicationDbContext _db;
    public CookieRepository(ApplicationDbContext db) : base(db)
    {
        _db = db;
    }

    public void Update(Cookie obj)
    {
        _db.Cookies.Update(obj);
    }

    public IQueryable<Cookie> GetAll(
        params Expression<Func<Cookie, object>>[] includeExpressions)
    {
        IQueryable<Cookie> set = _db.Cookies;

        set = set
            .Include(x => x.CookieCategories)
            .Include(x => x.CookieIngredients);

        return set;
    }

    public Cookie GetById(
        int id)
    {
        IQueryable<Cookie> set = _db.Cookies;
        
        set = set
            .Include(x => x.CookieCategories)
            .ThenInclude(x => x.Category)
            .Include(x => x.CookieIngredients)
            .ThenInclude(x => x.Ingredient);
        
        set.SingleOrDefault(s => s.Id == id);

        return _db.Cookies.Find(id);
        
        /*
        if (includeExpressions.Any())
        {
            
            var set = includeExpressions
                .Aggregate<Expression<Func<Cookie, object>>, IQueryable<Cookie>>
                    (_db.Cookies, (current, expression) => current.Include(expression));
            
            return set.SingleOrDefault(s => s.Id == id);
        } 
        

        return _db.Cookies.Find(id);
        */
    }
}