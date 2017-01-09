using System.Collections.Generic;
using System.Collections.Specialized;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// A person object who is/was a faculty for a particular course section. 
    /// </summary>
    public class FacultySectionMbr
    {
        public int CourseSectionId { get; set; }
        public int PersonId { get; set; }
        public SchoolPerson Person { get; set; }
        public CourseSection CourseSection { get; set; }
        //public ICollection<FacultySeminarMbr> FacSeminarMemberships { get; set; }
        //public ICollection<StudentScore> FacultyScoredScores { get; set; }
    }
}
