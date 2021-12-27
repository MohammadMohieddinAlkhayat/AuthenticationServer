using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AuthenticationServer.Configuration;

namespace AuthenticationServer.Web.Host.Startup
{
    [DependsOn(
       typeof(AuthenticationServerWebCoreModule))]
    public class AuthenticationServerWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AuthenticationServerWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AuthenticationServerWebHostModule).GetAssembly());
        }
    }
}
