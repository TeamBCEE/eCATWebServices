using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.School
{
    /// <summary>
    /// Top level division of school locations.
    /// </summary>
    public class Campus
    {
        public int Id { get; set; }
        /// <summary>
        /// Token used to match an campus to an element in the LMS, i.e. categoryId or displayname.
        /// </summary>
        public string MpLmsMatchKey { get; set; }
        public string LmsAlumniFacultyGroupId { get; set; }
        public string CampusName { get; set; }
        public int CampusZip { get; set; }
        public ICollection<CourseOffering> CourseOfferings { get; set; }
    }
}
