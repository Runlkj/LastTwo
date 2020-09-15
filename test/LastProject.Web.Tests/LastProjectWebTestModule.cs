using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LastProject.EntityFrameworkCore;
using LastProject.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LastProject.Web.Tests
{
    [DependsOn(
        typeof(LastProjectWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LastProjectWebTestModule : AbpModule
    {
        public LastProjectWebTestModule(LastProjectEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LastProjectWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LastProjectWebMvcModule).Assembly);
        }
    }
}