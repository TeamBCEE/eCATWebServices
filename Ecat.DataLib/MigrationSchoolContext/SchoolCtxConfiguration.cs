using System.Data.Entity.Migrations;
using Ecat.DataLib.Context;

namespace Ecat.DataLib.MigrationSchoolContext
{
    internal sealed class SchoolCtxConfiguration : DbMigrationsConfiguration<ContextSchool>
    {
        public SchoolCtxConfiguration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"MigrationSchoolContext";
        }

        protected override void Seed(ContextSchool context)
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
