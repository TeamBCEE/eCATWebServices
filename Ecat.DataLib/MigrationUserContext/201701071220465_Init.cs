using System.Data.Entity.Migrations;

namespace Ecat.DataLib.MigrationUserContext
{
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "User.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LastName = c.String(),
                        FirstName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("User.People");
        }
    }
}
