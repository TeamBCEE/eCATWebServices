using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.Assess.SelfPeer
{
    public class SpBloc
    {
        public int Id { get; set; }
        public int CourseSectionId { get; set; }
        public int SpBlocModelId { get; set; }
        public SpBlocModel SpBlocModel { get; set; }
        public ICollection<SpGroup> SpGroups { get; set; }
    }
}
