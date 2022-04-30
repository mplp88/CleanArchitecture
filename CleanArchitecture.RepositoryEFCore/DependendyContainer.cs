using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.Context;
using CleanArchitecture.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.RepositoryEFCore;
public static class DependendyContainer
{
    public static IServiceCollection AddRepositories(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<CleanArchitectureContext>(options =>
          options.UseSqlServer(configuration.GetConnectionString("CleanArchitecture")));
        services.AddScoped<IProductRepository, ProducRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();

        return services;
    }
}
