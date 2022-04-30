using CleanArchitecture.DTOs;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.Presenters;
public class CreateProductPresenter : ICreateProductOutputPort, IPresenter<ProductDTO>
{
    public ProductDTO Content { get; private set; }

    public Task Handle(ProductDTO productDTO)
    {
        Content = productDTO;
        return Task.CompletedTask;
    }
}
