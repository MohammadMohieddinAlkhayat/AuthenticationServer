using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationServer.Controllers
{
    public abstract class AuthenticationServerControllerBase: AbpController
    {
        protected AuthenticationServerControllerBase()
        {
            LocalizationSourceName = AuthenticationServerConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
