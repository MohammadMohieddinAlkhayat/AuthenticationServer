using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace AuthenticationServer.EntityFrameworkCore
{
    public static class AuthenticationServerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AuthenticationServerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AuthenticationServerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
