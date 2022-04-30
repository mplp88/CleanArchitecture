using CleanArchitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presenters;
public static class DependencyContainer
{
    public static IServiceCollection AddPresenters(this IServiceCollection services)
    {
        services.AddScoped<ICreateProductOutputPort, CreateProductPresenter>();
        services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();

        return services;
    }
}
