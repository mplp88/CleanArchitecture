using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.RepositoryEFCore.Context;

public class CleanArchitectureContextFactory : IDesignTimeDbContextFactory<CleanArchitectureContext>
{
    public CleanArchitectureContext CreateDbContext(string[] args)
    {
        var OptionsBuilder = new DbContextOptionsBuilder<CleanArchitectureContext>();
        OptionsBuilder.UseSqlServer("Server=.;Database=CleanArchitecture;Trusted_Connection=True");

        return new CleanArchitectureContext(OptionsBuilder.Options);
    }
}
