using CleanArchitecture.DTOs;

namespace CleanArchitecture.UseCasesPorts;

public interface ICreateProductInputPort
{
    Task Handle(CreateProductDTO productDto);
}
