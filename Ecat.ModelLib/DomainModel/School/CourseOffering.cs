using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// Represents a single course being taught at a particular campuse during a specific time period
    /// i.e. Keesler 17-1 ILE course
    /// </summary>
    public class CourseOffering
    {
        //TODO: Put a unique constraint on CourseID, CampusId, AcademicYear, Term
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int CampusId { get; set; }
        public string LmsCourseId { get; set; }
        public string CourseName { get; set; }
        public int AcademicYear { get; set; }
        public int TermNumber { get; set; }
        public string AlumniLmsCrseOfferId { get; set; }
        public DateTime OfferingStartDate { get; set; }
        public DateTime OfferingGradDate { get; set; }
        public Campus Campus { get; set; }
        //public Course Course { get; set; }
        //public ICollection<StudentScore> StudentScores { get; set; }
        //public ICollection<Seminar> Seminars { get; set; }
        public ICollection<CourseSection> CourseSections { get; set; }
    }
}
