using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[Route("api/[Controller]")]
[ApiController]
public class CreateProductController
{
    readonly ICreateProductInputPort InputPort;
    readonly ICreateProductOutputPort OutputPort;

    public CreateProductController(
      ICreateProductInputPort inputPort,
      ICreateProductOutputPort outputPort) =>
      (InputPort, OutputPort) = (inputPort, outputPort);

    [HttpPost]
    public async Task<ProductDTO> CreateProduct(CreateProductDTO createProductDTO)
    {
        await InputPort.Handle(createProductDTO);
        return ((IPresenter<ProductDTO>)OutputPort).Content;
    }
}
