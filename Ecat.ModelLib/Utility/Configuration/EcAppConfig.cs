using System;
using System.Collections.Generic;
using System.Text;

namespace Ecat.ModelLib.Utility.Configuration
{
    public class EcAppConfig
    {
        public string UserTokenEndpoint { get; set; }
        public string DbConnection { get; set; }
        public EcAppEndpoints AppEndpoints { get; set; }
    }
}
