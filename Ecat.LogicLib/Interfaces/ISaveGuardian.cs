using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breeze.ContextProvider;

namespace Ecat.LogicLib.Interfaces
{
    using SaveMap = Dictionary<Type, List<EntityInfo>>;

    public interface ISaveGuardian
    {
        SaveMap BeforeSaveEntities(SaveMap saveMap);
    }
}
