//using System.Collections.Generic;

//namespace Ecat.ModelLib.DomainModel.School
//{
//    /// <summary>
//    /// Represent a person whose course role is a student or equivalent and is apart of a given class.
//    /// Naturally keyed on the ClassId, Group Set, and PersonId to ensure that a student is assigned to only
//    /// one group set at any given time. If a student has to be moved between group number within the same group set,
//    /// they must first be deleted along with all sp assessment, sp strat and sp comment data. 
//    /// </summary>
//    public class StudentSeminarMbr
//    {
//        public int CourseOfferId { get; set; }
//        public int BlocNumber { get; set; }
//        public int PersonId { get; set; }
//        public int HomeSectionId { get; set; }
//        public int SeminarNumber { get; set; }
//        public bool IsDeleted { get; set; }
//        public StudentSectionMbr SectionMember { get; set; }
//        public CourseSection HomeSection { get; set; }
//        //public Person Person { get; set; }

//        //public ICollection<SpFacResponse> SpsFromFac { get; set; }
//        //public StratFacResponse StratFromFac { get; set; }
//        //public FacComment CommentFromFac { get; set; }


//        //public ICollection<SpStudResponse> SpsAsAssessor { get; set; }
//        //public ICollection<SpStudResponse> SpsAsAssessee { get; set; }

//        //public ICollection<StratStudResponse> StratsAsAssessor { get; set; }
//        //public ICollection<StratStudResponse> StratsAsAssessee { get; set; }

//        //public ICollection<StudComment> CommentsAuthored { get; set; }

//        //public ICollection<StudComment> CommentsReceived { get; set; }

//    }
//}
