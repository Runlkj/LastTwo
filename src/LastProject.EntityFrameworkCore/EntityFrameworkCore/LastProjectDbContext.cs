using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LastProject.Authorization.Roles;
using LastProject.Authorization.Users;
using LastProject.MultiTenancy;
using LastProject.Entitys;

namespace LastProject.EntityFrameworkCore
{
    public class LastProjectDbContext : AbpZeroDbContext<Tenant, Role, User, LastProjectDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public LastProjectDbContext(DbContextOptions<LastProjectDbContext> options)
            : base(options)
        {
        }
        public DbSet<AA> AA { get; set; }
        public DbSet<CaseInfo> CaseInfo { get; set; }
        public DbSet<ChineseInfo> ChineseInfo { get; set; }
        public DbSet<DeptInfo> DeptInfo { get; set; }
        public DbSet<EjrInfo> EjrInfo { get; set; }
        public DbSet<EmployInfo> EmployInfo { get; set; }
        public DbSet<EmployJob> EmployJob { get; set; }
        public DbSet<EmployRole> EmployRole { get; set; }
        public DbSet<GetMoney> GetMoney { get; set; }
        public DbSet<JobInfo> JobInfo { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<MestInfo> MestInfo { get; set; }
        public DbSet<OfficeInfo> OfficeInfo { get; set; }
        public DbSet<OrderType> OrderType { get; set; }
        public DbSet<PinInfo> PinInfo { get; set; }
        public DbSet<PriceInfo> PriceInfo { get; set; }
        public DbSet<ProInfo> ProInfo { get; set; }
        public DbSet<RegInfo> RegInfo { get; set; }
        public DbSet<RoleInfo> RoleInfo { get; set; }
        public DbSet<UserInfo> UserInfo { get; set; }
        public DbSet<yaoPinKuCun> yaoPinKuCun { get; set; }
        public DbSet<yaoPinRuku> yaoPinRuku { get; set; }
        public DbSet<yaoType> yaoType { get; set; }
    }
}
