using Ecat.DataLib;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecat.ModelLib.DomainModel.User;
using Ecat.ModelLib.Utility.Attributes;

namespace Ecat.DataLib.Context
{
    public class ContextUserFactory: IDbContextFactory<ContextUser>
    {
        public ContextUser Create()
        {
            return new ContextUser();
        }      
    }

    public class ContextUser : ContextBase<ConfigUserContext>
    {

        public ContextUser() { }

        public ContextUser(string connectionString = null) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.HasDefaultSchema("User");
            base.OnModelCreating(mb);
        }

        public DbSet<Person> Persons { get; set; }
    }

   

}
