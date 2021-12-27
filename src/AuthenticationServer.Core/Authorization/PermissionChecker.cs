using Abp.Authorization;
using AuthenticationServer.Authorization.Roles;
using AuthenticationServer.Authorization.Users;

namespace AuthenticationServer.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
