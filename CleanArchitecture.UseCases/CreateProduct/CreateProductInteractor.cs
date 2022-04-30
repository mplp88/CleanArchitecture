using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.Entities.POCOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.UseCases.CreateProduct;

public class CreateProductInteractor : ICreateProductInputPort
{
    readonly IProductRepository Repository;
    readonly IUnitOfWork UnitOfWork;
    readonly ICreateProductOutputPort OutputPort;

    public CreateProductInteractor(
      IProductRepository repository,
      IUnitOfWork unitOfWork,
      ICreateProductOutputPort outputPort) =>
      (Repository, UnitOfWork, OutputPort) = (repository, unitOfWork, outputPort);


    public async Task Handle(CreateProductDTO productDto)
    {
        var NewProduct = new Product
        {
            Name = productDto.ProductName
        };
        Repository.CreateProduct(NewProduct);
        await UnitOfWork.SaveChanges();
        await OutputPort.Handle(new ProductDTO
        {
            Id = NewProduct.Id,
            Name = NewProduct.Name
        });
    }
}
