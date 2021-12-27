using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuthenticationServer.EntityFrameworkCore;
using AuthenticationServer.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AuthenticationServer.Web.Tests
{
    [DependsOn(
        typeof(AuthenticationServerWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AuthenticationServerWebTestModule : AbpModule
    {
        public AuthenticationServerWebTestModule(AuthenticationServerEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthenticationServerWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AuthenticationServerWebMvcModule).Assembly);
        }
    }
}