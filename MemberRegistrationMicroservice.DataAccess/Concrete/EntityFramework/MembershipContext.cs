using MemberRegistrationMicroservice.Entities.Concrete;
using MemberRegistrationMicroservice.DataAccess.Concrete.EntityFramework.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MemberRegistrationMicroservice.DataAccess.Concrete.EntityFramework
{
   public class MembershipContext:DbContext
    {
        public MembershipContext()
        {
            Database.SetInitializer<MembershipContext>(null);
        }

        public DbSet<Member> Members { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MemberMap());
        }
        
    }
}
