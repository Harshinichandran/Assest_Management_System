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

            if (users.Any())
                return;

            // else seed your data here
            var salt = "";

            var user = new Account()
            {
                Username = "admin",
                PasswordHash = SecurityHelper.HashPassword("password", ref salt),
                PasswordSalt = salt
            };
            users.AddOrUpdate(user);

            var role1 = new Role()
            {
                RoleName ="Admin"
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
