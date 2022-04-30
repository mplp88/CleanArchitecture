namespace CleanArchitecture.Entities.Interfaces;
public interface IUnitOfWork
{
    Task<int> SaveChanges();
}
