using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.Assess.SelfPeer
{
    public class SpBlocModel
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int BlocNumber { get; set; }
        public int InstrumentId { get; set; }
        public decimal MaxStudStratPoints { get; set; }
        public decimal MaxFacStratPoints { get; set; }
        public int LastStudScoredPosition { get; set; }
        public int LastFacScoredPosition { get; set; }
        public bool IsScattered { get; set; }
        public SpInstrument Instrument { get; set; }
        public ICollection<SpBloc> SpBlocs { get; set; }
    }
}
