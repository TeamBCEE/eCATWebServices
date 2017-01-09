//using System.Collections.Generic;

//namespace Ecat.ModelLib.DomainModel.School
//{
//    /// <summary>
//    /// Represent a person whose course role is a faculty or equivalent and is apart of a given class.
//    /// Naturally keyed on the ClassId, Group Set, Group Number and PersonId to ensure that a faculty is able to join
//    /// any number of groups exactly once in a given group set. 
//    /// </summary>
//    public class FacultySeminarMbr
//    {
//        public int CourseOfferId { get; set; }
//        public int CourseSectionId { get; set; }
//        public int BlocNumber { get; set; }
//        public int SeminarNumber { get; set; }
//        public int PersonId { get; set; }
//        public CourseSection CourseSection { get; set; }
//        public FacultySectionMbr SectionMember { get; set; }
//        public SchoolPerson Person { get; set; }

//        //public ICollection<SpFacResponse> SpResponses { get; set; }
//        //public ICollection<StratFacResponse> StratReponses { get; set; }
//        //public ICollection<FacComment> Comments { get; set; }
//    }
//}
