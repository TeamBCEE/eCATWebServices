using System.Collections.Generic;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// Represents the equivalent of Academy Flights, where one course offering will be broken into many course section.
    /// Is directly related to the individual course produce in the LMS, and is used as a container to hold the section members
    /// and there primary course where grades are sent back to. 
    /// </summary>
    public class CourseSection
    {
        public int Id { get; set; }
        public int CourseOfferId { get; set; }
        public int? PrimaryFacultyId { get; set; }
        public CourseOffering CourseOffer { get; set; }
        public SchoolPerson PrimaryFaculty { get; set; }
        public ICollection<StudentSectionMbr> StudSectionMbrs { get; set; }
        public ICollection<FacultySectionMbr> FacSectionMbrs { get; set; }
        //public ICollection<StudentScore> StudentScores { get; set; }
    }
}
