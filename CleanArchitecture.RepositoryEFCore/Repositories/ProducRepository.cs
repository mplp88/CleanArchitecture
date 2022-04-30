using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.RepositoryEFCore.Context;

namespace CleanArchitecture.RepositoryEFCore.Repositories;
public class ProducRepository : IProductRepository
{
    readonly CleanArchitectureContext Context;

    public ProducRepository(CleanArchitectureContext context) =>
      Context = context;

    public void CreateProduct(Product product)
    {
        Context.Add(product);
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return Context.Products;
    }
}
