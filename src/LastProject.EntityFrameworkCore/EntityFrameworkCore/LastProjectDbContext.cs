using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LastProject.Authorization.Roles;
using LastProject.Authorization.Users;
using LastProject.MultiTenancy;

namespace LastProject.EntityFrameworkCore
{
    public class LastProjectDbContext : AbpZeroDbContext<Tenant, Role, User, LastProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LastProjectDbContext(DbContextOptions<LastProjectDbContext> options)
            : base(options)
        {
        }
    }
}
