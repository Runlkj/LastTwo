using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using LastProject.Configuration;
using LastProject.Web;

namespace LastProject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class LastProjectDbContextFactory : IDesignTimeDbContextFactory<LastProjectDbContext>
    {
        public LastProjectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<LastProjectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            LastProjectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(LastProjectConsts.ConnectionStringName));

            return new LastProjectDbContext(builder.Options);
        }
    }
}
