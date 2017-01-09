using System.Data.Entity.ModelConfiguration;
using Ecat.ModelLib.DomainModel.School;
using Ecat.ModelLib.Utility.Attributes;

namespace Ecat.DataLib.Configuration
{
    [ConfigSchoolContext]
    public class CfgCourseOffering : EntityTypeConfiguration<CourseOffering>
    {
        public CfgCourseOffering()
        {
            HasRequired(e => e.Campus)
                .WithMany(e => e.CourseOfferings)
                .WillCascadeOnDelete(false);
        }
    }

    [ConfigSchoolContext]
    public class CfgCourseSection : EntityTypeConfiguration<CourseSection>
    {
        public CfgCourseSection()
        {
            HasRequired(e => e.CourseOffer)
                .WithMany(e => e.CourseSections)
                .WillCascadeOnDelete(false);

            Ignore(p => p.PrimaryFaculty);
        }
    }

    [ConfigSchoolContext]
    public class CfgFacultySectionMbr : EntityTypeConfiguration<FacultySectionMbr>
    {
        public CfgFacultySectionMbr()
        {
            HasKey(e => new {e.CourseSectionId, e.PersonId});
            Ignore(p => p.Person);
        }
    }


    [ConfigSchoolContext]
    public class CfgStudentSectionMbr : EntityTypeConfiguration<StudentSectionMbr>
    {
        public CfgStudentSectionMbr()
        {
            HasKey(e => new { e.CourseSectionId, e.PersonId });
            Ignore(p => p.Person);
        }
    }

    //public class CfgFacultySeminarMbr : EntityTypeConfiguration<FacultySeminarMbr>
    //{
    //    public CfgFacultySeminarMbr()
    //    {
    //        Ignore(p => p.Person);
    //        HasRequired(e => e.CourseSection)
    //            .WithMany(e => )
    //    }
    //}
}
