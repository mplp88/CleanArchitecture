using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.DTOs;
using CleanArchitecture.Presenters;
using CleanArchitecture.UseCasesPorts;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GetAllProductsController
{
    readonly IGetAllProductsInputPort InputPort;
    readonly IGetAllProductsOutputPort OutputPort;

    public GetAllProductsController(
      IGetAllProductsInputPort inputPort,
      IGetAllProductsOutputPort outputPort) =>
      (InputPort, OutputPort) = (inputPort, outputPort);

    [HttpGet]
    public async Task<IEnumerable<ProductDTO>> GetAllProducts()
    {
        await InputPort.Handle();
        return ((IPresenter<IEnumerable<ProductDTO>>)OutputPort).Content;
    }
}
