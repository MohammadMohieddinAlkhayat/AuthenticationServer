using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuthenticationServer.Authorization;

namespace AuthenticationServer
{
    [DependsOn(
        typeof(AuthenticationServerCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AuthenticationServerApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AuthenticationServerAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AuthenticationServerApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
