using System.Collections.Generic;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// Represents ECAT's grouping of people for the explicit purpose of facilating self/peer working groups
    /// and feedback sessions. This is a container that will hold the respective seminar students and faculty.
    /// </summary>
    public class Seminar
    {
        public int Id { get; set; }
        public int BlocNumber { get; set; }
        public int SeminarNumber { get; set; }
        public int ModelId { get; set; }
        public string CustomName { get; set; }
        public string SeminarLocation { get; set; }
        //public SpBlocModel Model { get; set; }
        public CourseOffering CourseOffer { get; set; }
        //public ICollection<StudentSeminarMbr> SeminarStudents { get; set; }
        //public ICollection<FacultySeminarMbr> SeminarFaculty { get; set; }
        //public ICollection<SpFacResponse> SpFacResponses { get; set; }
        //public ICollection<StratFacResponse> StratFacResponses { get; set; }
        //public ICollection<SpStatusAudit> SpStatuses { get; set; }
        //public ICollection<SpStudResponse> SpStudResponses { get; set; }
        //public ICollection<StratStudResponse> StratStudResponses { get; set; }
        //public ICollection<StudComment> StudComments { get; set; }
        //public ICollection<StudCommentFlag> StudCommentFlags { get; set; }
        //public ICollection<FacComment> FacComments { get; set; }
        //public ICollection<FacCommentFlag> FacCommentFlags { get; set; }
    }
}
