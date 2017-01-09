using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Breeze.ContextProvider;
using Ecat.LogicLib.Interfaces;

namespace Ecat.LogicLib.User.Saveguard
{
    using SaveMap = Dictionary<Type, List<EntityInfo>>;

    public class GuardBase : ISaveGuardian
    {
        public GuardBase()
        {
            
        }

        public SaveMap BeforeSaveEntities(SaveMap saveMap)
        {
            return null;
        }
    }
}
