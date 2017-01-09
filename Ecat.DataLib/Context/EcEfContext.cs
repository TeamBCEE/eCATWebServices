using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Ecat.ModelLib.Utility.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Ecat.DataLib.Context
{
    public class EcEfContext<T> : EFContextProvider<T> where T: class, new()
    {
        private readonly string _connectionString;

        public EcEfContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override T CreateContext() {
            return (T) Activator.CreateInstance(typeof(T), _connectionString);
        }
    }
}
