using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Ecat.DataLib.Context;
using Ecat.LogicLib.Interfaces;
using Ecat.LogicLib.Utility;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace Ecat.LogicLib.User
{
    public class UserLogic: LogicBase<UserCtx>, IUserLogic
    {
        private readonly BaseEfContext<UserCtx> _userEfCtx;

        public UserLogic(IServiceProvider provider, BaseEfContext<UserCtx> userCtx) 
            : base(provider, userCtx)
        {
            _userEfCtx = userCtx;
        }

        public string Metadata => _userEfCtx.Metadata();

        public SaveResult ClientSave(JObject saveBundle)
        {
            PrepareSaveGuard("User.Saveguard");
            return _userEfCtx.SaveChanges(saveBundle);
        }
        
        
    }
}
