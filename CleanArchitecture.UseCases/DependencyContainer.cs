using CleanArchitecture.UseCases.CreateProduct;
using CleanArchitecture.UseCases.GetAllProducts;
using CleanArchitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.UseCases;
public static class DependencyContainer
{
    public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
    {
        services.AddTransient<ICreateProductInputPort, CreateProductInteractor>();
        services.AddTransient<IGetAllProductsInputPort, GetAllProductsInteractor>();

        return services;
    }
}
