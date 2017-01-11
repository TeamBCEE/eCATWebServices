using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecat.DataLib.Context;
using Ecat.LogicLib.Interfaces;
using Ecat.LogicLib.Utility;

namespace Ecat.LogicLib.School
{
    public class SchoolLogic : LogicBase<SchoolCtx>, ISchoolLogic
    {
        private readonly BaseEfContext<SchoolCtx> _schEfCtx;

        public string Metadata => _schEfCtx.Metadata();

        public SchoolLogic(IServiceProvider provider, BaseEfContext<SchoolCtx> schEfCtx)
            : base(provider, schEfCtx)
        {
            _schEfCtx = schEfCtx;
        }

    }
}
