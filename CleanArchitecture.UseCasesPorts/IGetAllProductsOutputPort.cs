using CleanArchitecture.DTOs;

namespace CleanArchitecture.UseCasesPorts;
public interface IGetAllProductsOutputPort
{
    Task Handle(IEnumerable<ProductDTO> products);
}
