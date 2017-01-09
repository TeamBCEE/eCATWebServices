using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecat.ModelLib.Utility.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ConfigUserContext : Attribute
    {
    }

    [AttributeUsage(AttributeTargets.Class)]
    public class ConfigSchoolContext : Attribute
    {
    }
}
