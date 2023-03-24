using KjeksFabrikken.DataAccess.Data;
using KjeksFabrikken.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace KjeksFabrikken.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private ApplicationDbContext _db;

    public UnitOfWork(ApplicationDbContext db)
    {
        _db = db;
        Cookie = new CookieRepository(_db);
    }
    
    public ICookieRepository Cookie { get; private set; }
    public void Save()
    {
        _db.SaveChanges();
    }
}