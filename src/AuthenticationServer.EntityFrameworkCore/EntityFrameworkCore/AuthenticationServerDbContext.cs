using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AuthenticationServer.Authorization.Roles;
using AuthenticationServer.Authorization.Users;
using AuthenticationServer.MultiTenancy;

namespace AuthenticationServer.EntityFrameworkCore
{
    public class AuthenticationServerDbContext : AbpZeroDbContext<Tenant, Role, User, AuthenticationServerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AuthenticationServerDbContext(DbContextOptions<AuthenticationServerDbContext> options)
            : base(options)
        {
        }
    }
}
