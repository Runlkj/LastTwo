using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LastProject.EntityFrameworkCore
{
    public static class LastProjectDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LastProjectDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LastProjectDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
