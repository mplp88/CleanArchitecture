using CleanArchitecture.Entities.POCOs;

namespace CleanArchitecture.Entities.Interfaces;

public interface IProductRepository
{
    void CreateProduct(Product product);
    IEnumerable<Product> GetAllProducts();
}
