namespace Ecat.DataLib.MigrationSchoolContext
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Sch.Campus",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LmsMatchKey = c.String(maxLength: 50),
                        LmsAlumniFacultyGroupId = c.String(maxLength: 50),
                        CampusName = c.String(maxLength: 50),
                        CampusZip = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sch.CourseOffering",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        CampusId = c.Int(nullable: false),
                        LmsCourseId = c.String(maxLength: 50),
                        CourseName = c.String(maxLength: 50),
                        AcademicYear = c.Int(nullable: false),
                        TermNumber = c.Int(nullable: false),
                        AlumniLmsCrseOfferId = c.String(maxLength: 50),
                        OfferingStartDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        OfferingGradDate = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sch.Campus", t => t.CampusId)
                .Index(t => t.CampusId);
            
            CreateTable(
                "Sch.CourseSection",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseOfferId = c.Int(nullable: false),
                        PrimaryFacultyId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sch.CourseOffering", t => t.CourseOfferId)
                .Index(t => t.CourseOfferId);
            
            CreateTable(
                "Sch.FacultySectionMbr",
                c => new
                    {
                        CourseSectionId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CourseSectionId, t.PersonId })
                .ForeignKey("Sch.CourseSection", t => t.CourseSectionId, cascadeDelete: true)
                .Index(t => t.CourseSectionId);
            
            CreateTable(
                "Sch.StudentSectionMbr",
                c => new
                    {
                        CourseSectionId = c.Int(nullable: false),
                        PersonId = c.Int(nullable: false),
                        CourseOffer_Id = c.Int(),
                    })
                .PrimaryKey(t => new { t.CourseSectionId, t.PersonId })
                .ForeignKey("Sch.CourseOffering", t => t.CourseOffer_Id)
                .ForeignKey("Sch.CourseSection", t => t.CourseSectionId, cascadeDelete: true)
                .Index(t => t.CourseSectionId)
                .Index(t => t.CourseOffer_Id);
            
            CreateTable(
                "Sch.Seminar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BlocNumber = c.Int(nullable: false),
                        SeminarNumber = c.Int(nullable: false),
                        ModelId = c.Int(nullable: false),
                        CustomName = c.String(maxLength: 50),
                        SeminarLocation = c.String(maxLength: 50),
                        CourseOffer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sch.CourseOffering", t => t.CourseOffer_Id)
                .Index(t => t.CourseOffer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Sch.Seminar", "CourseOffer_Id", "Sch.CourseOffering");
            DropForeignKey("Sch.StudentSectionMbr", "CourseSectionId", "Sch.CourseSection");
            DropForeignKey("Sch.StudentSectionMbr", "CourseOffer_Id", "Sch.CourseOffering");
            DropForeignKey("Sch.FacultySectionMbr", "CourseSectionId", "Sch.CourseSection");
            DropForeignKey("Sch.CourseSection", "CourseOfferId", "Sch.CourseOffering");
            DropForeignKey("Sch.CourseOffering", "CampusId", "Sch.Campus");
            DropIndex("Sch.Seminar", new[] { "CourseOffer_Id" });
            DropIndex("Sch.StudentSectionMbr", new[] { "CourseOffer_Id" });
            DropIndex("Sch.StudentSectionMbr", new[] { "CourseSectionId" });
            DropIndex("Sch.FacultySectionMbr", new[] { "CourseSectionId" });
            DropIndex("Sch.CourseSection", new[] { "CourseOfferId" });
            DropIndex("Sch.CourseOffering", new[] { "CampusId" });
            DropTable("Sch.Seminar");
            DropTable("Sch.StudentSectionMbr");
            DropTable("Sch.FacultySectionMbr");
            DropTable("Sch.CourseSection");
            DropTable("Sch.CourseOffering");
            DropTable("Sch.Campus");
        }
    }
}
