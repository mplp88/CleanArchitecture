using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.DTOs;
using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.UseCasesPorts;

namespace CleanArchitecture.UseCases.GetAllProducts;
public class GetAllProductsInteractor : IGetAllProductsInputPort
{
    readonly IProductRepository Repository;
    readonly IGetAllProductsOutputPort OutputPort;

    public GetAllProductsInteractor(
      IProductRepository repository,
      IGetAllProductsOutputPort outputPort) =>
      (Repository, OutputPort) = (repository, outputPort);

    public Task Handle()
    {
        var Products = Repository.GetAllProducts().Select(p => new ProductDTO
        {
            Id = p.Id,
            Name = p.Name
        });

        OutputPort.Handle(Products);
        return Task.CompletedTask;
    }
}
