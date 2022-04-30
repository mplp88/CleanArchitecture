using CleanArchitecture.DTOs;

namespace CleanArchitecture.UseCasesPorts;
public interface ICreateProductOutputPort
{
    Task Handle(ProductDTO productDTO);
}
