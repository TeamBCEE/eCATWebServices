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
    public class SchoolLogic : LogicBase<ContextSchool>, ISchoolLogic
    {
        private readonly EcEfContext<ContextSchool> _schEfCtx;

        public string Metadata => _schEfCtx.Metadata();

        public SchoolLogic(IServiceProvider provider, EcEfContext<ContextSchool> schEfCtx)
            : base(provider, schEfCtx)
        {
            _schEfCtx = schEfCtx;
        }

    }
}
