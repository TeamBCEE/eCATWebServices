using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Ecat.ModelLib.DomainModel.School;
using Ecat.ModelLib.Utility.Attributes;

namespace Ecat.DataLib.Context
{
    public class ContextSchoolFactory : IDbContextFactory<ContextSchool>
    {
        public ContextSchool Create()
        {
            return new ContextSchool();
        }
    }

    public class ContextSchool : ContextBase<ConfigSchoolContext>
    {
        public ContextSchool() { }

        public ContextSchool(string connectionString) : base(connectionString)
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder mb)
        {
            mb.HasDefaultSchema("Sch");
            base.OnModelCreating(mb);
        }

        public DbSet<Campus> Campuses { get; set; }
        public DbSet<CourseOffering> CourseOfferings { get; set; }
        public DbSet<FacultySectionMbr> FacSectionMbrs { get; set; }
        public DbSet<CourseSection> CourseSections { get; set; }
        //public DbSet<FacultySeminarMbr> FacSeminarMbrs { get; set; }
        public DbSet<Seminar> Seminars { get; set; }
        public DbSet<StudentSectionMbr> StudSectionMbrs { get; set; }
        //public DbSet<StudentSeminarMbr> StudSeminarMbrs { get; set; }
    }
}
