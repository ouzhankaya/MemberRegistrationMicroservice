using MemberRegistrationMicroservice.DataAccess.Abstract;
using MemberRegistrationMicroservice.Entities.Concrete;
using OK.Core.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberRegistrationMicroservice.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal:EFEntityRepositoryBase<Member, MembershipContext>, IMemberDal
    {

    }
}
