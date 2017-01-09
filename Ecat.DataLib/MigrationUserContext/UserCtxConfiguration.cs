using System.Data.Entity.Migrations;
using Ecat.DataLib.Context;

namespace Ecat.DataLib.MigrationUserContext
{
    internal sealed class UserCtxConfiguration : DbMigrationsConfiguration<ContextUser>
    {
        public UserCtxConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"UserContextMigrations";
        }

        protected override void Seed(ContextUser context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
