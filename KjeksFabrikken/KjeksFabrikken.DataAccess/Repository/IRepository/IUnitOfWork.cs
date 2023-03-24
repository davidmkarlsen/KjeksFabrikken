namespace KjeksFabrikken.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICookieRepository Cookie { get; }
    void Save();
}