using System.Linq.Expressions;
using KjeksFabrikken.DataAccess.Data;
using KjeksFabrikken.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace KjeksFabrikken.DataAccess.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly ApplicationDbContext _db;
    internal DbSet<T> dbSet;

    public Repository(ApplicationDbContext db)
    {
        _db = db;
        this.dbSet = _db.Set<T>();
    }
    
    public T Single(Expression<Func<T, bool>> filter)
    {
        IQueryable<T> query = dbSet;

        query = query.Where(filter);
        
        return query.Single();
    }

    public void Add(T entity)
    {
        dbSet.Add(entity);
    }
}