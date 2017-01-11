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
    public class UserCtxFactory: IDbContextFactory<UserCtx>
    {
        public UserCtx Create()
        {
            return new UserCtx();
        }      
    }

    public class UserCtx : BaseCtx<ConfigUserContext>
    {

        public UserCtx() { }

        public UserCtx(string connectionString = null) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.HasDefaultSchema("usr");
            base.OnModelCreating(mb);
        }

        public DbSet<Person> Persons { get; set; }
    }

   

}
