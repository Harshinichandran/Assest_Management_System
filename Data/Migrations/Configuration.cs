using System.Data.Entity.Migrations;
using System.Linq;
using Core.Domains;
using Core.Helpers.Security;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppContext context)
        {
            var users = context.Set<Account>();
            var roles = context.Set<Role>();
            var adminusers = context.Set<Users>();

            if (users.Any())
                return;

            // else seed your data here
            var salt = "";
            string username = "admin@admin.com";
            var user = new Account()
            {
                Username = username,
                PasswordSalt = SecurityHelper.HashPassword("password", ref username),
                //PasswordSalt = salt,
                PasswordHash = "password",
                //PasswordSalt = "password",
                UserId = 1,
                FirstLogin = true
            };

            var adminuser = new Users()
            {
                Name = "admin",
                Email = "admin@admin.com",
                RoleId = 1,
                Address = "Administrator Location",
                UserEnabled = true
            };
            adminusers.AddOrUpdate(adminuser);

            users.AddOrUpdate(user);

            var role1 = new Role()
            {
                RoleName = "Admin"
            };

            var role2 = new Role()
            {
                RoleName = "Resource Checker"
            };
            roles.AddOrUpdate(role1);
            roles.AddOrUpdate(role2);
            context.SaveChanges();
        }
    }
}
