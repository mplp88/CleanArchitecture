using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.Context;

namespace CleanArchitecture.RepositoryEFCore.Repositories;
public class UnitOfWork : IUnitOfWork
{
    readonly CleanArchitectureContext Context;

    public UnitOfWork(CleanArchitectureContext context) =>
      Context = context;

    public Task<int> SaveChanges()
    {
        return Context.SaveChangesAsync();
    }
}
