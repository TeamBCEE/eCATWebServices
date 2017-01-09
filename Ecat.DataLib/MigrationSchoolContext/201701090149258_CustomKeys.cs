namespace Ecat.DataLib.MigrationSchoolContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomKeys : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("Sch.FacultySectionMbr","PersonId","User.People","Id");
            AddForeignKey("Sch.StudentSectionMbr", "PersonId", "User.People", "Id");
        }

        public override void Down()
        {
            DropForeignKey("Sch.FacultySectionMbr", "PersonId", "User.People");
            DropForeignKey("Sch.StudentSectionMbr", "PersonId", "User.People");

        }
    }
}
