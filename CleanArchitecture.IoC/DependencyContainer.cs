using CleanArchitecture.Presenters;
using CleanArchitecture.RepositoryEFCore;
using CleanArchitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC;

public static class DependencyContainer
{
    public static IServiceCollection AddCleanArchitectureDependencies(
      this IServiceCollection services, IConfiguration configuration)
    {
        services.AddRepositories(configuration);
        services.AddUseCasesServices();
        services.AddPresenters();
        return services;
    }
}
