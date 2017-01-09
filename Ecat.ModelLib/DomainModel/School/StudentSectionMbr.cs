using System.Collections.Generic;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// Represent a student/faculty/etc enrolled into a given section
    /// </summary>
    public class StudentSectionMbr
    {
        public int CourseSectionId { get; set; }
        public int PersonId { get; set; }
        public SchoolPerson Person { get; set; }
        public CourseSection CourseSection { get; set; }
        public CourseOffering CourseOffer { get; set; }
        //public ICollection<StudentSeminarMbr> StudSeminarMemberships { get; set; }
        //public ICollection<StudentScore> StudentScores { get; set; }
    }
}
