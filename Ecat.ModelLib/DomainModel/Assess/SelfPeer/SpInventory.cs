using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.DomainModel.Assess.SelfPeer
{
    public class SpInventory
    {
        public int Id { get; set; }
        public int SpInstrumentId { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsScored { get; set; }
        public bool IsDisplayed { get; set; }
        public string Behavior { get; set; }

        public SpInstrument SpInstrument { get; set; }
    }
}
