using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.Assess.SelfPeer
{
    public class SpGroup
    {
        public int Id { get; set; }
        public int SpBlocId { get; set; }
        public string CustomName { get; set; }
        public string MeetingLocation { get; set; }
        public SpBloc SpBloc { get; set; }
    }
}
