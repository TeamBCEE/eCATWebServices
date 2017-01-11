using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ecat.DataLib.Context;
using Ecat.LogicLib.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Ecat.LogicLib.Utility
{
    public abstract class LogicBase<TContext> where TContext : class, new()
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly BaseEfContext<TContext> _ecEfContext;

        protected LogicBase(IServiceProvider serviceProvider, BaseEfContext<TContext> ecEfContext)
        {
            _serviceProvider = serviceProvider;
            _ecEfContext = ecEfContext;
        }

        protected virtual void PrepareSaveGuard(string guardNamespace)
        {
            var saveGuards = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .Where(c => c.IsClass)
                .Where(c => c.Namespace != null && c.Namespace.Contains(guardNamespace))
                .Where(c => typeof(ISaveGuardian).IsAssignableFrom(c))
                .ToList();

            if (!saveGuards.Any()) return;

            foreach (var guard in saveGuards)
            {
                var guardian = (ISaveGuardian) ActivatorUtilities.CreateInstance(_serviceProvider, guard);
                _ecEfContext.BeforeSaveEntitiesDelegate += guardian.BeforeSaveEntities;
            }
        }
    }
}
