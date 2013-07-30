using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;

namespace PhotoHunt.Models 
{
    // Modify the User class to add extra user information

    public class IdentityDbContext : DbContext
    {
        public IdentityDbContext()
            : base("DefaultConnection")
        {
        }

        public IdentityDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
        }

        // This method ensures that user names are always unique
        protected override DbEntityValidationResult ValidateEntity(DbEntityEntry entityEntry, IDictionary<object, object> items)
        {
            if (entityEntry.State == EntityState.Added)
            {
                var user = entityEntry.Entity as User;
                // Check for uniqueness of user name
                if (user != null && Users.Any(u => u.UserName.ToUpper() == user.UserName.ToUpper()))
                {
                    var result = new DbEntityValidationResult(entityEntry, new List<DbValidationError>());
                    result.ValidationErrors.Add(new DbValidationError("User", "User name must be unique."));
                    return result;
                }
            }
            return base.ValidateEntity(entityEntry, items);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserSecret> Secrets { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}